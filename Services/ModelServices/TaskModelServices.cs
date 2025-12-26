using ProtoBuf;
using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartCodeLab.Services.ModelServices
{
    public class TaskModelServices
    {
        private static readonly Regex InvalidCharsRegex = new Regex(
            @"[<>:""/\\|?*\x00-\x1F]",
            RegexOptions.Compiled
        );
        public static (bool, string) createTaskModel(TaskModel newTask, List<string> existingFiles)
        {
            (bool isValid, string validationMsg) = validateFields(newTask);

            if (isValid)
            {
                string filePath = Path.Combine(SystemConfigurations.TASK_FOLDER, newTask._taskName.Trim() + ".task");
                foreach (var item in existingFiles)
                {
                    if(item.Equals(filePath, StringComparison.OrdinalIgnoreCase))
                        return (false, "A task with the same name already exists.");
                }

                using (var createdFile = File.Create(filePath))
                {
                    newTask.filePath = filePath;
                    Serializer.SerializeWithLengthPrefix<TaskModel>(createdFile, newTask, PrefixStyle.Base128);
                    createdFile.Close();
                }
                return (true, "Task created successfully.");
            }

            return (false, validationMsg);
        }

        private static (bool, string) validateFields(TaskModel task)
        {
            if (task._taskName.IsWhiteSpace())
                return (false, "Task name cannot be empty or whitespace.");
            else if (InvalidCharsRegex.IsMatch(task._taskName))
                return (false, "Task name contains invalid characters.");
            else if (task._testCases.Count < 3)
                return (false, "At least 3 test cases are required.");

            return (true, "Validation successful.");
        }

        public static (bool, string) updateTaskModel(TaskModel updatedTask, TaskModel oldTask, List<string> existingFiles)
        {
            (bool isValid, string validationMsg) = validateFields(updatedTask);

            if (isValid)
            {
                string filePath = Path.Combine(SystemConfigurations.TASK_FOLDER, updatedTask._taskName.Trim() + ".task");
                foreach (var item in existingFiles)
                {
                    if (item.Equals(filePath, StringComparison.OrdinalIgnoreCase) && !oldTask.filePath.Equals(item))
                        return (false, "A task with the same name already exists.");
                }
                File.Delete(oldTask.filePath);
                using (var createdFile = File.Create(filePath))
                {
                    updatedTask.filePath = filePath;
                    Serializer.SerializeWithLengthPrefix<TaskModel>(createdFile, updatedTask, PrefixStyle.Base128);
                    createdFile.Close();
                }
                return (true, "Task updated successfully.");
            }

            return (false, validationMsg);
        }
    }
}
