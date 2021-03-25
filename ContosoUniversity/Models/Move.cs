namespace ContosoUniversity.Models
{


    public class Move
    {
        public int ID { get; set; }
        public int ComboID { get; set; }
        public int Seq { get; set; }
        public string  Text { get; set; }
        public Combo Combo { get; set; }
    }
}