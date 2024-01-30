namespace Automapper.console.Models
{
    public class CustomValueResolver_Source
    {
        public int ItemPrice{ get; set; }
        public int Discount { get; set; }

    }
    public class CustomValueResolver_Destination
    {
        public string Total{ get; set; }=null!;
    }
}
