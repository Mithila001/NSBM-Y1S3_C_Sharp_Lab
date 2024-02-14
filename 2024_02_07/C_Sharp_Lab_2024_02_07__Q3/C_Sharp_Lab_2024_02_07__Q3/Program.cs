using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_2024_02_07__Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker();

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter the day {i+1} temperature: ");
                string userInput = Console.ReadLine();

                int number;
                if (int.TryParse(userInput, out number))
                {
                    tracker.SetTemperature(number, i);
                }
                else
                {
                    Console.WriteLine("Invalude input!!");
                }
                
            }

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i+1} Temperature is {tracker.GetTemperature(i)} C");
            }
            Console.ReadKey();
        }
    }

    public class TemperatureTracker
    {
        private int[] temperatures = new int[7];
        

        public void SetTemperature(int temperature, int day)
        {
            temperatures[day] = temperature;
        }

        public int GetTemperature(int day)
        {
            return temperatures[day];
        }
    }
}
