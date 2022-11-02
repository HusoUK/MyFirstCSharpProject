using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShoppingList
{
    internal class MyList
    {
        public MyList()
        {
        }

        public Dictionary<string, string> newList = new Dictionary<string, string>();
        public char repeat = 'Y';

        public void AnotherItemCheck()
        {
            switch (repeat)
            {
                case 'Y':
                    AddingItems();
                    break;
                case 'y':
                    AddingItems();
                    break;
                case 'N':
                    DisplayShoppingList();
                    break;
                case 'n':
                    DisplayShoppingList();
                    break;
                default:
                    NotAYorN();
                    break;
            }
        }

        public void AddingItems()
        {
            string item, qnty;
            Console.WriteLine("Please enter the name of the item for your shopping list:");
            item = Console.ReadLine();
            Console.WriteLine("Please enter the quanity:");
            qnty = Console.ReadLine();
            newList.Add(item, qnty);
            Console.WriteLine("Would you like to add another item (Y/N):");
            string repeat1 = Console.ReadLine();
            switch (repeat1.Length)
            {
                case 1:
                    repeat = Char.Parse(repeat1);
                    AnotherItemCheck();
                    break;
                default:
                    NotAYorN();
                    break;
            }
        }


        public void DisplayShoppingList()
        {
            int count = 0;
            Console.WriteLine($"Your list has {newList.Count} item(s), they are as follows:");
            foreach (var shoppingItem in newList)
            {
                count++;
                Console.WriteLine($"{count} - {shoppingItem.Value} x {shoppingItem.Key}");
            }
            Console.WriteLine("Please press any key to exit.");
            Console.ReadLine();
        }

        public void NotAYorN()
        {
            Console.WriteLine("You did not enter Y/N.\nWould you like to add another item (Y/N):");
            string repeat1 = Console.ReadLine();
            switch (repeat1.Length)
            {
                case 1:
                    repeat = Char.Parse(repeat1);
                    AnotherItemCheck();
                    break;
                default:
                    NotAYorN();
                    break;
            }
        }

        public void RemovingItem()
        {
            string removeItem;
            Console.WriteLine("please enter the name of the item you would like to remove:");
            removeItem = Console.ReadLine();
            if (newList.ContainsKey(removeItem))
            {
                newList.Remove(removeItem);

            }
        }
    }
}
