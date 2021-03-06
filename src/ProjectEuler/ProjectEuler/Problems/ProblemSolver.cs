﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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
                case 6:
                    problem6();
                    break;
                case 7:
                    problem7();
                    break;
                case 8:
                    problem8();
                    break;
                case 9:
                    problem9();
                    break;
                case 10:
                    problem10();
                    break;
                case 11:
                    problem11();
                    break;
                case 12:
                    problem12();
                    break;
                case 13:
                    problem13();
                    break;
                case 14:
                    problem14();
                    break;
                case 15:
                    problem15();
                    break;
                case 16:
                    problem16();
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

        // The sum of the squares of the first ten natural numbers is,
        // 12 + 22 + ... + 102 = 385
        // The square of the sum of the first ten natural numbers is,
        // (1 + 2 + ... + 10)2 = 552 = 3025
        // Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

        private void problem6()
        {
            double sumOfSqr = 0;
            double sqrOfSum = 0;
            double val = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSqr += Math.Pow(i, 2);
                sqrOfSum += i;
            }

            sqrOfSum = Math.Pow(sqrOfSum, 2);

            val = sqrOfSum - sumOfSqr;

            Console.WriteLine("Solution: " + val);
        }

        // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        // What is the 10 001st prime number?

        private void problem7()
        {
            int numOfPrimes = 0;
            int val = 1;

            while (numOfPrimes < 10001)
            {
                val++;

                if (isPrime(val))
                    numOfPrimes++;
            }

            Console.WriteLine("Solution: " + val);

        }

        // The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
        //73167176531330624919225119674426574742355349194934
        //96983520312774506326239578318016984801869478851843
        //85861560789112949495459501737958331952853208805511
        //12540698747158523863050715693290963295227443043557
        //66896648950445244523161731856403098711121722383113
        //62229893423380308135336276614282806444486645238749
        //30358907296290491560440772390713810515859307960866
        //70172427121883998797908792274921901699720888093776
        //65727333001053367881220235421809751254540594752243
        //52584907711670556013604839586446706324415722155397
        //53697817977846174064955149290862569321978468622482
        //83972241375657056057490261407972968652414535100474
        //82166370484403199890008895243450658541227588666881
        //16427171479924442928230863465674813919123162824586
        //17866458359124566529476545682848912883142607690042
        //24219022671055626321111109370544217506941658960408
        //07198403850962455444362981230987879927244284909188
        //84580156166097919133875499200524063689912560717606
        //05886116467109405077541002256983155200055935729725
        //71636269561882670428252483600823257530420752963450
        // Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
        
        private void problem8()
        {
            string numSeq = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            double sum;
            List<double> adjacent = new List<double>();

            for (int i = 0; i < numSeq.Length - 13; i++)
            {
                sum = 1;
                foreach (char c in numSeq.Substring(i, 13))
                {
                    sum *= double.Parse(c.ToString());
                }
                adjacent.Add(sum);
            }
            Console.WriteLine("Solution: " + adjacent.Max());
        }

        // A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        // a2 + b2 = c2
        // For example, 32 + 42 = 9 + 16 = 25 = 52.
        // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        // Find the product abc.

        private void problem9()
        {
            int c = 0;
            int product = 0;

            for (int a = 0; a < 1000 / 3; a++)
            {
                for (int b = 0; b < 1000 / 2; b++)
                {
                    c = 1000 - a - b;

                    if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b,2))
                        if (a + b + c == 1000)
                        {
                            product = a * b * c;
                            break;
                        }
                }
            }
            Console.WriteLine("Solution: " + product);
        }

        // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        // Find the sum of all the primes below two million.

        private void problem10()
        {
            bool[] sieve = new bool[2000000];
            List<double> primes = new List<double>();

            for (int i = 2; i < sieve.Length; i++)
                sieve[i] = true;

            for (int i = 2; Math.Pow(i, 2) < sieve.Length; i++)
            {
                for (int j = (int)Math.Pow(i, 2); j < sieve.Length; j += i)
                    sieve[j] = false;
            }

            for (int i = 2; i < sieve.Length; i++)
                if (sieve[i])
                    primes.Add(i);

            Console.WriteLine("Solution: " + primes.Sum());

        }

        // In the 20×20 grid below, four numbers along a diagonal line have been marked in red.
        // 
        // 08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08
        // 49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00
        // 81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65
        // 52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91
        // 22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80
        // 24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50
        // 32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70
        // 67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21
        // 24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72
        // 21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95
        // 78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92
        // 16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57
        // 86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58
        // 19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40
        // 04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66
        // 88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69
        // 04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36
        // 20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16
        // 20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54
        // 01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48
        // The product of these numbers is 26 × 63 × 78 × 14 = 1788696.
        // 
        // What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?

        private void problem11()
        {
            int[,] numSeq = {{8,2,22,97,38,15,0,4,0,75,4,5,7,78,52,12,5,77,91,8}
                            ,{49,49,99,4,17,81,18,57,6,87,17,4,98,43,69,48,4,56,62,0}
                            ,{81,49,31,73,55,79,14,29,93,71,4,67,53,88,3,3,49,13,36,65}
                            ,{52,7,95,23,4,6,11,42,69,24,68,56,1,32,56,71,37,2,36,91}
                            ,{22,31,16,71,51,67,63,89,41,92,36,54,22,4,4,28,66,33,13,8}
                            ,{24,47,32,6,99,3,45,2,44,75,33,53,78,36,84,2,35,17,12,5}
                            ,{32,98,81,28,64,23,67,1,26,38,4,67,59,54,7,66,18,38,64,7}
                            ,{67,26,2,68,2,62,12,2,95,63,94,39,63,8,4,91,66,49,94,21}
                            ,{24,55,58,5,66,73,99,26,97,17,78,78,96,83,14,88,34,89,63,72}
                            ,{21,36,23,9,75,0,76,44,2,45,35,14,0,61,33,97,34,31,33,95}
                            ,{78,17,53,28,22,75,31,67,15,94,3,8,4,62,16,14,9,53,56,92}
                            ,{16,39,5,42,96,35,31,47,55,58,88,24,0,17,54,24,36,29,85,57}
                            ,{86,56,0,48,35,71,89,7,5,44,44,37,44,6,21,58,51,54,17,58}
                            ,{19,8,81,68,5,94,47,69,28,73,92,13,86,52,17,77,4,89,55,4}
                            ,{4,52,8,83,97,35,99,16,7,97,57,32,16,26,26,79,33,27,98,66}
                            ,{88,36,68,87,57,62,2,72,3,46,33,67,46,55,12,32,63,93,53,69}
                            ,{4,42,16,73,38,25,39,11,24,94,72,18,8,46,29,32,4,62,76,36}
                            ,{2,69,36,41,72,3,23,88,34,62,99,69,82,67,59,85,74,4,36,16}
                            ,{2,73,35,29,78,31,9,1,74,31,49,71,48,86,81,16,23,57,5,54}
                            ,{1,7,54,71,83,51,54,69,16,92,33,48,61,43,52,1,89,19,67,48}};
            
            int product = 0;
            int biggestProduct = 0;
            int C_NUM = 20;

            for (int i = 0; i < C_NUM; i++)
            {
                //row
                for (int r = 0; r < C_NUM - 4; r++)
                {
                    product = numSeq[i, r] * numSeq[i, r + 1] * numSeq[i, r + 2] * numSeq[i, r + 3];

                    if (product > biggestProduct)
                        biggestProduct = product;
                }

                //column
                for (int c = 0; c < C_NUM - 4; c++)
                {
                    product = numSeq[c, i] * numSeq[c + 1, i] * numSeq[c + 2, i] * numSeq[c + 3, i];

                    if (product > biggestProduct)
                        biggestProduct = product;
                }

                if (i < C_NUM - 4)
                {
                    //diagonal right
                    for (int dr = 0; dr < C_NUM - 4; dr++)
                    {
                        product = numSeq[i, dr] * numSeq[i + 1, dr + 1] * numSeq[i + 2, dr + 2] * numSeq[i + 3, dr + 3];

                        if (product > biggestProduct)
                            biggestProduct = product;
                    }

                    //diagonal left
                    for (int dl = C_NUM - 1; dl > 4; dl--)
                    {
                        product = numSeq[dl, i] * numSeq[dl - 1, i + 1] * numSeq[dl - 2, i + 2] * numSeq[dl - 3, i + 3];

                        if (product > biggestProduct)
                            biggestProduct = product;
                    }
                }
            }

            Console.WriteLine("Solution: " + biggestProduct);
        }

        // The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:

        // 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

        // Let us list the factors of the first seven triangle numbers:

        // 1: 1
        // 3: 1,3
        // 6: 1,2,3,6
        // 10: 1,2,5,10
        // 15: 1,3,5,15
        // 21: 1,3,7,21
        // 28: 1,2,4,7,14,28
        // We can see that 28 is the first triangle number to have over five divisors.

        // What is the value of the first triangle number to have over five hundred divisors?
        private void problem12()
        {
            int next = 1;
            int i = 2;
            int sqrt = 0;
            int numOfDivisors = 0;

            while (numOfDivisors < 500)
            {
                next += i;
                i++;
                numOfDivisors = 0;
                sqrt = (int) Math.Sqrt(next);

                for (int j = 1; j < sqrt; j++)
                {
                    if (next % j == 0)
                        numOfDivisors += 2;
                }
            }

            Console.WriteLine("Solution: " + next);

        }

        // Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.

        //37107287533902102798797998220837590246510135740250
        //46376937677490009712648124896970078050417018260538
        //74324986199524741059474233309513058123726617309629
        //91942213363574161572522430563301811072406154908250
        //23067588207539346171171980310421047513778063246676
        //89261670696623633820136378418383684178734361726757
        //28112879812849979408065481931592621691275889832738
        //44274228917432520321923589422876796487670272189318
        //47451445736001306439091167216856844588711603153276
        //70386486105843025439939619828917593665686757934951
        //62176457141856560629502157223196586755079324193331
        //64906352462741904929101432445813822663347944758178
        //92575867718337217661963751590579239728245598838407
        //58203565325359399008402633568948830189458628227828
        //80181199384826282014278194139940567587151170094390
        //35398664372827112653829987240784473053190104293586
        //86515506006295864861532075273371959191420517255829
        //71693888707715466499115593487603532921714970056938
        //54370070576826684624621495650076471787294438377604
        //53282654108756828443191190634694037855217779295145
        //36123272525000296071075082563815656710885258350721
        //45876576172410976447339110607218265236877223636045
        //17423706905851860660448207621209813287860733969412
        //81142660418086830619328460811191061556940512689692
        //51934325451728388641918047049293215058642563049483
        //62467221648435076201727918039944693004732956340691
        //15732444386908125794514089057706229429197107928209
        //55037687525678773091862540744969844508330393682126
        //18336384825330154686196124348767681297534375946515
        //80386287592878490201521685554828717201219257766954
        //78182833757993103614740356856449095527097864797581
        //16726320100436897842553539920931837441497806860984
        //48403098129077791799088218795327364475675590848030
        //87086987551392711854517078544161852424320693150332
        //59959406895756536782107074926966537676326235447210
        //69793950679652694742597709739166693763042633987085
        //41052684708299085211399427365734116182760315001271
        //65378607361501080857009149939512557028198746004375
        //35829035317434717326932123578154982629742552737307
        //94953759765105305946966067683156574377167401875275
        //88902802571733229619176668713819931811048770190271
        //25267680276078003013678680992525463401061632866526
        //36270218540497705585629946580636237993140746255962
        //24074486908231174977792365466257246923322810917141
        //91430288197103288597806669760892938638285025333403
        //34413065578016127815921815005561868836468420090470
        //23053081172816430487623791969842487255036638784583
        //11487696932154902810424020138335124462181441773470
        //63783299490636259666498587618221225225512486764533
        //67720186971698544312419572409913959008952310058822
        //95548255300263520781532296796249481641953868218774
        //76085327132285723110424803456124867697064507995236
        //37774242535411291684276865538926205024910326572967
        //23701913275725675285653248258265463092207058596522
        //29798860272258331913126375147341994889534765745501
        //18495701454879288984856827726077713721403798879715
        //38298203783031473527721580348144513491373226651381
        //34829543829199918180278916522431027392251122869539
        //40957953066405232632538044100059654939159879593635
        //29746152185502371307642255121183693803580388584903
        //41698116222072977186158236678424689157993532961922
        //62467957194401269043877107275048102390895523597457
        //23189706772547915061505504953922979530901129967519
        //86188088225875314529584099251203829009407770775672
        //11306739708304724483816533873502340845647058077308
        //82959174767140363198008187129011875491310547126581
        //97623331044818386269515456334926366572897563400500
        //42846280183517070527831839425882145521227251250327
        //55121603546981200581762165212827652751691296897789
        //32238195734329339946437501907836945765883352399886
        //75506164965184775180738168837861091527357929701337
        //62177842752192623401942399639168044983993173312731
        //32924185707147349566916674687634660915035914677504
        //99518671430235219628894890102423325116913619626622
        //73267460800591547471830798392868535206946944540724
        //76841822524674417161514036427982273348055556214818
        //97142617910342598647204516893989422179826088076852
        //87783646182799346313767754307809363333018982642090
        //10848802521674670883215120185883543223812876952786
        //71329612474782464538636993009049310363619763878039
        //62184073572399794223406235393808339651327408011116
        //66627891981488087797941876876144230030984490851411
        //60661826293682836764744779239180335110989069790714
        //85786944089552990653640447425576083659976645795096
        //66024396409905389607120198219976047599490197230297
        //64913982680032973156037120041377903785566085089252
        //16730939319872750275468906903707539413042652315011
        //94809377245048795150954100921645863754710598436791
        //78639167021187492431995700641917969777599028300699
        //15368713711936614952811305876380278410754449733078
        //40789923115535562561142322423255033685442488917353
        //44889911501440648020369068063960672322193204149535
        //41503128880339536053299340368006977710650566631954
        //81234880673210146739058568557934581403627822703280
        //82616570773948327592232845941706525094512325230608
        //22918802058777319719839450180888072429661980811197
        //77158542502016545090413245809786882778948721859617
        //72107838435069186155435662884062257473692284509516
        //20849603980134001723930671666823555245252804609722
        //53503534226472524250874054075591789781264330331690

        private void problem13()
        {
            BigInteger[] sumArr = {BigInteger.Parse("37107287533902102798797998220837590246510135740250"),
                                    BigInteger.Parse("46376937677490009712648124896970078050417018260538"),
                                    BigInteger.Parse("74324986199524741059474233309513058123726617309629"),
                                    BigInteger.Parse("91942213363574161572522430563301811072406154908250"),
                                    BigInteger.Parse("23067588207539346171171980310421047513778063246676"),
                                    BigInteger.Parse("89261670696623633820136378418383684178734361726757"),
                                    BigInteger.Parse("28112879812849979408065481931592621691275889832738"),
                                    BigInteger.Parse("44274228917432520321923589422876796487670272189318"),
                                    BigInteger.Parse("47451445736001306439091167216856844588711603153276"),
                                    BigInteger.Parse("70386486105843025439939619828917593665686757934951"),
                                    BigInteger.Parse("62176457141856560629502157223196586755079324193331"),
                                    BigInteger.Parse("64906352462741904929101432445813822663347944758178"),
                                    BigInteger.Parse("92575867718337217661963751590579239728245598838407"),
                                    BigInteger.Parse("58203565325359399008402633568948830189458628227828"),
                                    BigInteger.Parse("80181199384826282014278194139940567587151170094390"),
                                    BigInteger.Parse("35398664372827112653829987240784473053190104293586"),
                                    BigInteger.Parse("86515506006295864861532075273371959191420517255829"),
                                    BigInteger.Parse("71693888707715466499115593487603532921714970056938"),
                                    BigInteger.Parse("54370070576826684624621495650076471787294438377604"),
                                    BigInteger.Parse("53282654108756828443191190634694037855217779295145"),
                                    BigInteger.Parse("36123272525000296071075082563815656710885258350721"),
                                    BigInteger.Parse("45876576172410976447339110607218265236877223636045"),
                                    BigInteger.Parse("17423706905851860660448207621209813287860733969412"),
                                    BigInteger.Parse("81142660418086830619328460811191061556940512689692"),
                                    BigInteger.Parse("51934325451728388641918047049293215058642563049483"),
                                    BigInteger.Parse("62467221648435076201727918039944693004732956340691"),
                                    BigInteger.Parse("15732444386908125794514089057706229429197107928209"),
                                    BigInteger.Parse("55037687525678773091862540744969844508330393682126"),
                                    BigInteger.Parse("18336384825330154686196124348767681297534375946515"),
                                    BigInteger.Parse("80386287592878490201521685554828717201219257766954"),
                                    BigInteger.Parse("78182833757993103614740356856449095527097864797581"),
                                    BigInteger.Parse("16726320100436897842553539920931837441497806860984"),
                                    BigInteger.Parse("48403098129077791799088218795327364475675590848030"),
                                    BigInteger.Parse("87086987551392711854517078544161852424320693150332"),
                                    BigInteger.Parse("59959406895756536782107074926966537676326235447210"),
                                    BigInteger.Parse("69793950679652694742597709739166693763042633987085"),
                                    BigInteger.Parse("41052684708299085211399427365734116182760315001271"),
                                    BigInteger.Parse("65378607361501080857009149939512557028198746004375"),
                                    BigInteger.Parse("35829035317434717326932123578154982629742552737307"),
                                    BigInteger.Parse("94953759765105305946966067683156574377167401875275"),
                                    BigInteger.Parse("88902802571733229619176668713819931811048770190271"),
                                    BigInteger.Parse("25267680276078003013678680992525463401061632866526"),
                                    BigInteger.Parse("36270218540497705585629946580636237993140746255962"),
                                    BigInteger.Parse("24074486908231174977792365466257246923322810917141"),
                                    BigInteger.Parse("91430288197103288597806669760892938638285025333403"),
                                    BigInteger.Parse("34413065578016127815921815005561868836468420090470"),
                                    BigInteger.Parse("23053081172816430487623791969842487255036638784583"),
                                    BigInteger.Parse("11487696932154902810424020138335124462181441773470"),
                                    BigInteger.Parse("63783299490636259666498587618221225225512486764533"),
                                    BigInteger.Parse("67720186971698544312419572409913959008952310058822"),
                                    BigInteger.Parse("95548255300263520781532296796249481641953868218774"),
                                    BigInteger.Parse("76085327132285723110424803456124867697064507995236"),
                                    BigInteger.Parse("37774242535411291684276865538926205024910326572967"),
                                    BigInteger.Parse("23701913275725675285653248258265463092207058596522"),
                                    BigInteger.Parse("29798860272258331913126375147341994889534765745501"),
                                    BigInteger.Parse("18495701454879288984856827726077713721403798879715"),
                                    BigInteger.Parse("38298203783031473527721580348144513491373226651381"),
                                    BigInteger.Parse("34829543829199918180278916522431027392251122869539"),
                                    BigInteger.Parse("40957953066405232632538044100059654939159879593635"),
                                    BigInteger.Parse("29746152185502371307642255121183693803580388584903"),
                                    BigInteger.Parse("41698116222072977186158236678424689157993532961922"),
                                    BigInteger.Parse("62467957194401269043877107275048102390895523597457"),
                                    BigInteger.Parse("23189706772547915061505504953922979530901129967519"),
                                    BigInteger.Parse("86188088225875314529584099251203829009407770775672"),
                                    BigInteger.Parse("11306739708304724483816533873502340845647058077308"),
                                    BigInteger.Parse("82959174767140363198008187129011875491310547126581"),
                                    BigInteger.Parse("97623331044818386269515456334926366572897563400500"),
                                    BigInteger.Parse("42846280183517070527831839425882145521227251250327"),
                                    BigInteger.Parse("55121603546981200581762165212827652751691296897789"),
                                    BigInteger.Parse("32238195734329339946437501907836945765883352399886"),
                                    BigInteger.Parse("75506164965184775180738168837861091527357929701337"),
                                    BigInteger.Parse("62177842752192623401942399639168044983993173312731"),
                                    BigInteger.Parse("32924185707147349566916674687634660915035914677504"),
                                    BigInteger.Parse("99518671430235219628894890102423325116913619626622"),
                                    BigInteger.Parse("73267460800591547471830798392868535206946944540724"),
                                    BigInteger.Parse("76841822524674417161514036427982273348055556214818"),
                                    BigInteger.Parse("97142617910342598647204516893989422179826088076852"),
                                    BigInteger.Parse("87783646182799346313767754307809363333018982642090"),
                                    BigInteger.Parse("10848802521674670883215120185883543223812876952786"),
                                    BigInteger.Parse("71329612474782464538636993009049310363619763878039"),
                                    BigInteger.Parse("62184073572399794223406235393808339651327408011116"),
                                    BigInteger.Parse("66627891981488087797941876876144230030984490851411"),
                                    BigInteger.Parse("60661826293682836764744779239180335110989069790714"),
                                    BigInteger.Parse("85786944089552990653640447425576083659976645795096"),
                                    BigInteger.Parse("66024396409905389607120198219976047599490197230297"),
                                    BigInteger.Parse("64913982680032973156037120041377903785566085089252"),
                                    BigInteger.Parse("16730939319872750275468906903707539413042652315011"),
                                    BigInteger.Parse("94809377245048795150954100921645863754710598436791"),
                                    BigInteger.Parse("78639167021187492431995700641917969777599028300699"),
                                    BigInteger.Parse("15368713711936614952811305876380278410754449733078"),
                                    BigInteger.Parse("40789923115535562561142322423255033685442488917353"),
                                    BigInteger.Parse("44889911501440648020369068063960672322193204149535"),
                                    BigInteger.Parse("41503128880339536053299340368006977710650566631954"),
                                    BigInteger.Parse("81234880673210146739058568557934581403627822703280"),
                                    BigInteger.Parse("82616570773948327592232845941706525094512325230608"),
                                    BigInteger.Parse("22918802058777319719839450180888072429661980811197"),
                                    BigInteger.Parse("77158542502016545090413245809786882778948721859617"),
                                    BigInteger.Parse("72107838435069186155435662884062257473692284509516"),
                                    BigInteger.Parse("20849603980134001723930671666823555245252804609722"),
                                    BigInteger.Parse("53503534226472524250874054075591789781264330331690")};

            BigInteger sum = new BigInteger();
            foreach (BigInteger bi in sumArr)
                sum += bi;

            Console.WriteLine("Solution: " + sum.ToString().Substring(0, 10));
    
        }

        //The following iterative sequence is defined for the set of positive integers:

        //n → n/2 (n is even)
        //n → 3n + 1 (n is odd)

        //Using the rule above and starting with 13, we generate the following sequence:

        //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        //It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

        //Which starting number, under one million, produces the longest chain?

        //NOTE: Once the chain starts the terms are allowed to go above one million.
        private void problem14()
        {
            Int64 n = 0;
            int chain = 0;
            int maxChain = 0;
            int startingNum = 0;

            for (int i = 2; i < 1000000; i++)
            {
                chain = 1;
                n = i;

                while(n != 1)
                {
                    if (n % 2 == 0)
                        n = n / 2;
                    else
                        n = 3 * n + 1;

                    chain++;
                }

                if (maxChain < chain)
                {
                    maxChain = chain;
                    startingNum = i;
                }
            }

            Console.WriteLine("Solution: " + startingNum);
        }

        //Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
        //How many such routes are there through a 20×20 grid?

        private void problem15()
        {
            int NUM = 21;
            double[,] paths = new double[NUM, NUM];

            for (int row = 0; row < NUM; row++)
            {
                for (int col = 0; col < NUM; col++)
                {
                    if (row == 0)
                        paths[row, col] = 1;
                    else if (col == 0)
                        paths[row, col] = 1;
                    else
                        paths[row, col] = paths[row - 1, col] + paths[row, col - 1];
                }
            }

            Console.WriteLine("Solution: " + paths[NUM - 1, NUM - 1]);
        }

        //215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
        //What is the sum of the digits of the number 21000?

        private void problem16()
        {
            BigInteger val = (BigInteger) Math.Pow(2, 1000);
            int sum = 0;

            foreach (char c in val.ToString())
                sum += int.Parse(c.ToString());

            Console.WriteLine("Solution: " + sum);
        }
    }
}
