using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        private static ProblemSolver ps = new ProblemSolver();
        static void Main(string[] args)
        {
            Console.WriteLine("What problem would you like to solve?");

            int problemNumber;
            string cmd = Console.ReadLine();
            bool isInt = int.TryParse(cmd, out problemNumber);

            if (isInt)
                ps.SolveProblem(problemNumber);
            else
                Console.WriteLine("Noob that is no number!");

            Console.Read();
        }
    }
}
