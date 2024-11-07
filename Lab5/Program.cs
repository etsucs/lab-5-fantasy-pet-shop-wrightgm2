namespace Lab5
{
    public class Program
    {
        static void Main(string[] args)
        {
            PetShop shop = new PetShop();

            Console.WriteLine("What is the name of your pet? ");
            string name = Console.ReadLine();

            Console.WriteLine("What is the species of your pet? ");
            string species = Console.ReadLine();

            Console.WriteLine("What is the age of your pet? ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the price of your pet? ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What is the magic power of your pet? Please enter \"Fire breath\" or \"Flying\": ");
            string magicPower = Console.ReadLine();

            while (magicPower != "Fire breath" && magicPower != "Flying")
            {
                Console.WriteLine($"{name} doesn't have a valid magic power! Please enter \"Fire breath\" or \"Flying\": ");
                magicPower = Console.ReadLine();
            }

            FantasyPetShop pet = new FantasyPetShop(name, species, age, price, magicPower);

            FantasyPetShop pet2 = new FantasyPetShop("Shiloh", "Dog", 13, 600, "Flying");

            FantasyPetShop pet3 = new FantasyPetShop("Pepper", "Dog", 6, 65, "Fire breath");

            Console.WriteLine("\n");

            shop.addPet(pet);
            shop.addPet(pet2);
            shop.addPet(pet3);

            shop.listPets();

            Console.WriteLine("\nDiscounted Prices:");
            Console.WriteLine($"{pet.Name}'s discounted price (25% off): ${pet.discountPrice(25)}.");
            Console.WriteLine($"{pet2.Name}'s discounted price (50% off): ${pet2.discountPrice(50)}.");

            Console.WriteLine("\nPerforming magic:");

            pet.performMagic();
            pet2.performMagic();
            pet3.performMagic();
        }
    }
}
