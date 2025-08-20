

namespace Shared
{
    public class MobileModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public Data data { get; set; } = new();
    }

    public class Data
    {
        public string Generation { get; set; } = string.Empty;
     
        public string Capacity { get; set; } = string.Empty;
        public string capacityGB { get; set; } = string.Empty;
        public string StrapColour { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public int year { get; set; }
        public decimal price { get; set; } 
        public string Screensize { get; set; } = string.Empty;



    }
}
