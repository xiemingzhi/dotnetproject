/*
Read Write to File
*/
class FileIO
{
    public void ReadFileExample(string parameter)
    {
        // Read the file as one string.
        string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");

        // Display the file contents to the console. Variable text is a string.
        Console.WriteLine("Contents of WriteText.txt = {0}", text);
    }

    public void ReadWriteExample(string parameter)
    {
        // Define the file path
        string filePath = "example.txt";

        // Write to the file
        WriteToFile(filePath, "Hello, world!");

        // Read from the file and print the contents to the console
        string fileContents = ReadFromFile(filePath);
        Console.WriteLine(fileContents);    
    }

    public static void WriteToFile(string filePath, string text)
    {
        // Open the file for writing
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Write the text to the file
            writer.Write(text);
        }
    }

    public static string ReadFromFile(string filePath)
    {
        string fileContents = "";

        // Open the file for reading
        using (StreamReader reader = new StreamReader(filePath))
        {
            // Read the contents of the file into a string
            fileContents = reader.ReadToEnd();
        }

        return fileContents;
    }

}