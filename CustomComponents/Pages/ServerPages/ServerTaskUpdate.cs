using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents;
using SmartCodeLab.CustomComponents.TaskPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System.IO;
using System.Printing;

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class ServerTaskUpdate : UserControl
    {
        public ServerTaskUpdate()
        {
            InitializeComponent();
            //testContainer.AutoScrollMargin = new Size(0, 50);
            this.Load += (s, e) => { SetUpTask(); ReflowItems(); };
        }

        private TaskModel task;
        private Action<TaskModel, List<SubmittedCode>, string> action;
        private string recentReferenceCode;

        public ServerTaskUpdate(TaskModel task, Action<TaskModel, List<SubmittedCode>, string> action)
        {
            InitializeComponent();
            this.task = task;
            this.action = action;
            this.reference.Text = task._referenceFile;
            recentReferenceCode = task._referenceFile;
            
            this.Load += (s, e) => { SetUpTask(); ReflowItems(); };

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void SetUpTask()
        {
            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    exerciseName.Text = task._taskName;
                    subject.Text = task.subject;
                    instruction.Text = task._instructions;

                    testContainer.SuspendLayout();
                    try
                    {
                        testContainer.Controls.Clear();

                        if (task._testCases != null && task._testCases.Count > 0)
                        {
                            foreach (var item in task._testCases)
                            {
                                var tc = new TestCase3(item)
                                {
                                    Dock = DockStyle.None,
                                    AutoSize = false,
                                    Margin = new Padding(0),
                                    Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                                };
                               
                                tc.RemoveRequested += (s, ev) =>
                                {
                                    if (s is TestCase3 toRemove)
                                    {
                                        testContainer.Controls.Remove(toRemove);
                                        toRemove.Dispose();
                                        ReflowItems();
                                    }
                                };

                                testContainer.Controls.Add(tc);
                                
                                testContainer.Controls.SetChildIndex(tc, 0);
                            }
                        }

                       
                        ReflowItems();
                    }
                    finally
                    {
                        testContainer.ResumeLayout(true);
                    }
                }));
            });
        }

      

        private void btn_EditExerciseDetails_Click(object sender, EventArgs e)
        {
            task._instructions = instruction.Text;
            task._testCases.Clear();
            task._referenceFile = reference.Text;
            foreach (var item in testContainer.Controls.OfType<TestCase3>())
            {
                try
                {
                    task._testCases.Add(item.GetTestCase().Key, item.GetTestCase().Value);
                }
                catch (ArgumentException) { }
            }
            string command;
            string tempFilePath;
            string exeFilePath = string.Empty;
            string rootDirectory = SystemConfigurations.TASK_FOLDER;
            //now validate the new reference code
            if ((task.ratingFactors.ContainsKey(2) || task.ratingFactors.ContainsKey(4)) && task._testCases.Count > 0)
            {
                //Java and Cpp needs to be compiled first
                if (task.language != LanguageSupported.Python.ToString())
                {
                    if (task.language == LanguageSupported.Java.ToString())
                    {
                        tempFilePath = Path.Combine(rootDirectory, "Main.java");
                        exeFilePath = Path.Combine(rootDirectory, "Main");
                        command = $"/c \"\"{ProgrammingConfiguration.javac}\" \"{tempFilePath}\" && del \"{tempFilePath}\"\"";
                    }
                    else
                    {
                        tempFilePath = Path.Combine(rootDirectory, "Main.cpp");
                        exeFilePath = Path.Combine(rootDirectory, "Main.exe");
                        command = $"/c \"\"{ProgrammingConfiguration.gccExe}\" -std=c++11 \"{tempFilePath}\" -o \"{exeFilePath}\" && del \"{tempFilePath}\"\"";
                    }

                    File.WriteAllText(tempFilePath, task._referenceFile);
                    string compilationResult = TempSessionManagement2.compileCode(command);
                    if (compilationResult != string.Empty)
                    {
                        MessageBox.Show(compilationResult);
                        return;
                    }
                    //if no error during code compilation, will now proceed to testing the code
                }
                else
                    File.WriteAllText(Path.Combine(rootDirectory, "Main.py"), task._referenceFile);

                command = task.language == LanguageSupported.Python.ToString() ? $"/c \"\"{ProgrammingConfiguration.pythonExe}\" \"{Path.Combine(rootDirectory, "Main.py")}\"\"" :
                            task.language == LanguageSupported.Java.ToString() ? $"/c \"cd \"{rootDirectory}\" && \"{ProgrammingConfiguration.javaExe}\" Main\"" :
                                                                                $"/c \"{exeFilePath}\"";
                MessageBox.Show(command);
                var validateCode = new TestCodeForm(command, task);
                validateCode.ShowDialog();
                if (validateCode.score != task._testCases.Count)
                {
                    validateCode.Dispose();
                    NonBlockingNotification("The reference code failed to satisfy all designated test cases. Please evaluate the failing scenarios and update your implementation as needed.");
                    return;
                }
            }
            recentReferenceCode = task._referenceFile;
            action?.Invoke(task, null, null);
        }

        private void NonBlockingNotification(string message)
        {
            this.BeginInvoke((Action)(() => MessageBox.Show(message)));
        }

        private void UseNewTask(TaskModel newTask)
        {
            task._instructions = newTask._instructions;
            task._taskName = newTask._taskName;
            task._testCases = newTask._testCases;
            task.subject = newTask.subject;
            SetUpTask();
        }

        private void smartButton4_Click(object sender, EventArgs e)
        {
            using (var selectExercise = new SelectExercise(UseNewTask))
            {
                this.SuspendLayout();
                try
                {
                    selectExercise.ShowDialog();

                }
                finally
                {
                    this.ResumeLayout();
                }
            }
        }
        private Color normalcolor = Color.FromArgb(23, 26, 33);
        private Color highlightcolor = Color.FromArgb(23, 191, 32);


        private void btn_details_Click(object sender, EventArgs e)
        {
            task_tabcontrol.SelectedIndex = 0;
            detail_panel.BackColor = highlightcolor;
            reference_panel.BackColor = normalcolor;
            testcase_panel.BackColor = normalcolor;
        }


        private void smartButton3_Click_1(object sender, EventArgs e)
        {
            task_tabcontrol.SelectedIndex = 1;
            reference_panel.BackColor = highlightcolor;
            detail_panel.BackColor = normalcolor;
            testcase_panel.BackColor = normalcolor;
        }

        private void smartButton5_Click_1(object sender, EventArgs e)
        {
            task_tabcontrol.SelectedIndex = 2;
            testcase_panel.BackColor = highlightcolor;
            detail_panel.BackColor = normalcolor;
            reference_panel.BackColor = normalcolor;
        }

        private void btn_AddTestCase_Click_1(object sender, EventArgs e)
        {
            var testcasecontent = new TestCase3();
            testcasecontent.RemoveRequested += (s, ev) =>
            {
                testcasecontent.Dispose();
                ReflowItems();
            };

            testcasecontent.Dock = DockStyle.None;
            testcasecontent.Width = testContainer.ClientSize.Width;
            testcasecontent.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            testContainer.Controls.Add(testcasecontent);
            testContainer.Controls.SetChildIndex(testcasecontent, 0);
            
            ReflowItems();

        }

        private void ReflowItems()
        {
           
            testContainer.SuspendLayout();

            try
            {
                int contentHeight = 0;

               
                var scroll = testContainer.AutoScrollPosition;

                var ordered = testContainer.Controls
                    .Cast<Control>()
                    .Where(c => c.Visible)
                    .OrderBy(c => testContainer.Controls.GetChildIndex(c));

                foreach (Control c in ordered)
                {
                   
                    c.Width = testContainer.DisplayRectangle.Width;

                  
                    c.Location = new Point(scroll.X, scroll.Y + contentHeight);

                   
                    int h = c.AutoSize ? c.PreferredSize.Height : c.Height;
                    contentHeight += h + c.Margin.Bottom;
                }

                
                testContainer.AutoScrollMinSize = new Size(testContainer.DisplayRectangle.Width, contentHeight + 500);
            }
            finally
            {
                testContainer.ResumeLayout(true);
            }
        }


        private void smartButton2_Click_1(object sender, EventArgs e)
        {
            using (var selectExercise = new SelectExercise(UseNewTask))
            {
                this.SuspendLayout();
                try
                {
                    selectExercise.ShowDialog();

                }
                finally
                {
                    this.ResumeLayout();
                }
            }
        }
    }
}
