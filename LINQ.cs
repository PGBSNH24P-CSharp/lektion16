namespace lektion16;

public class LINQ
{
    public static void Run()
    {
        // https://www.csharptutorial.net/csharp-linq/
        // LINQ
        // Method syntax
        // Query syntax
        // Where
        // Select
        // OrderBy
        // Sort
        // Skip

        List<string> countries = [
            "Sweden",
            "Finland",
            "Denmark",
            "Norway"
        ];

        IEnumerable<string> filtered = countries
            .Where((country) => !country.Contains("e"));

        // Chaining
        // Function/method chaining
        string s = "fjre";
        foreach (char c in s) {}
    
        foreach(string country in filtered) {
            Console.WriteLine(country);
        }

        IEnumerable<int> characters = countries
            .Select((country) => country.Length);

        foreach (int size in characters) {
            Console.WriteLine(size);
        }
    }
}
