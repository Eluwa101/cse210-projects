
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

class Journal
{
    public List<Entry> Entries;
    public string UserName {get; set; }
    public Journal(string UserName)
    {
        this.UserName = UserName;
        Entries = new List<Entry>();
    }
    // journal method
    public Journal()
    {
        Entries = new List<Entry>();
    }
//  entry method
    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

//  this method displays the user input alongside the random prompt and date
    public void DisplayEntries()
    {
        Console.WriteLine($"Journal for {UserName}:\n");

        foreach (var entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

// this method writes the journal into the text format
    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"Username: {UserName}");
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{UserName}|{entry.Date} | {entry.Prompt} | {entry.Response}");
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to file: {ex.Message}");
        }
    }

// this method reads the text for the journal
    public void LoadFromFile(string fileName)
    {
        try
        {
            Entries.Clear(); 
            using (StreamReader reader = new StreamReader(fileName))
            {
                string firstLine = reader.ReadLine();
                if(firstLine != null && firstLine.StartsWith("Username: "))
                {
                    UserName = firstLine.Substring("Username: ".Length).Trim();
                }
                while (!reader.EndOfStream)
                {
                    string[] entryData = reader.ReadLine().Split('|');
                    string Username = entryData[0].Trim();
                    DateTime date = DateTime.Parse(entryData[1].Trim());
                    string prompt = entryData[2].Trim();
                    string response = entryData[3].Trim();
                    if(UserName == UserName)
                    {
                        Entry loadedEntry = new Entry(response, prompt, date);
                        Entries.Add(loadedEntry);
                    }    

                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: {ex.Message}");
        }
    }

// this method writes the journal into csv
    public void SaveToCsv(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Date,Prompt,Response");

                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{FormatCsvField(entry.Date.ToString("yyyy-MM-dd HH:mm:ss"))},{FormatCsvField(entry.Prompt)},{FormatCsvField(entry.Response)}");
                }
            }
            Console.WriteLine("Journal saved successfully as CSV!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to CSV: {ex.Message}");
        }
    }

// this is the method for the csv file format
    public void LoadCsv(string fileName)
    {
        try
        {
            Entries.Clear(); 
            using (StreamReader reader = new StreamReader(fileName))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string[] entryData = reader.ReadLine().Split(',');

                    DateTime date = DateTime.ParseExact(entryData[0], "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    string prompt = ParseCsvField(entryData[1]);
                    string response = ParseCsvField(entryData[2]);

                    Entry loadedEntry = new Entry(response, prompt, date);
                    Entries.Add(loadedEntry);
                }
            }
            Console.WriteLine("Journal successfully loaded from csv format!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from CSV: {ex.Message}");
        }
    }

// this method formats the csv correctly
    public string FormatCsvField(string field)
    {
        if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
        {
            return $"\"{field.Replace("\"", "\"\"")}\"";
        }
        return field;
    }

//  this is the method for parsing the csv
    public string ParseCsvField(string field)
    {
        if (field.StartsWith("\"") && field.EndsWith("\""))
        {
            return field.Substring(1, field.Length - 2).Replace("\"\"", "\"");
        }
        return field;
    }
}
