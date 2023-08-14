using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace number_problems_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            //factor(24);
            //prime_not(0);
            //prime1_N(34);
            //N_primes(5);
            //numberof_prime(33);
            //sumof_N_primes(3);
            //sumof_less_thanN_prime(10);
             //M_to_Nprime(10,1);
           // prime_factor(35);
            //numof_M_to_Nprime(1, 10);
            //M_to_Nprime_odd_even(10,1);
            //Console.WriteLine( next_prime(7) );
            //Console.WriteLine(previous_prime(7)  ); 
            //nearest_primer(8);
            //kth_prime(6);
            //intervel_prime_not(11, 8);
            //N_make_two_product_prime(6);
           //distinct_prime_facter(1,10);
            //largest_prime(34, 10);
            //smallest_prime(34, 10);
            Nis_powerof_4_k(9,3);
            //.WriteLine( armstrong_not(151)  );
          //  interval_armstrong(35,159);
           // interva_armstrong(151, 159);
           // perfect_square(9);
            //sum_Per_square_N(10);
           // next_perfect_square(9);
            //nearest_amstrong(280);
             //kth_perfect_square(9,2);
          //  kth_armstrong(2,5);
           // kth_polinrome(111,1);
           // square_root(9);
           // fibonacci(22);
            // Console.WriteLine(Math .Sqrt (5));
             //Console.WriteLine(lcm(20,35));
            //Console.WriteLine( Min_divieds(9) );
            //Console.WriteLine( max_divieds(72) ); 
            //fibonacci_I(5);
            //product_unique_prime(45);
           // product_prime(45);
            Console.ReadLine();
        }
        public static bool num_is_prime(int n) {

            int a = (n / 2), count = 0;
            for (int i = 2; i <= a; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return true;
            }
            else
                return false;
        
        
        }
        public static void factor(int n)
        
        {
            for (int i = 1; i <=(n/2); i++)
            {
                if (n % i==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(n);
        }
        public static void prime_not(int n)
        {
            int a=(n / 2),count=0;
            for (int i = 2; i <=a ; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("prime");
            }
            else
                Console.WriteLine("not prime");
        
        }
        public static void N_primes(int n)
        {
            int count = 0;
            
            int i=2,Nprime=0;
                while (Nprime !=n)
                {
                    count = 0;
                    for (int j = 1;j<=i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }

                    }
                    if (count == 2)
                    {
                        Console.WriteLine(i);
                        Nprime++;
                    }

                    i++;    
            }
        }
        public static void prime1_N(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    Console.WriteLine(i);

                }
                }
           }
        public static void numberof_prime(int n)
        {

            int count = 0,num_prime=0;
            for (int i = 1; i <= n; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {

                    num_prime++;
                }
            }
        }
        public static void sumof_N_primes(int n)
        {
            int count = 0,sum=0;

            int i = 2, Nprime = 0;
            while (Nprime != n)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    sum += i;
                    Nprime++;
                }

                i++;
            }
            Console.WriteLine("sum="+sum);
        }
        public static void sumof_less_thanN_prime(int n)
        {
            int count = 0,sum=0;
            for (int i = 1; i <= n; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    sum += i;

                }
            }
            Console.WriteLine("sum="+sum);
        }
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
        public static void M_to_Nprime(int m, int n)
        {
            if (m > n)
            {
                swap(ref m, ref n);
            }
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    Console.WriteLine(i);

                }
            }
        }
        public static void prime_factor(int n)
        {
           int count = 0;

            for (int i = 1; i <= n; i++)
            {
                count = 0;
                if (n % i == 0)
                {
                    
                    
            
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                count++;
                            }

                        }
                        if (count == 2)
                        {
                            Console.WriteLine(i);
                            
                        }
                    
                }
            }
            
        }
        public static int numof_M_to_Nprime(int m,int n)
        {
            if (m > n)
            {
                swap(ref m, ref n);
            }
            int count = 0,number_of_prime=0;
            for (int i = m; i <= n; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    number_of_prime++;

                }
            }
          return  number_of_prime ;
        }
        public static void M_to_Nprime_odd_even(int m, int n)
        { 
         if (m > n)
            {
                swap(ref m, ref n);
            }
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    if (i % 2 == 0)
                    { Console.WriteLine(i + "even"); }
                    else
                    { Console.WriteLine(i + "odd"); }


                }
            }
        }
        public static int next_prime(int n)
        {
            
                n++;
            int count = 0,next_p=0;

            int i = n, Nprime = 0;
            while (Nprime !=1)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    next_p = i;
                    Nprime++;
                }

                i++;
            }
            return next_p;
            
        }
        public static int previous_prime(int n) {
            
           
                n--;
            int count = 0,previous=0;

            int i = n, Nprime = 0;
            while (Nprime != 1)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    previous =i;
                    Nprime++;
                }

                i--;
            }
            return previous;
        }
        public static void nearest_primer(int n)
        {
           int previous = previous_prime(n);
           int next = next_prime(n);
           int a = (int)Math.Abs(n - previous);
           int b = (int)Math.Abs(n - next);
            if(a>b)
                Console.WriteLine(next);
            else
                Console.WriteLine(previous);

        }
        public static void kth_prime(int n)
        {
            int count = 0,kth=0;

            int i = 2, Nprime = 0;
            while (Nprime != n)
            {
                
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    kth = i;
                    Nprime++;
                }

                i++;
            }
         Console.WriteLine(kth);
        }
        public static void intervel_prime_not(int m,int n)
        {
            if (m > n)
                swap(ref m, ref n);
            int count = 0,yes=0;
            for (int i = m; i <= n; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    yes++;

                }
            }
            if(0<yes)
                Console.WriteLine("true ");
            else
                Console.WriteLine(false );
        }

        public static void N_make_two_product_prime(int n)
        {
            if (num_is_prime(n))
                Console.WriteLine("false");
            else
            {
                int count = 0, product = 1, any_two = 0;
                int i = 2;
                while (any_two != 2)
                {

                    count = 0;
                    for (int j = 1; j <= i && i < n; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }

                    }
                    if (count == 2)
                    {
                        if (n % i == 0)
                        {
                            product *= i;
                            any_two++;
                            Console.WriteLine(i);
                        }

                    }

                    i++;
                }
                if (product == n)
                    Console.WriteLine("true");


            }
        }
        #region largest prime
        public static void largest_prime(int m,int n)
        {
            int p = numof_M_to_Nprime(m, n),l=0;
                if (m > n)
                {
                    swap(ref m, ref n);
                }
                int count = 0;
                for (int i = m; i <= n; i++)
                {
                    count = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }

                    }
                    if (count == 2)
                    {
                        l++;
                        if(l==p)
                            Console.WriteLine(i);
                        

                    }
                }
            
        }       
        #endregion
        #region
        public static void smallest_prime(int m,int n)
        {
            int l=0;
                if (m > n)
                {
                    swap(ref m, ref n);
                }
                int count = 0;
                for (int i = m; i <= n; i++)
                {
                    count = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }

                    }
                    if (count == 2)
                    {
                        l++;
                        if(l==1)
                            Console.WriteLine(i);
                        

                    }
                }
            
        }       
        #endregion
        #region if n is power of k
        public static void Nis_powerof_4_k(int n, int k)
        {
            int a = n;
            int ans = (int)Math.Pow (4,(Math.Log(n)/Math.Log(4)));
         
            if ((int)Math.Pow (4,(Math.Log(n)/Math.Log(4))) == a&&a!=0)
                Console.WriteLine("true :given number 4 power");
         
             else if ((int)Math.Pow (4,(Math.Log(n)/Math.Log(4))) == a&&a!=0 )
                    Console.WriteLine("true :given number"+k+ " power "+2);
                else
                    Console.WriteLine("false");
            
           
        }

      
        #endregion
        public static int numofdgt(int n)
        {

            int count = 0;
            while (n != 0)
            {
                n = n / 10;
                count++;
            }
            //Console.WriteLine("digit="+count );
            return count;
        }
        #region armstrong number or not
        public static string armstrong_not(int n)
        {
            int a = numofdgt(n),re,b=n;
            int sum = 0;
            while(n!=0)
            {
                re = n % 10;
                sum = sum +(int) Math.Pow(re, a);
                n = n / 10;
            }
            if (sum == b)
            {
                return "armstrong";
                // Console.WriteLine("armstrong");
            }
            else
            { return "con\'t armsroung";
           // Console.WriteLine("con\'t armsroung");
            }

        }
        #endregion
        #region find the armstoung number given interval
        public static void interva_armstrong(int m,int n)
        {
            for (int i = m; i <= n; i++)
            {
                int b = 0;
                int a = numofdgt(i), re; b = i;
                int sum = 0;
                while (b != 0)
                {
                    re = b % 10;
                    sum = sum + ((int)Math.Pow(re, a));
                    b= b / 10;
                }
                if (sum == i)
                {
                    Console.WriteLine("armstrong"+sum);
                }

            }
        }
        #endregion
        #region perfect square or not
        public static void perfect_square(int n)
        {
            double a = Math.Sqrt(n);
            if (Math.Floor(a) == Math.Ceiling(a))
            {
                Console.WriteLine("perfect square");
            }
            else
            {
                Console.WriteLine("not perfect square");
            }


           
        }

        #endregion
        #region sum of perfect square up to n
        public static void sum_Per_square_N(int n)
        {
            double a; int sum = 0;
            for (int i = 1; i <= n; i++)
            {a=0;
                a = Math.Sqrt(i);
                if (Math.Floor(a) == Math.Ceiling(a))
                {
                    sum += i; 
                }
              
            }
            Console.WriteLine("sum of perfect square:"+sum);
        }
        #endregion
        #region next perfect square
        public static void next_perfect_square(int n)
        {
            double a; int count = 0;int i = n+1;
         while(count!=1)
            {
                a = 0;
                a = Math.Sqrt(i);
                if (Math.Floor(a) == Math.Ceiling(a))
                {
                    count++;
                }
                if (count == 1)
                { Console.WriteLine(i); }
                i++;

            }
        }
        #endregion
        #region nearest amstrong
        
        public static int previous_amst(int n)
        {
            int c=0,i=n-1,a=0;
            while (c != 1)
            {
                if (armstrong_not(i) == "armstrong")
                { c++;
                a = i;
                }
                i--;
            }

            return a;
        }
        public static int next_amst(int n)
        {
            int c = 0, i = n + 1,a=0;
            while (c != 1)
            {
                if (armstrong_not(i) == "armstrong") { c++; a = i; }
                i++;
            }

            return a;
        }public static void nearest_amstrong(int n)
        {
         
           
                int next = next_amst(n);
            
            int prev = previous_amst(n);
            int a = Math.Abs(prev - n);
            int b = Math.Abs(next - n);
            if (a > b)
            { Console.WriteLine(next); }
            else
            { Console.WriteLine(prev); }
        }
        #endregion
        #region next polinrome
        public static string polinrome(int n)
        {
            int a = numofdgt(n), re, b = n;
            int rev = 0;
            while (n != 0)
            {
                re = n % 10;
                rev = rev * 10 + re;
                n = n / 10;
            }
            if (rev == b)
            {
                return "polinrome";
        
            }
            else
            {
                return "con\'t polinrom";
                
            }
        
        }
        public static int next_polinrome(int n)
        {
            int c = 0, i = n + 1, a = 0;
            while (c != 1)
            {
                if (polinrome(i)=="polinrome") { c++; a = i; }
                i++;
            }

            return a; 
        }
        #endregion
        #region kth_perfect_square
        public static void kth_perfect_square(int n,int k) {
            int i = 0; while (i != k)
            {
                double a = Math.Sqrt(n);
                if (Math.Floor(a) == Math.Ceiling(a))
                {
                    n = (int)a + 1;
                    n *= n;
                    i++;
                   
                }
               
            }



            Console.WriteLine(n);
        }
        #endregion
        #region kth_armstrong
        public static void kth_armstrong(int n,int k)
        { int i=0,a;
        while (i != k)
        {
           a= next_amst(n);
            i++;
            n = a;

        }
        Console.WriteLine(n);
        }
        #endregion
        #region kth_polinrome
        public static void kth_polinrome(int n,int k)
        {int i=0,a;
        while (i != k)
        {
           a= next_polinrome(n);
           i++;
           n = a;

        }
        Console.WriteLine(n);
        }
        #endregion
        #region square root
        public static void square_root(int n)
        {
            int i = 1, a=0;
            while (a!=n)
            {
                a = 0;
                a = i * i;
                if (a == n)
                { Console.WriteLine(i); } i++;
            
            }
        }
        #endregion
        #region fibonacci up to n
        public static void fibonacci(int n)
        {
           int a = 0,b=1,c=0;Console.WriteLine(a);
           while (c <=n)
           {
               c = a + b;
               if (c > n) { break; }
               Console.WriteLine(c);
               a = b;
               b = c;


           }

        }
        #endregion
        #region fibonacci to n
        public static void fibonacci_I(int n)
        {
            int a = 0, b = 1, c = 0, i = 1; Console.WriteLine(a);
            while (i < n)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                i++;


            }
        
        }
        #endregion
        #region lcm gcd
        public static long Euclidgcd(long a, long b)
        {
            if (b == 0) return a;
            long ab = Euclidgcd(b, a % b); return ab;
        }
        public static long lcm(long a,long b)
        {
            long lcm = (a * b) / Euclidgcd(2,5); ;
            return lcm;
        }

        #endregion
        #region minimum number divieds n
        public static int Min_divieds(int n)
        {
            int i = 2;
            while (i <= 9)
            {
                if (n % i == 0)
                { return i; }
                i++;
            }
             
            return -1;
        }
        public static int max_divieds(int n)
        {
            int i =9;
            while (i >= 2)
            {
                if (n % i == 0)
                { return i; }
                i--;
            }

            return -1;
        }
        #endregion
        #region product of unique prime number
        public static void product_unique_prime(int n)
        {
            int N = n,sum=0;
            for (int i = 2; i * 2 <= n; i++)
            {
                if (n % i == 0)
                {

                    if (num_is_prime(i))
                    {
                        Console.WriteLine( i);
                        sum++;
                    }
                }
            }
            if (sum == 2)
            { Console.WriteLine("you con see the unique priduct of two prime numbers give"+N); }
            else
            { Console.WriteLine( "more than two"); }

        }
        public static void product_prime(int n)
        {
            int N = n,sum=0,p=0;

            for (int i = 2; i * 2 <= n; i++)
            {
                while (p != n)
                {
                    if (n % i == 0)
                    {

                        if (num_is_prime(i))
                        {
                            Console.WriteLine(i);
                            sum++;
                            p *= i;
                            i = 1;
                        }
                    }
                }
            }
           }
        static void OddEvenAtK()
        {
            int odd = 0;
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (input[0] >= input[1])
            {
                if (input[0] % 2 == 0)
                {

                    odd = input[0] / 2;

                }
                else
                {
                    odd = 1+(input[0] / 2);
                }
                if (odd >= input[1])
                { 
                
                }
            }
        }
        #endregion
    }
}
