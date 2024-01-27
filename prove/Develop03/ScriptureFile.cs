// ScriptureLoader.cs
using System.IO;

class ScriptureLoader
{
    // the scripture file reader class
    public static Scripture LoadScriptureFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);

        if (lines.Length > 0)
        {
            string reference = lines[0];
            string text = string.Join(" ", lines.Skip(1));

            return new Scripture(reference, text);
        }

        return null;
    }
}
