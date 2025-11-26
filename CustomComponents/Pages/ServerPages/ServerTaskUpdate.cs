using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.CustomComponents.TaskPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class ServerTaskUpdate : UserControl
    {
        public ServerTaskUpdate()
        {
            InitializeComponent();
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
            this.Load += (s,e) => SetUpTask();
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
                    exerciseName.Texts = task._taskName;
                    subject.Texts = task.subject;
                    instruction.Texts = task._instructions;

                    testContainer.Controls.Clear();
                    if (task._testCases != null && task._testCases.Count > 0)
                    {
                        foreach (var item in task._testCases)
                        {
                            testContainer.Controls.Add(new TestCase(item));
                        }
                    }
                }));
            });
        }

        private void btn_AddTestCase_Click(object sender, EventArgs e)
        {
            testContainer.Controls.Add(new TestCase());
        }

        private void btn_EditExerciseDetails_Click(object sender, EventArgs e)
        {
            task._instructions = instruction.Texts;
            task._testCases.Clear();
            task._referenceFile = reference.Text;
            foreach (var item in testContainer.Controls.OfType<TestCase>())
            {
                try
                {
                    task._testCases.Add(item.Value().Key, item.Value().Value);
                }catch(ArgumentException) { }
            }
            string command;
            string tempFilePath;
            string exeFilePath = string.Empty;
            string rootDirectory = SystemConfigurations.TASK_FOLDER;
            //now validate the new reference code
            if (task.ratingFactors.ContainsKey(2) && task._testCases.Count > 0 && recentReferenceCode != task._referenceFile)
            {
                //Java and Cpp needs to be compiled first
                if (task.language != LanguageSupported.Python.ToString())
                {
                    if (task.language == LanguageSupported.Java.ToString())
                    {
                        tempFilePath = Path.Combine(rootDirectory, "Main.java");
                        exeFilePath = Path.Combine(rootDirectory, "Main.class");
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

                command =   task.language == LanguageSupported.Python.ToString() ? $"/c \"\"{ProgrammingConfiguration.pythonExe}\" \"{Path.Combine(rootDirectory, "Main.py")}\"\"" :
                            task.language == LanguageSupported.Java.ToString() ? $"/c \"\"{ProgrammingConfiguration.javaExe}\" \"{exeFilePath}\"\"" : 
                                                                                $"/c \"{exeFilePath}\"";
                var validateCode = new TestCodeForm(command, task);
                validateCode.ShowDialog();
                if(validateCode.score != task._testCases.Count)
                {
                    validateCode.Dispose();
                    MessageBox.Show("The reference code failed to satisfy all designated test cases. Please evaluate the failing scenarios and update your implementation as needed.");
                    return;
                }
            }
            recentReferenceCode = task._referenceFile;
            action?.Invoke(task, null, null);
        }
    }
}
