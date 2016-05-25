using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.SteamApiServices;
using ConsoleApplication2.ResponceModels;

namespace ConsoleApplication2.Menu
{
    public class MenuService
    {
        public SteamAppsService steam;
        

        public MenuService()
        {
            steam = new SteamAppsService();
            steam.getTitles();
            steam.mapList();

            string pressedKey=null;

            
            
            do
            {
                Console.Clear();
                Console.Title = "AppDetailsProvider";
                switch (pressedKey)
                {


                    case "1":
                        MenuLogic.Wyszukiwanie("Wpisz nazwę","",steam.appList);
                        break;
                    case "2":
                        MenuLogic.Numer("Podaj numer aplikacji ,której detale mają zostać pobrane");
                        break;
                    case "3":
                        break;
                    default:
                        MenuLogic.MenuGlowne();
                        break;
                }
                
                pressedKey = Console.ReadKey(true).KeyChar.ToString().ToLower();


            } while (pressedKey != "k");
        }
    }
    public static class MenuLogic
    {
        private static string[] menu1 = new string[] { "Poka listę dostępnych apek", "Poka detale konkretnej apki", "Pobierz detale dla wszystkich apek" };
        
        private static void Naglowek(string menuName)
        {
            Console.WriteLine(menuName);
            Console.WriteLine("------------------------------------------");
        }
        public static void MenuGlowne(string menuName, string[] menuOpts)
        {
            Naglowek(menuName);

            for (int i = 0; i < menuOpts.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, menuOpts[i]);
            }

        }
        public static void MenuGlowne()
        {
            MenuLogic.MenuGlowne("Menu główne", menu1);
        }
        public static void Wyszukiwanie(string menuName, string napis, List<AppDetailsContainer> list)
        {
            Console.Clear();
            Naglowek(menuName);
            Console.Write(napis);
            
            foreach (AppDetailsContainer app in list)
            {
                if (app.Data.Name.Contains(napis)&&napis.Length>=2)
                {
                    Console.WriteLine(app.Data.SteamAppid + "  -  " + app.Data.Name);
                }
            }
            var key = Console.ReadKey(true).Key;
            if (key != ConsoleKey.Escape)
            {
                Wyszukiwanie(menuName, napis + key,list);
            }
            MenuLogic.MenuGlowne();
        }
        public static void Numer(string menuName)
        {
            Naglowek(menuName);
            var numer = Console.ReadLine();
        }
    }
    
}
