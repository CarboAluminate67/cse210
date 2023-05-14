public class Journal
{
    public List<string> _entries;
    public Journal()
    {
    }

    public void Display()
    {
        foreach (string entry in this._entries){
            if (entry != ""){
                string[] parts = entry.Split("|");
                Console.WriteLine(parts[0]);
                Console.WriteLine(parts[1]);
                Console.WriteLine();
            }

        }
    }

    public void Save(){
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();

        using (StreamWriter fileWriter = new StreamWriter(fileName))
        {
            foreach (string entry in this._entries)
            {
                fileWriter.WriteLine(entry);
                fileWriter.WriteLine();
            }
        }
    }
    public void Load(){
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        this._entries.Clear();

        foreach (string line in lines){
            this._entries.Add(line);
        }
    }

    public void Clear(){
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();

        using (StreamWriter fileWriter = new StreamWriter(fileName))
        {
            fileWriter.WriteLine();
        }
    }

}