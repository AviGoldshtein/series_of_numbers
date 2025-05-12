using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series_of_numbers
{
    internal class Program
    {
        static List<int> series = new List<int>();
        static Dictionary<string, Action> functions = new Dictionary<string, Action>
            {
                { "a", setSeriesInput },
                { "b", showSeriesInOrder },
                { "c", showSeriesInReverse },
                { "d", showSeriesSorted },
                { "e", showMax },
                { "f", showMin },
                { "g", showAverage },
                { "h", showLen },
                { "i", showSum },
                { "j", exit }
            };


        static void insertArgs(string[] args)
        {
            
        }

        static void setSeriesInput()
        {
            series.Clear();
        }

        static void showSeriesInOrder()
        {
            Console.WriteLine("Series in order:");
            foreach (int number in series)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void showSeriesInReverse()
        {

        }

        static void showSeriesSorted()
        {

        }
        
        static void showMax()
        {

        }

        static void showMin()
        {

        }

        static void showAverage()
        {

        }

        static void showLen()
        {

        }

        static void showSum()
        {

        }

        static void exit()
        {

        }



        //static void set_function(string choice)
        //{
        //    if (functions.ContainsKey(choice))
        //    {
        //        functions[choice].Invoke();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid choice. Please try again.");
        //    }
        //}



        static void menu()
        {
            Console.WriteLine("a. input a new series (replace the prives)\n" +
                "b. Display the series in the order it was entered.\n" +
                "c. Display the series in the reversed order it was entered.\n" +
                "d. Display the series in sorted order (from low to high).\n" +
                "e. Display the Max value of the series.\n" +
                "f. Display the Min value of the series.\n" +
                "g. Display the Average of the series.\n" +
                "h. Display the Number of elements in the series.\n" +
                "i. Display the Sum of the series.\n" +
                "j. Exit.");
            string choice = Console.ReadLine().ToLower();
        }



        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                insertArgs(args);
            }
            else
            {
                setSeriesInput();
            }

            bool running = true;
            while (running)
            {
                menu();
            }
            
        }
    }
}
