using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class FantasyPetShop
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }
        public string MagicPower { get; set; }

        public FantasyPetShop(string name, string species, int age, decimal price, string magicPower)
        {
            Name = name;
            Species = species;
            Age = age;
            Price = price;
            MagicPower = magicPower;
        } 

        public void describePet()
        { 
            Console.WriteLine($"Your pet, {Name} is a {Species}. {Name} is {Age} years old, and {Name} have a magic power of {MagicPower}! How cool!");
        }
    
        public decimal discountPrice(int percent)
        {
            decimal discount = Price * (percent / 100m);
            return (Price - discount);
        }
       
        public void performMagic()
        { 
            if (MagicPower == "Fire breath")
            {
                Console.WriteLine($"{Name} breathes fire and lights a candle! Neat!");
            }
            else if (MagicPower == "Flying")
            {
                Console.WriteLine($"{Name} flies away and does a backflip in the air! Wow!");
            }
        }

    }
}
