using ProtoBuf;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace SmartCodeLab.Services.ModelServices
{
    public class ServerServices
    {
        private static readonly Regex InvalidCharsRegex = new Regex(
            @"[<>:""/\\|?*\x00-\x1F]",
            RegexOptions.Compiled
        );
        public static (Server?, string) getServer(string serverName,
            string password, 
            object language, 
            CodeQualityChoices2 factorRatings,
            TaskModel selectedTask,
            Dictionary<string, UserProfile> userProfiles)
        {
            if (serverName.Trim().IsWhiteSpace())
                return (null, "Server name cannot be empty or whitespace.");
            else if(InvalidCharsRegex.IsMatch(serverName))
                return (null, "Server name contains invalid characters.");
            else if (didServerNameExists(serverName))
                return (null, "Session Name is Already Used");
            else if(language == null || language.ToString() == "")
                return (null, "Please select a language.");
            else if(password.IsWhiteSpace())
                return (null, "Password cannot be empty or whitespace.");

            List<int> haveZeroRating = new List<int>();
            foreach (var item in factorRatings.GetRatingFactors())
                if (item.Value[0] == 0)
                    haveZeroRating.Add(item.Key);

            TaskModel task = selectedTask ?? new TaskModel();
            task.ratingFactors = factorRatings.GetRatingFactors();
            task._referenceFile = factorRatings.bestSourceCode;
            task.efficiencyMetrics = new Dictionary<string, int>();
            task.language = language.ToString();

            if (haveZeroRating.Count > 0)
            {
                string[] statsName = { "", "", "Efficiency", "Robustness", "Maintainability" };
                string withZero = string.Join('\n',
                    haveZeroRating.Select(num => statsName[num]).ToArray());
                return (null, "The following have 0 stats weight, better remove or update weight: \n" + withZero);
            }
            else if (factorRatings.GetRatingFactors().ContainsKey(2) && task._testCases.Count > 0)
            {
                (bool isPerfect, Dictionary<string, int>? inputTotalOperators) = TempSessionManagement2.ValidateCode(factorRatings.bestSourceCode, task._language, task);
                if (!isPerfect)
                {
                    return (null,"The code you provided as a reference for efficiency is not accurate.");
                }
                task.efficiencyMetrics = inputTotalOperators ?? new Dictionary<string, int>();
            }

            return (new Server(serverName, password, task, language.ToString(), userProfiles), "");
        }

        private static bool didServerNameExists(string serverName)
        {
            foreach (var file in Directory.EnumerateFiles(SystemConfigurations.SESSIONS_FOLDER))
            {
                if (Path.GetFileNameWithoutExtension(file).Trim().Equals(serverName.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public static async Task<bool> saveSession(string serverName, ProgrammingSession session)
        {
            try
            {
                string filePath = Path.Combine(SystemConfigurations.SESSIONS_FOLDER, serverName + ".session");
                using (var fileStream = new FileStream(
                                            filePath,
                                            FileMode.Create,            // always create or overwrite file
                                            FileAccess.Write,           // write-only access
                                            FileShare.None              // don't allow other processes to open it simultaneously
                                        ))
                {
                    Serializer.SerializeWithLengthPrefix(fileStream, session, PrefixStyle.Base128);
                    await fileStream.FlushAsync();
                    //NonBlockingNotification("Session file saved successfully");
                    SystemSingleton.Instance.addSession?.Invoke(session);
                }
            }
            catch (Exception ex)
            {
                // Log the error instead of crashing the timer
                Console.WriteLine($"Failed to save session: {ex.Message}");
                return false;
            }
            return true;
        }
    }
}
