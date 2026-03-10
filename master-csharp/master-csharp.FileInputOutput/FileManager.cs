
using master_csharp.FileInputOutput;

namespace master_csharp.FileInputOutput
{
    public class FileManager
    {
        private string _filePath;

        public FileManager(string filePath)
        {
            _filePath = filePath;
        }

        // Write content to file (overwrites if exists)
        public void WriteFile(string content)
        {
            try
            {
                File.WriteAllText(_filePath, content);
                Console.WriteLine("File written successfully!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error writing file: " + ex.Message);
            }
        }

        // Append content to file
        public void AppendToFile(string content)
        {
            try
            {
                File.AppendAllText(_filePath, content + Environment.NewLine);
                Console.WriteLine("Content appended successfully!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error appending to file: " + ex.Message);
            }
        }

        // Read entire file
        public void ReadFile()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string content = File.ReadAllText(_filePath);
                    Console.WriteLine("File content:\n" + content);
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }

        // Read file line by line
        public void ReadFileByLine()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    using (StreamReader reader = new StreamReader(_filePath))
                    {
                        string line;
                        Console.WriteLine("Reading file line by line:");
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }

        // Delete the file
        public void DeleteFile()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    File.Delete(_filePath);
                    Console.WriteLine("File deleted successfully!");
                }
                else
                {
                    Console.WriteLine("File does not exist to delete.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error deleting file: " + ex.Message);
            }
        }
    }

}
class FileManagerUsage
{
    public static void use()
    {
        string filePath = "myfile.txt";
        FileManager fileManager = new FileManager(filePath);

        // Writing to file
        fileManager.WriteFile("Hello, this is the first line.");

        // Appending to file
        fileManager.AppendToFile("This is an appended line.");
        fileManager.AppendToFile("Another appended line.");

        // Reading file
        fileManager.ReadFile();

        // Reading file line by line
        fileManager.ReadFileByLine();

        // Deleting the file
        fileManager.DeleteFile();

        // Trying to read deleted file
        fileManager.ReadFile();
    }
}