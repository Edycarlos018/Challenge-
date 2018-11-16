using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Challenge_1
{
    public class ProgramUI
    {
        private MenuContentRepository menuContentRepo = new MenuContentRepository();
        private List<MenuContent> menuContentList;

        MenuContent newContent = new MenuContent();

        public object ItemNumber { get; private set; }

        public void Run()
        {
            MenuContent();
            menuContentList = menuContentRepo.GetMenuContentList();
            RunMenu();
        }

        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)

            {

                // Console.Clear();
                Console.WriteLine("Welcome to Komodo Cafe Manager.\n" +
                    "How can Manager controler help\n" +
                    ".1 See Menu List.\n" +
                    ".2 Add Item\n" +
                    ".3 Remove Item\n" +
                    ".4 Exit");


                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        SeeList();
                        break;
                    case 2:
                        AddMenuItem();
                        break;
                    case 3:
                        RemoveMenuItem();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Thank you");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.ReadLine();
                        break;
                }
            }
        }

        public void MenuContent()
        {
            MenuContent kingBurger = new MenuContent(1, "Burger dog", "The king of burgers", "bun, tomato, onion, cheese, ground-beef", 5);
            MenuContent hotDog = new MenuContent(2, "Express", "Hotdog", "bun, hotdog, onion, mustard", 4);
            MenuContent soup = new MenuContent(3, "Red Sea", "Tomato soup", "Tomato, water, chicken base, salt", 4);
            menuContentRepo.AddMenuContentToList(kingBurger);
            menuContentRepo.AddMenuContentToList(hotDog);
            menuContentRepo.AddMenuContentToList(soup);

            Console.Clear();

        }
        public void SeeList()
        {

            foreach (MenuContent content in menuContentRepo.GetMenuContentList())
            {
                Console.WriteLine($"Item Name:\n" +
                    $"\n{content.ItemNumber} - {content.MenuName} \n" +
                    $"{content.MenuDescription}\n " +
                    $"Ingredients:\n " +
                    $"{content.MenuIngredients}\n " +
                    $"Item Price is ${content.MenuPrice}\n");
            }
            Console.WriteLine(menuContentList.Count);
        }
        public void AddMenuItem()
        {
            Console.WriteLine("\nItem #");
            newContent.ItemNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\nName:");
            newContent.MenuName = Console.ReadLine();
            Console.WriteLine("\nDescription:");
            newContent.MenuDescription = Console.ReadLine();
            Console.WriteLine("\nIngredients:");
            newContent.MenuIngredients = Console.ReadLine();
            Console.WriteLine("\nPrice:");
            newContent.MenuPrice = int.Parse(Console.ReadLine());

            menuContentRepo.AddMenuContentToList(newContent);



            foreach (MenuContent content in menuContentRepo.GetMenuContentList())
            {
                Console.WriteLine($"Item Name:\n" +
                    $"\n{content.ItemNumber} - {content.MenuName} \n" +
                    $"{content.MenuDescription}" +
                    $"Ingredients:\n" +
                    $"{content.MenuIngredients}\n" +
                    $"Item Price is ${content.MenuPrice}\n");
            }

            Console.ReadLine();
        }
        public void RemoveMenuItem()
        {
            Console.WriteLine("What item you want to remove?");
            foreach (MenuContent content in menuContentList)
            {
                Console.WriteLine(content.MenuName);
            }
            Console.WriteLine("Type de name");
            var removecontent = Console.ReadLine();

            foreach (MenuContent content in menuContentList)
            {
                if (removecontent == content.MenuName)
                {
                    menuContentRepo.RemoveMenuContentFromList(content);
                    break;
                }
            }
        }
    }
}