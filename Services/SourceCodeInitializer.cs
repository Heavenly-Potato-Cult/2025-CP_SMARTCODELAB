using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartCodeLab.Services
{
    public class SourceCodeInitializer
    {
        public static readonly Dictionary<LanguageSupported, string> extension = new Dictionary<LanguageSupported, string>() 
        {
            {LanguageSupported.Java,".java" },
            {LanguageSupported.Python,".py" },
            {LanguageSupported.Cpp, ".cpp"}
        };

        public static string ValidName(string fileName)
        {
            while (Char.IsDigit(fileName[0]))
                fileName = fileName.Substring(1);
            fileName = Regex.Replace(fileName, @"[^a-zA-Z0-9]", "_");
            return fileName;
        }

        public static void InitializeSourceCode(LanguageSupported language,string filePath, string fileName)
        {
            string srcCode = String.Empty;
            fileName = ValidName(fileName);
            switch (language)
            {//other languages implementations will come next
                case LanguageSupported.Java:
                    srcCode =
                        """
                            public class fileName{
                                public static void main(String[] args) {
                                    System.out.println("Hello, World!");
                                }
                            }
                        """.Replace("fileName", fileName);
                    break;
                case LanguageSupported.Python:
                    srcCode =
                        """
                            #pagsugod na dra ug code
                        """;
                    break;
                default:
                    srcCode = """
                        #include <iostream>

                        int main() {
                            std::cout << "Hello, World!" << std::endl;

                            return 0;
                        }
                        """;
                        break;
            }

            string fileAbsolutePath = filePath + "\\" + fileName + extension[language];
            if(!File.Exists(fileAbsolutePath))
                File.WriteAllText(fileAbsolutePath, srcCode);

            InitializeTesterSourceCode(language, filePath, fileName);

        }
        public static void InitializeTesterSourceCode(LanguageSupported language,string filePath, string fileName) 
        {
            string srcCode = string.Empty;
            string actualFileName = ValidName(fileName);
            string exeDirectory = Path.Combine(filePath,actualFileName+".exe").Replace("\\", "\\\\");
            switch (language) 
            {
                case LanguageSupported.Java:
                    srcCode = $$"""
                        import java.io.ByteArrayInputStream;
                        import java.io.ByteArrayOutputStream;
                        import java.io.PrintStream;
                        public class Tester {
                            public static void main(String[] args) {
                                PrintStream originalOut = System.out;
                                var baos = new ByteArrayOutputStream();
                                System.setOut(new PrintStream(baos));
                                System.setIn(new ByteArrayInputStream("userInput".getBytes())); //change theInput
                                fileClassName.main(null);

                                System.setOut(originalOut);
                                System.out.println(baos.toString());
                            }
                        }
                        """.Replace("fileClassName", ValidName(actualFileName));
                    break;
                case LanguageSupported.Python:
                    srcCode = $$"""
                        import subprocess,os

                        base = os.path.dirname(__file__)  # folder where Tester.py is located
                        script = os.path.join(base, "fileName.py")

                        subprocess.run(["python", script], input="userInput", text=True)
                        """
                            .Replace("fileName",actualFileName);
                    break;
                default:
                    srcCode = $$"""
                                #include <cstdlib>
                                #include <iostream>

                                int main() {
                                    int result = system(
                                        "cd /d \"gccBin\" && "
                                        "g++ \"filePath\" "
                                        "-o \"exeDirectory\" && "
                                        "(userInput) | \"exeDirectory\""
                                        );
                                    return result;
                                }
                                """
                                .Replace("gccBin", ProgrammingConfiguration.gccBin.Replace("\\","\\\\"))
                                .Replace("filePath", Path.Combine(filePath, actualFileName + ".cpp").Replace("\\", "\\\\"))
                                .Replace("exeDirectory",exeDirectory);
                    break;
            }
            string fileAbsolutePath = filePath + "\\Tester"+extension[language];
            File.WriteAllText(fileAbsolutePath, srcCode);
        }
    }
}
