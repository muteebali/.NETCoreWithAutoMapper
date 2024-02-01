namespace Automapper.Console.Domain
{
    public class TypeConversion_Source

    {
        public string Latitude { get; set; } = null!;
        public string Hours { get; set; } = null!;
        public string Days { get; set; } = null!;
        public string? Date { get; set; } 
    }

    public class TypeConversion_Destination
    {
        public int Latitude { get; set; }
        public int Hours { get; set; }
        public string Days { get; set; }
        public DateTime? Date { get; set; } 

    }
}
