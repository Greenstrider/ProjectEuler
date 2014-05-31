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
                case 3:
                    problem3();
                    break;
                case 4:
                    problem4();
                    break;
                case 5:
                    problem5();
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
        
        // The prime factors of 13195 are 5, 7, 13 and 29.
        // What is the largest prime factor of the number 600851475143 ?
        private void problem3()
        {
            Int64 num = 600851475143;

            for (Int64 i = 2; i < num; i++)
            {
                if (isPrime(i))
                {
                    while (num % i == 0)
                    {
                        num = num / i;
                    }

                }
            }
            Console.WriteLine("Solution: " + num); 
        }

        private bool isPrime(Int64 num)
        {
            for (Int64 i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        // Find the largest palindrome made from the product of two 3-digit numbers.

        private void problem4()
        {
            List<int> palindrom = new List<int>();
            int val;
            char[] arr;

            for (int i = 999; i > 0; i--)
            {   
                for (int j = 999; j > 0; j--)
                {
                    val = i * j;
                    arr = val.ToString().ToCharArray();
                    Array.Reverse(arr);

                    if (val == int.Parse(new string(arr)))
                        palindrom.Add(val);
                }
            }

            Console.WriteLine("Solution: " + palindrom.Max());
        }

        // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

        private void problem5()
        {
            bool valueFound = false;
            int val = 20;
            bool isSafe = false;

            while(!valueFound)
            {
                val++;
                isSafe = true;

                for (int i = 2; i <= 20; i++)
                {
                    if (val % i != 0)
                    {
                        isSafe = false;
                        valueFound = false;
                        break;
                    }
                }

                if(isSafe == true)
                    valueFound = true;
            }

            Console.WriteLine("Solution: " + val);
        }
    }
}
