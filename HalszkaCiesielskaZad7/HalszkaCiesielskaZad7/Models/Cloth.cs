namespace HalszkaCiesielskaZad7.Models
{
    /// <summary>
    /// Cloth class
    /// </summary>
    public class Cloth
    {
        // cloth id
        public int Id { get; set; }
        // cloth size
        public int Size { get; set; }
        // fabric that cloth is made of
        public string Fabric { get; set; }
        // cloth category (dress, jacket, etc.) 
        public string Category { get; set; }
    }
}
