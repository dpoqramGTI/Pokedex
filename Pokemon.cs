using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Pokemon
    {
        public string name { get; set; }
        public int level { get; set; }
        public string type { get; set; }
        public int weight { get; set; }
        public string sex { get; set; }
        public float price { get; set; }
        public int ammount { get; set; }

        public Pokemon(string name, int level, string type, int weight, string sex, float price, int ammount)
        {
            this.name = name;
            this.level = level;
            this.type = type;
            this.weight = weight;
            this.sex = sex;
            this.price = price;
            this.ammount = ammount;
        }

    }
}
