using Microsoft.VisualBasic.Devices;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public class TreeNodeObj : TreeNode
    {
        public event EventHandler<MouseEventArgs> MouseClick;
        public bool isDirectory;

        private TreeNodeObj parent;
        private Action<TaskModel> fillTaskFields;

        //this constructor is for task file
        public TreeNodeObj(string filePath, TreeNodeObj parent, Action<TaskModel> fillFields = null) : base(Path.GetFileName(filePath))
        {
            string fileName = this.Name;
            this.parent = parent;
            isDirectory = Directory.Exists(filePath);
            fillTaskFields = fillFields;
            MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    var opt = new FileOptions(Cursor.Position, PossibleActions, isDirectory, filePath);
                    opt.ShowDialog();
                }
                else
                {
                    if (!isDirectory)
                    {
                        TaskModel clickedTask = JsonFileService.LoadFromFile<TaskModel>(filePath);
                        clickedTask.filePath = filePath;
                        fillFields?.Invoke(clickedTask);
                    }
                }
            };

            if (isDirectory)
            {
                foreach (var item in Directory.GetDirectories(filePath))
                {
                    this.Nodes.Add(new TreeNodeObj(item, this, fillFields));
                }

                foreach (var item in Directory.GetFiles(filePath).Where(a => a.EndsWith(".task")))
                {
                    this.Nodes.Add(new TreeNodeObj(item, this, fillFields));
                }
            }
        }
        private void PossibleActions(int actionSequence, string filePath = "")
        {
            switch (actionSequence)
            {
                case 1:
                    parent.Nodes.Remove(this);
                    break;
                case 2://for adding a new file/directory
                    string fileName = Path.GetFileNameWithoutExtension(Path.GetFileName(filePath));
                    JsonFileService.SaveToFile(new TaskModel(fileName), filePath);
                    var newlyAddedTask = new TreeNodeObj(filePath, this, fillTaskFields);
                    this.Nodes.Add(newlyAddedTask);
                    newlyAddedTask.SimulateClicked(new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                    break;
                case 3://for adding a new file/directory
                    Directory.CreateDirectory(filePath);
                    this.Nodes.Add(new TreeNodeObj(filePath, this));
                    break;
            }
        }

        public void SimulateClicked(MouseEventArgs mea)
        {
            MouseClick?.Invoke(this, mea);
        }

    }
}
