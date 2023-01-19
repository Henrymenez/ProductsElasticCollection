using System;
using ElasticCollection.implementation;

namespace ElasticCollection.Ui
{
    public class Application
    {

        public void Run()
        {
            ElasticCollectionApp.DynamicDisplay();

            /* start: Console.WriteLine("Weclome to our store \n 1) To display all the products \n" +
                   " 2) To select Order Yourself \n 3) To leave the application");
                 string choiceOne = Console.ReadLine();
                 bool isAlive = true;*/
            /*  while (isAlive)
              {
                  switch (choiceOne)
                  {
                      case "1":

                          isAlive = false;
                          break;
                      case "2":
                          Console.WriteLine("Pickd 2");
                          break;
                      case "3":
                          Console.WriteLine("GoodBye");
                          isAlive = false;
                          break;
                      default:
                          goto start;

                  }
              }*/
        }
    }
}
