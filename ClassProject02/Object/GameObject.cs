using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject02.Object
{
    public enum ObjectType {
        Invst, Item, Door, Exit
    }
    public abstract class GameObject
    {
        public string name;
        public ObjectType type;
        public string InvstText;
        public string confirmText;
        public Vector2 position;

        public abstract void Interact();
        public bool ConfirmInteract() {
            bool returnValue = false, isValidInput;
            do {
                ConsoleKey userInput = Console.ReadKey(true).Key;
                if (userInput == ConsoleKey.Y)
                {
                    isValidInput = true;
                    returnValue = true;
                }
                else if (userInput == ConsoleKey.N)
                {
                    isValidInput = true;
                    returnValue = false;
                }
                else 
                {
                    isValidInput = false;
                }
            } while (!isValidInput);
            return returnValue;
        }
    }
}
