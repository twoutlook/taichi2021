using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Combo
    {
        public int ID { get; set; }
        public int Seq { get; set; }  //20 
        public string Name { get; set; } //02 ½ð„‚“víÔ
        public string Grp { get; set; } //µÚÒ»„Ý
        public ICollection<Move> Moves { get; set; }
    }
}