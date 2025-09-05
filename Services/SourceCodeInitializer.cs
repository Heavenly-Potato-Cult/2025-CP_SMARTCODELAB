using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            fileName = fileName.Replace('.', '_').Replace(' ', '_');
            return fileName;
        }

        public static void InitializeSourceCode(LanguageSupported language,string filePath, string fileName)
        {
            string srcCode = String.Empty;
            fileName = ValidName(fileName);
            fileName = fileName.Replace('.', '_').Replace(' ', '_');
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
                        """.Replace("fileName",fileName);
                    break;
            }

            string fileAbsolutePath = filePath + "\\" + fileName + extension[language];
            if(!File.Exists(fileAbsolutePath))
                File.WriteAllText(fileAbsolutePath, srcCode);

        }

        public static void InitializeSourceCodeJavaTester(string filePath, string fileName)
        {
            string srcCode = $$"""
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
                """.Replace("fileClassName",ValidName(fileName));

            string fileAbsolutePath = filePath + "\\Tester.java";
            File.WriteAllText(fileAbsolutePath,srcCode);
        }
    }
}
