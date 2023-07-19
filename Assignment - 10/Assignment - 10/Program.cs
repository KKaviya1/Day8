using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Create");
        Console.WriteLine("2. Read");
        Console.WriteLine("3. Append");
        Console.WriteLine("4. Delete");
        Console.WriteLine(" ");    


        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the file name: ");
                string createFileName = Console.ReadLine();
                Console.WriteLine("Enter the content: ");
                string createContent = Console.ReadLine();
                CreateFile(createFileName, createContent);
                Console.WriteLine("successfully created a new file.");
                break;

            case 2:
                Console.WriteLine("Enter the file name: ");
                string readFileName = Console.ReadLine();
                string fileContent = ReadFile(readFileName);
                Console.WriteLine("File content:");
                Console.WriteLine(fileContent);
                break;

            case 3:
                Console.WriteLine("Enter the file name: ");
                string appendFileName = Console.ReadLine();
                Console.WriteLine("Enter the content to append: ");
                string appendContent = Console.ReadLine();
                AppendToFile(appendFileName, appendContent);
                Console.WriteLine("Content appended successfully.");
                break;

            case 4:
                Console.WriteLine("Enter the file name: ");
                string deleteFileName = Console.ReadLine();
                DeleteFile(deleteFileName);
                Console.WriteLine("File has been deleted successfully.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        Console.WriteLine("\n ***End of the Program***");
        Console.ReadKey();
    }

    static void CreateFile(string fileName, string content)
    {
        File.WriteAllText(fileName, content);
    }

    static string ReadFile(string fileName)
    {
        string fileContent = File.ReadAllText(fileName);
        return fileContent;
    }

    static void AppendToFile(string fileName, string content)
    {
        File.AppendAllText(fileName, content);
    }

    static void DeleteFile(string fileName)
    {
        File.Delete(fileName);
    }
}
