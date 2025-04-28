using d10.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d10.programs
{
    class AddPerson
    {
        public static bool isActive { get; set; }

        public AddPerson()
        {
            DrawMenu _menu = new DrawMenu(1, 1, 80, 25, "D10 Add Person");
            isActive = true;
            do
            {
                string? fullname, email, phone, entry, choice;
                Console.Clear();
                DrawMenu.MakeMenu();
                Console.CursorLeft = 3;
                Console.Write("Enter fullname: ");
                fullname = Console.ReadLine();
                Console.CursorLeft = 3;
                Console.Write("Enter Email: ");
                email = Console.ReadLine();
                Console.CursorLeft = 3;
                Console.Write("Enter Phone: ");
                phone = Console.ReadLine();

                entry = $"{phone} {fullname} {email}";

                Program.entries.Add(entry);
                Console.CursorLeft = 3;
                Console.Write("Do you want to create another person (Y)es or (N)o: ");
                choice = Console.ReadLine();
                if(choice == "Y")
                {
                    isActive = true;
                } else
                {
                    isActive = false;
                }
            } while (isActive);
        }
    }
}
