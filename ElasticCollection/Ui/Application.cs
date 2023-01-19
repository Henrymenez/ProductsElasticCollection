using System;
using ElasticCollection.implementation;

namespace ElasticCollection.Ui
{
    public class Application
    {
        public string DisplayOrder()
        {
            Console.Clear();
            Console.WriteLine("Enter the option you would like to see(use space to seperate for multi options)" +
                " \n" + "1) Id \n" + "2) Name \n" + "3) Quantity \n" + "4) Price \n" + "5) Category \n" + "6) OrderCount" + "  ");
       return Console.ReadLine();
        }

        public void Run()
        {

            Console.WriteLine("Weclome to our store ");
        start: Console.WriteLine("\n 1) To display all the products \n" +
              " 2) To select Display Order Yourself \n 3) To leave the application");
            string choiceOne = Console.ReadLine();
     
                  switch (choiceOne)
                  {
                      case "1":
                    Console.Clear();
                    ElasticCollectionApp.ShowAll();
                    goto start;
                case "2":
                    Console.Clear();
                    
                    ElasticCollectionApp.DynamicDisplay(DisplayOrder());
                  
                    goto start;
                case "3":
                          Console.WriteLine("GoodBye");
                          break;
                      default:
                          goto start;
                  }
        }
    }
}
