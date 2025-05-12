using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series_of_numbers
{
    internal class Program
    {
        static bool running = true;
        static List<int> series = new List<int>();
        //static Dictionary<string, Action> functions = new Dictionary<string, Action>
        //    {
        //        { "a", setSeriesInput },
        //        { "b", showSeriesInOrder },
        //        { "c", showSeriesInReverse },
        //        { "d", showSeriesSorted },
        //        { "e", showMax },
        //        { "f", showMin },
        //        { "g", showAverage },
        //        { "h", showLen },
        //        { "i", showSum },
        //        { "j", exit }
        //    };


        static void printList(List<int> list)
        {
            Console.Write("!*  ");
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("  *!");
        }
        
        static void insertArgs(string[] args)
        {
            foreach (string arg in args)
            {
                if (int.TryParse(arg, out int number))
                {
                    series.Add(number);
                }
                else
                {
                    Console.WriteLine($"Invalid input: {arg} is not a number.");
                }
            }
        }

        static void setSeriesInput()
        {
            series.Clear();
            Console.WriteLine("Enter at least 3 positive numbers one after another (or type 'exit' to finish):");
            string numStr = "";
            int counter = 0;
            bool run = true;
            while (run)
            {
                numStr = Console.ReadLine();
                if (int.TryParse(numStr, out int number))
                {
                    if (number > 0)
                    {
                        series.Add(number);
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive number.");
                    }
                }
                else
                {
                    if (numStr == "exit")
                    {
                        if (counter < 3)
                        {
                            Console.WriteLine("You must enter at least 3 numbers.");
                        }
                        else
                        {
                            run = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input: {numStr} is not a number.");
                    }
                }
            }
            Console.WriteLine("you have set the list succesffuly");
        }

        static void showSeriesInOrder()
        {
            printList(series);
        }

        static void showSeriesInReverse()
        {
            List<int> reversedSeries = new List<int>();
            int len = series.Count;
            for (int i = len - 1; i >= 0; i--)
            {
                reversedSeries.Add(series[i]);
            }
            printList(reversedSeries);
        }

        static void showSeriesSorted()
        {
            List<int> copyList = new List<int>();
            List<int> sortedList = new List<int>();
            for (int i = 0; i < series.Count; i++)
            {
                copyList.Add(series[i]);
            }

            for (int i = 0; i < series.Count; i++)
            {
                int min = copyList[0];
                for (int j = 0; j < copyList.Count; j++)
                {
                    if (copyList[j] < min)
                    {
                        min = copyList[j];
                    }
                }
                sortedList.Add(min);
                copyList.Remove(min);
            }
            printList(sortedList);
        }
        
        static void showMax()
        {
            int max = series[0];
            for (int i = 1; i < series.Count; i++)
            {
                if (series[i] > max)
                {
                    max = series[i];
                }
            }
            Console.WriteLine($"max: {max}");
        }

        static void showMin()
        {
            int min = series[0];
            for (int i = 1; i < series.Count; i++)
            {
                if (series[i] < min)
                {
                    min = series[i];
                }
            }
            Console.WriteLine($"min: {min}");
        }

        static void showAverage()
        {
            double sum = 0;
            for (int i = 0; i < series.Count; i++)
            {
                sum += series[i];
            }
            double average = sum / series.Count;
            Console.WriteLine($"average: {average}");
        }

        static void showLen()
        {
            Console.WriteLine($"there are {series.Count} eivarim");
        }

        static void showSum()
        {
            double sum = 0;
            for (int i = 0; i < series.Count; i++)
            {
                sum += series[i];
            }
            Console.WriteLine($"sum: {sum}");
        }

        static void exit()
        {
            running = false;
        }

        static void menu()
        {
            Console.WriteLine("\n\na. input a new series (replace the prives)\n" +
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

            switch (choice)
            {
                case "a":
                    setSeriesInput();
                    break;
                case "b":
                    showSeriesInOrder();
                    break;
                case "c":
                    showSeriesInReverse();
                    break;
                case "d":
                    showSeriesSorted();
                    break;
                case "e":
                    showMax();
                    break;
                case "f":
                    showMin();
                    break;
                case "g":
                    showAverage();
                    break;
                case "h":
                    showLen();
                    break;
                case "i":
                    showSum();
                    break;
                case "j":
                    exit();
                    break;
                default:
                    Console.WriteLine("invalid input\n");
                    break;
            }
        }



        static void Main(string[] args)
        {
            if (args.Length >= 3)
            {
                insertArgs(args);
            }
            else
            {
                setSeriesInput();
            }

            
            while (running)
            {
                menu();
            }


        }
    }
}
