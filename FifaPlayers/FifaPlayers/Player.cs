using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaPlayers
{
    
    internal class Player
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Country { get; set; }

        public Player(string name, string birthdate, double weight, double height,int country)
        {
            Name = name;
            Birthdate = birthdate;
            Weight = weight;
            Height = height;
            Country = country;
        }
        
        
    }
}
