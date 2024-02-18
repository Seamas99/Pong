using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public static class PongUtil
    {
        public static void chooseControls()
        {
            Console.WriteLine("Left Player\nPlease choose an up key:");
            char leftUpKey = (char)Console.ReadKey().Key;
            Console.WriteLine("");
            while (!confirmOption())
            {
                Console.WriteLine("Left Player\nPlease choose an up key:");
                leftUpKey = (char)Console.ReadKey().Key;
                Console.WriteLine("");
            }
            Console.WriteLine("Left Player\nPlease choose a down key:");
            char leftDownKey = (char)Console.ReadKey().Key;
            Console.WriteLine("");
            while (!confirmOption())
            {
                Console.WriteLine("Left Player\nPlease choose a down key:");
                leftDownKey = (char)Console.ReadKey().Key;
                Console.WriteLine("");
            }


            Console.WriteLine("Right Player\nPlease choose an up key:");
            char rightUpKey = (char)Console.ReadKey().Key;
            Console.WriteLine("");
            while (!confirmOption())
            {
                Console.WriteLine("Right Player\nPlease choose an up key:");
                rightUpKey = (char)Console.ReadKey().Key;
                Console.WriteLine("");
            }
            Console.WriteLine("Right Player\nPlease choose a down key:");
            char rightDownKey = (char)Console.ReadKey().Key;
            Console.WriteLine("");
            while (!confirmOption())
            {
                Console.WriteLine("Right Player\nPlease choose a down key:");
                rightDownKey = (char)Console.ReadKey().Key;
                Console.WriteLine("");
            }
        }

        public static bool confirmOption()
        {
            Console.WriteLine("Please confirm y/n");
            confirm:;
            string option = Console.ReadLine();

            if (option != null && option.Length > 0)
            {
                if (option.Equals("y"))
                {
                    return true;
                }
                else if (option.Equals("n"))
                {
                    return false;
                }
                else
                {
                    while (option != "y" || option != "n")
                    {
                        Console.WriteLine("Invalid option! Please enter y/n");
                        option = Console.ReadLine();
                        if (option.Equals("y"))
                        {
                            return true;
                        }
                        else if (option.Equals("n"))
                        {
                            return false;
                        }
                    }
                }
            }
            else 
            {
                Console.WriteLine("Invalid option! Please enter y/n");
                goto confirm;
            }
            return false;
        }

        public static bool checkKeyMappings(char keyCharacter, string whichKey)
        {
            if (whichKey.Equals("leftUpKey"))
            {

            } else if (whichKey.Equals("leftDownKey"))
            {

            } else if (whichKey.Equals("rightUpKey"))
            {

            } else if (whichKey.Equals("rightDownKey"))
            {

            }
            return false;
        }
    }
}
