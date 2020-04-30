using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset data = new Dataset("Luka Vukadin.csv");
            Analyzer3rdParty analyze = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyze);
            Console.WriteLine(adapter.CalculateAveragePerColumn(data));

            double[] res = adapter.CalculateAveragePerColumn(data);

            foreach (double r in res)
            {
                Console.WriteLine(r);
            }
        }
    }
}
