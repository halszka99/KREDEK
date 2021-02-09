namespace HalszkaCiesielskaZad7.Models
{
    /// <summary>
    /// Shoes class
    /// </summary>
    public class Shoes
    {
        // id of shoes
        public int Id { get; set; }
        // shoes size
        public int Size { get; set; }
        // length of insole in shoes
        public float InsoleLength { get; set; }
        // shoes type (heels, sandals, etc. )
        public string Type { get; set; }
    }
}
