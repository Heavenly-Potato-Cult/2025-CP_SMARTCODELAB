using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs.StudentTable;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace SmartCodeLab.CustomComponents.ServerPageComponents.ClassManagerComponents
{
    public partial class AddClass : Form
    {
        private Dictionary<string, UserProfile> expectedUsers;
        private Dictionary<string, StudentRow> userIcons;
        private bool isEditMode;
        private long searchVersion;
        private System.Threading.Timer searchDebounce;
        private static readonly Regex InvalidCharsRegex = new Regex(
            @"[<>:""/\\|?*\x00-\x1F]",
            RegexOptions.Compiled
        );
        public ClassInformation currentClassInfo { get; private set; }
        public List<string> existingClassFiles { get; private set; }
        public AddClass(List<string> existingClasses)
        {
            InitializeComponent();
            setSchoolYear();
            userIcons = new Dictionary<string, StudentRow>();
            expectedUsers = new Dictionary<string, UserProfile>();
            existingClassFiles = new List<string>();
            schoolYear.textBox1.ReadOnly = true;
            existingClassFiles.AddRange(existingClasses);
            setUpSearchBox();
        }

        public AddClass(ClassInformation classInfo, List<string> existingClasses)
        {
            InitializeComponent();
            schoolYear.textBox1.ReadOnly = true;
            currentClassInfo = classInfo;
            isEditMode = true;
            userIcons = new Dictionary<string, StudentRow>();
            expectedUsers = new Dictionary<string, UserProfile>();
            existingClassFiles = new List<string>();
            existingClassFiles.AddRange(existingClasses);
            subCode.Texts = classInfo.subjectCode;
            subDesc.Texts = classInfo.subjectDesc;
            schoolYear.Texts = classInfo.schoolYear;
            course.Texts = classInfo.course;
            section.Texts = classInfo.section;
            yearLvl.SelectedItem = classInfo.yearLevel.ToString();
            semester.SelectedItem = classInfo.semester.ToString();
            setUpSearchBox();

            var userDict = classInfo.students.ToDictionary(user => user._studentId, user => user);
            this.Load += (s, e) => addUsers(userDict);
        }

        private void setSchoolYear()
        {
            int schoolYearStart = 0;

            DateTime now = DateTime.Now;

            int schoolStartMonth = 8;

            if (now.Month < schoolStartMonth)
            {
                schoolYearStart = now.Year - 1;
            }
            else
            {
                schoolYearStart = now.Year;
            }
            schoolYearStart += (int)numericUpDown.Value;
            schoolYear.Texts = $"{schoolYearStart}-{schoolYearStart + 1}";
        }

        private void setUpSearchBox()
        {
            search.innerTextBox.TextChanged += async (s, e) =>
            {
                searchDebounce?.Change(Timeout.Infinite, Timeout.Infinite);
                searchDebounce?.Dispose();
                searchDebounce = new System.Threading.Timer(async _ =>
                {
                    _ = displayUsers();
                }, null, 300, Timeout.Infinite);
            };
        }

        private void AddNewExercise_Load(object sender, EventArgs e)
        {
            panel_temp_spacer.BackColor = Color.Transparent;
        }

        private void btn_CreateExercise_Click(object sender, EventArgs e)
        {
            var (isValid, validationMessage) = validateInputs();
            if (!isValid)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string filePath = Path.Combine(SystemConfigurations.CLASSES_DIRECTORY, $"{subCode.Texts.Trim()}.dat");
            var classInfo = new ClassInformation.Builder()
                .WithSubjectCode(subCode.Texts.Trim())
                .WithSubjectDesc(subDesc.Texts)
                .WithSchoolYear(schoolYear.Texts)
                .WithCourse(course.Texts)
                .WithSection(section.Texts)
                .WithSemester(getSemester())
                .WithYearLevel(int.Parse(yearLvl.SelectedItem.ToString()))
                .WithStudents(getExpectedUsersList())
                .WithFilepath(filePath)
                .Build();

            bool isSuccess = false;
            string msg = "";

            if (isEditMode)
                (isSuccess, msg) = updateClass(classInfo);
            else
                (isSuccess, msg) = createClass(classInfo);

            if (isSuccess)
            {
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConfirmAndCloseForm();
            }
            else
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private (bool, string) createClass(ClassInformation classInformation)
        {
            foreach (var item in existingClassFiles)
            {
                if (item.Equals(classInformation.subjectCode.Trim(), StringComparison.OrdinalIgnoreCase))
                    return (false, "A class with the same Subject Code already exists.");
            }

            using (var createdFile = File.Create(classInformation.filepath))
            {
                Serializer.SerializeWithLengthPrefix<ClassInformation>(createdFile, classInformation, PrefixStyle.Base128);
                createdFile.Flush();
            }
            currentClassInfo = classInformation;
            return (true, "Class created successfully.");
        }

        private (bool, string) updateClass(ClassInformation newClass)
        {
            //check for another class with same subject code but not the same as old class
            foreach (var item in existingClassFiles)
            {
                if (item.Equals(newClass.subjectCode.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    !item.Equals(currentClassInfo.subjectCode.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return (false, "A class with the same Subject Code already exists.");
                }
            }
            File.Delete(currentClassInfo.filepath);
            using (var createdFile = File.Create(newClass.filepath))
            {
                Serializer.SerializeWithLengthPrefix<ClassInformation>(createdFile, newClass, PrefixStyle.Base128);
                createdFile.Flush();
            }
            currentClassInfo = newClass;
            return (true, "Class updated successfully.");
        }

        private List<UserProfile> getExpectedUsersList()
        {
            return expectedUsers.Values.ToList();
        }

        private Semester getSemester()
        {
            string selected = semester.SelectedItem.ToString();
            return selected == "First" ? Semester.First : selected == "Second" ? Semester.Second : Semester.Summer;
        }

        private void ConfirmAndCloseForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_CancelExercise_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void smartButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select the CSV file containing student records with 'Name' and 'Student Id' columns.");
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                fileDialog.Title = "Select Student Records File";
                fileDialog.Multiselect = false;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var studTab = new StudTable();
                    var studentRecords = await studTab.getStudentsFromCSV(fileDialog.FileName);
                    await Task.Run(() =>
                    {
                        if (studentRecords == null)
                            MessageBox.Show("File is missing the required columns");
                        else if (studentRecords.Count == 0)
                            MessageBox.Show("No student record found");
                        else
                        {
                            addUsers(studentRecords);
                        }
                    });
                }
            }
        }

        private void addUsers(Dictionary<string, UserProfile> users)
        {
            foreach (var item in users)
            {
                if (!expectedUsers.ContainsKey(item.Key) && !item.Key.IsWhiteSpace())
                {
                    var newlyAddedUser = new UserProfile(item.Value._studentName, item.Value._studentId, "N/A");
                    var newUserIcon = new StudentRow(item.Key, item.Value._studentName, removeUser, updateUser, null);
                    userIcons.Add(item.Key, newUserIcon);
                    expectedUsers.Add(item.Key, item.Value);
                }
            }
            displayUsers();
        }

        private Task displayUsers()
        {
            long currentVersion = ++searchVersion;
            string searchText = search.innerTextBox.Text.Trim();
            searchText = searchText.Equals("Search Name", StringComparison.OrdinalIgnoreCase) ? "" : searchText;
            List<UserProfile> filteredUsers = expectedUsers.Values
                .Where(user => user._studentName.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();
            this.Invoke(new Action(() =>
            {
                studtab.Controls.Clear();
                foreach (var item in filteredUsers)
                {
                    if (currentVersion != searchVersion)
                        break;

                    try
                    {
                        var icon = userIcons[item._studentId];
                        icon.Dock = DockStyle.Top;
                        studtab.Controls.Add(icon);
                    }
                    catch (KeyNotFoundException)
                    {
                        // Ignore missing user icons
                    }
                }
            }));
            return Task.CompletedTask;
        }

        private void updateUser(UserProfile user)
        {
            expectedUsers[user._studentId] = user;
        }

        private void removeUser(string studentId)
        {
            if (expectedUsers.ContainsKey(studentId))
            {
                expectedUsers.Remove(studentId);
            }
            if (userIcons.ContainsKey(studentId))
            {
                userIcons.Remove(studentId);
            }
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {
            var studentForm = new StudentForm();
            if (studentForm.ShowDialog() == DialogResult.OK)
            {
                var newUser = studentForm.NewUser();
                if (expectedUsers.ContainsKey(newUser.Key))
                {
                    MessageBox.Show("Student ID Already Exists");
                    return;
                }
                var userProfile = new UserProfile(newUser.Value, newUser.Key, "N/A");
                addUsers(new Dictionary<string, UserProfile>() { { newUser.Key, userProfile } });
            }
        }

        private (bool, string) validateInputs()
        {
            if (subCode.Texts.IsWhiteSpace())
                return (false, "Subject Code is required.");
            else if (InvalidCharsRegex.IsMatch(subCode.Texts))
                return (false, "Subject Code contains invalid characters.");
            else if (subDesc.Texts.IsWhiteSpace())
                return (false, "Subject Description is required.");
            else if (schoolYear.Texts.IsWhiteSpace())
                return (false, "School Year is required.");
            else if (course.Texts.IsWhiteSpace())
                return (false, "Course is required.");
            else if (section.Texts.IsWhiteSpace())
                return (false, "Section is required.");
            else if (semester.SelectedItem == null)
                return (false, "Semester is required.");
            else if (yearLvl.SelectedItem == null)
                return (false, "Year Level is required.");

            return (true, "All inputs are valid.");
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            setSchoolYear();
        }
    }
}
