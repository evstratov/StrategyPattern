using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyClient c = new StrategyClient();
            string arr = "12363";
            c.SetStrategy(new BubbleSort());
            c.ExecuteStrategy(arr);

            c.SetStrategy(new InsertingSort());
            c.ExecuteStrategy(arr);

            c.SetStrategy(new SelectionSort());
            c.ExecuteStrategy(arr);

            Console.ReadKey();
        }
    }
    class StrategyClient
    {
        ISorting strategy;
        public void SetStrategy(ISorting s)
        {
            strategy = s;
        }
        public void ExecuteStrategy(string arr)
        {
            strategy.Sort(arr);
        }
    }
    interface ISorting
    {
        void Sort(string arr);
    }
    class BubbleSort : ISorting
    {
        public void Sort(string arr)
        {
            Console.WriteLine("Bubble sort: " + arr);
        }
    }
    class SelectionSort : ISorting
    {
        public void Sort(string arr)
        {
            Console.WriteLine("Selection sort: " + arr);
        }
    }
    class InsertingSort : ISorting
    {
        public void Sort(string arr)
        {
            Console.WriteLine("Inserting sort: " + arr);
        }
    }
}
