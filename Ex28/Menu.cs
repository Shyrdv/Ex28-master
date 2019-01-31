using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class Menu
    {
        DatabaseController db = new DatabaseController();
        public void Run()
        {
            bool runWhileTrue = true;
            while (runWhileTrue)
            {
                Console.Clear();
                Console.WriteLine("1. Insert a pet");
                Console.WriteLine("2. Show all pets");
                int menuInput = int.Parse(Console.ReadLine());
                switch (menuInput)
                {
                    case 0:
                        runWhileTrue = false;
                        break;
                    case 1:
                        Console.WriteLine("Insert a Pet");
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Type: ");
                        string type = Console.ReadLine();
                        Console.Write("Breed: ");
                        string breed = Console.ReadLine();
                        Console.Write("DOB: ");
                        string dob = Console.ReadLine();
                        Console.Write("Weight: ");
                        string weight = Console.ReadLine();
                        db.InsertRow(name, type, breed, dob, weight);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("==== Show all Pets ====");
                        db.ShowPets();
                        Console.Clear();
                        break;
                    default:

                        break;
                }
            }

        }
    }
}
