using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public static class PongUtil
    {
        public static char[] chooseControls()
        {
            char[] keys = new char[4];
            bool validKey = false;

            //Left Player
            //Left up
            char leftUpKey = chooseKey(0);
            while (!confirmOption())
            {
                Console.WriteLine("Left Player\nPlease choose an up key:");
                leftUpKey = (char)Console.ReadKey().Key;
                Console.WriteLine("");
            }
            keys[0] = leftUpKey;

            //Left down
            char leftDownKey = chooseKey(1);
            while (!validKey)
            {
                while (!confirmOption())
                {
                    Console.WriteLine("Left Player\nPlease choose a down key:");
                    leftDownKey = (char)Console.ReadKey().Key;
                    Console.WriteLine("");
                }
                keys[1] = leftDownKey;
                validKey = checkKeyMappings(leftDownKey, "leftDownKey", keys);
                if (!validKey)
                {
                    Console.WriteLine("Can't match a previously chosen key!");
                    leftDownKey = chooseKey(1);
                    validKey = checkKeyMappings(leftDownKey, "leftDownKey", keys);
                }
            }
            keys[1] = leftDownKey;

            //Right Player
            //Right Up
            char rightUpKey = chooseKey(2);
            validKey = false;
            while (!validKey)
            {
                while (!confirmOption())
                {
                    Console.WriteLine("Right Player\nPlease choose an up key:");
                    rightUpKey = (char)Console.ReadKey().Key;
                    Console.WriteLine("");
                }
                keys[2] = rightUpKey;
                validKey = checkKeyMappings(rightUpKey, "rightUpKey", keys);
                if (!validKey)
                {
                    Console.WriteLine("Can't match a previously chosen key!");
                    rightUpKey = chooseKey(2);
                    validKey = checkKeyMappings(rightUpKey, "rightUpKey", keys);
                }
            }
            keys[2] = rightUpKey;

            //Right Down
            char rightDownKey = chooseKey(3);
            validKey = false;
            while (!validKey)
            {
                while (!confirmOption())
                {
                    Console.WriteLine("Right Player\nPlease choose a down key:");
                    rightDownKey = (char)Console.ReadKey().Key;
                    Console.WriteLine("");
                }
                keys[3] = rightDownKey;
                validKey = checkKeyMappings(rightDownKey, "rightDownKey", keys);
                if (!validKey)
                {
                    Console.WriteLine("Can't match a previously chosen key!");
                    rightDownKey = chooseKey(3);
                    validKey = checkKeyMappings(rightDownKey, "rightDownKey", keys);
                }
            }
            keys[3] = rightDownKey;
            return keys;
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

        public static bool checkKeyMappings(char keyCharacter, string whichKey, char[] keys)
        {
            if (whichKey.Equals("leftDownKey"))
            {
                if (keys[1] == keys[0])
                {
                    return false;
                }
            } else if (whichKey.Equals("rightUpKey"))
            {
                if (keys[2] == keys[0]|| keys[2] == keys[1])
                {
                    return false;
                }

            } else if (whichKey.Equals("rightDownKey"))
            {
                if (keys[3] == keys[0] || keys[3] == keys[1] || keys[3] == keys[2])
                {
                    return false;
                }
            } else { return true; }
            return true;
        }

        public static char chooseKey(int keyNumber)
        {
            switch (keyNumber)
            {
                case 0:
                    Console.WriteLine("Left Player\nPlease choose an up key:");
                    char leftUpKey = (char)Console.ReadKey().Key;
                    Console.WriteLine("");
                    return leftUpKey;
                case 1:
                    Console.WriteLine("Left Player\nPlease choose a down key:");
                    char leftDownKey = (char)Console.ReadKey().Key;
                    Console.WriteLine("");
                    return leftDownKey;
                case 2:
                    Console.WriteLine("Right Player\nPlease choose an up key:");
                    char rightUpKey = (char)Console.ReadKey().Key;
                    Console.WriteLine("");
                    return rightUpKey;
                case 3:
                    Console.WriteLine("Right Player\nPlease choose a down key:");
                    char rightDownKey = (char)Console.ReadKey().Key;
                    Console.WriteLine("");
                    return rightDownKey;
                default: 
                    Console.WriteLine("Invalid option!");
                    return '0';
                    break;
            }
        }
    }
}
