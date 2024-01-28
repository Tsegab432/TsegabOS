using System;
using System.Collections.Generic;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using Sys = Cosmos.System;

namespace TsegabOS.Apps
{
    public class Program
    {
        public static void Main()
        {
            FileOperations();
        }

        public static void FileOperations()
        {
            SimpleFileSystem fileSystem = new SimpleFileSystem(); // Create an instance of your file system

            while (true)
            {
                Console.Write("FileViewer> ");
                string command = Console.ReadLine();

                if (command == "help")
                {
                    Console.WriteLine(@"add [your file name.txt] - to create a new file
delete [your file name.txt] - to delete the file
edit [your file name.txt] - to edit the file contents
view [your file name.txt] - to view the contents");
                }
                if (command == "exit")
                {
                    break;
                }
                else if (command == "list")
                {
                    List<string> fileList = fileSystem.GetFileList();
                    Console.WriteLine("Files in the system:");
                    foreach (string fileName in fileList)
                    {
                        Console.WriteLine(fileName);
                    }
                }
                else if (command.StartsWith("add "))
                {
                    string fileName = command.Substring(4);
                    fileSystem.CreateFile(fileName);
                    Console.WriteLine($"File '{fileName}' added.");
                }
                else if (command.StartsWith("delete "))
                {
                    string fileName = command.Substring(7);
                    if (fileSystem.FileExists(fileName))
                    {
                        fileSystem.DeleteFile(fileName);
                        Console.WriteLine($"File '{fileName}' deleted.");
                    }
                    else
                    {
                        Console.WriteLine($"File '{fileName}' not found.");
                    }
                }
                else if (command.StartsWith("edit "))
                {
                    string fileName = command.Substring(5);
                    if (fileSystem.FileExists(fileName))
                    {
                        Console.Write("Enter additional content: ");
                        string additionalContent = Console.ReadLine();
                        fileSystem.EditFile(fileName, additionalContent);
                        Console.WriteLine($"File '{fileName}' edited.");
                    }
                    else
                    {
                        Console.WriteLine($"File '{fileName}' not found.");
                    }
                }
                else if (command.StartsWith("view "))
                {
                    string fileName = command.Substring(5);
                    if (fileSystem.FileExists(fileName))
                    {
                        string content = fileSystem.ReadFile(fileName);
                        Console.WriteLine($"Content of '{fileName}':");
                        Console.WriteLine(content);
                    }
                    else
                    {
                        Console.WriteLine($"File '{fileName}' not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }
            }
        }
    }

    public class SimpleFileSystem
    {
        private string fileContent = "";
        private bool fileExists = false;
        private List<string> fileNames = new List<string>();

        public void CreateFile(string fileName)
        {
            Console.WriteLine($"Creating file: {fileName}");
            fileExists = true;
            fileNames.Add(fileName);
        }

        public void WriteToFile(string fileName, string content)
        {
            Console.WriteLine($"Writing content to {fileName}: {content}");
            fileContent = content;
        }

        public string ReadFile(string fileName)
        {
            Console.WriteLine($"Reading content from {fileName}");
            return fileContent;
        }

        public void DeleteFile(string fileName)
        {
            Console.WriteLine($"Deleting file: {fileName}");
            fileContent = "";
            fileExists = false;
            fileNames.Remove(fileName);
        }

        public void EditFile(string fileName, string additionalContent)
        {
            Console.WriteLine($"Editing content of {fileName}: {additionalContent}");
            fileContent += additionalContent;
        }

        public bool FileExists(string fileName)
        {
            return fileExists;
        }

        public List<string> GetFileList()
        {
            return fileNames;
        }
    }
}
