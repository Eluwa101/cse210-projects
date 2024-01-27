class ScriptureReference
{
    public int StartVerse { get; }
    public int EndVerse { get; }

// the constructor for Scripture Reference
    public ScriptureReference(string reference)
    {
        // this is to parse the reference to extract start and end verse
        var parts = reference.Split(':');
        StartVerse = int.Parse(parts[1].Split('-')[0]);
        EndVerse = parts.Length > 1 ? int.Parse(parts[1].Split('-')[1]) : StartVerse;
    }
}
