﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class ProblemSolver
    {
        public void SolveProblem(int problemNumber)
        {
            switch (problemNumber)
            {
                case 1:
                    problem1();
                    break;
                case 2:
                    problem2();
                    break;
                default:
                    Console.WriteLine("Problem does not exists or is not solved");
                    break;                    
            }               
        }

        // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        // Find the sum of all the multiples of 3 or 5 below 1000.
        private void problem1()
        {
            List<int> multiples = new List<int>();

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    multiples.Add(i);
            }

            //Solve the problem
            Console.WriteLine("Solution: " + multiples.Sum());
        }

        // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
        // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

        private void problem2()
        {
            List<int> evenTerms = new List<int>();
            evenTerms.Add(2);

            int prev = 1;
            int current = 2;
            int temp;

            while (current < 4000000)
            {
                if ((prev + current) % 2 == 0)
                    evenTerms.Add(prev + current);

                temp = current;
                current = prev + current;
                prev = temp;
            }

            Console.WriteLine("Solution: " + evenTerms.Sum());

        }
    }
}