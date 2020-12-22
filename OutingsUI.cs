using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoOutings_Console
{
    class OutingsUI
    {
        public void Run()
        {
            Menu();
            MenuTwo();

        }
        private void Menu()
        {
            Console.WriteLine("Welcome to Komodo Outings Planner! Please enter an option number(1, 2, 3, or 4)\n" +
                "1. List All Outings\n" +
                "2. Add Outings\n" +
                "3. See combined cost of all Outings\n" +
                "4. See outing costs by type\n" +
                "5. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //List All Outings--Read
                    break;

                case "2":
                    //Add Outings--Create
                    break;

                case "3":
                    //List Combined Costs--Another Read, but with some math: Decide if you want to just give the total cost with all outings listed, or put it in a table 
                    //with each one column for the outing, the next for the cost, the bottom of which will be "Total" at the bottom of the Outings Column, and the total cost 
                    //at the bottom of the Cost Column
                    break;

                case "4":
                    //See the cost of the outing by the type of outing: Create another input asking the user to enter the outing, and return 
                    //"The {outingType} outing cost is {outingAmount}."
                    break;

                case "5":
                    //Exit the program
                    break;

                default:
                    //Catch any invalid input here
                    break;

            }

        }
        private void MenuTwo()
        {
            //Additional menu to be activated upon case 4
            Console.WriteLine("Welcome to the Komodo Outing -- Outing Costs menu! Please enter the name of the outing to see it's costs.\n" +
                "If you need to see a list please type 'list' and press the enter key.");

            //Display the List All Outings again for reference:

            //Read the user's input
            string input = Console.ReadLine();

            //Hmmm, another switch here, but could I use inheritance here?

            switch (input)
            {
                case "list":
                    //Display the list

                    //Give another user prompt after the list:
                    Console.WriteLine("Please enter the name of the outing to see it's costs.");
                    break;

                case "Golf":
                    //Display Golf and it's cost
                    break;

                case "Bowling":
                    //Display Bowling and it's cost
                    break;

                case "Amusement Park":
                    //Display Amusement Park and it's cost
                    break;

                case "Concert":
                    //Display Concert and it's cost
                    break;

                //I will need a case here to call any outing that the user created, Hmm...

                case "UserCreatedOuting":

                    break;

                default:
                    //Catch any invalid input here
                    break;



            }

        }
    }
}
