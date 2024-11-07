using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	public class PetShop
	{
		private List<FantasyPetShop> pets;

		public PetShop()
		{
			pets = new List<FantasyPetShop>();
		}

		public void addPet(FantasyPetShop pet)
		{
			pets.Add(pet);
			Console.WriteLine($"{pet.Name} has been added to the shop!");
		}

		public void listPets()
		{
			Console.WriteLine("\nPets in the shop: ");
			
			foreach (var pet in pets)
			{
				Console.WriteLine(pet.Name);
				pet.describePet();
			}
		}
	}
}