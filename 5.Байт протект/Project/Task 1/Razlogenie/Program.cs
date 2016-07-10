using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razlogenie
{
    class Program
    {      
        static void Main(string[] args)
        {                    
            string userIsDone = "";
            do 
            {
             Console.WriteLine("Enter the number N:");
             long n = Convert.ToInt32(Console.ReadLine());
             long i = 2;//the smallest prime number
             bool ans = false;

             while ((i <= n/2) && (ans != true)) 
             {
              long j = i;
              while ((j <= n / (2*i)) && (ans != true))  
              {
                long k = j;
                while ( (k<= n / (i*j)) && (ans != true) )
                {
                  if (prostoe(i) && prostoe(j) && prostoe(k) && (i*j*k==n))
                    {
                        ans = true;
                        DispRes(ans,i,j,k,n);                        
                    }
                  else 
                    k++;
                 }
                if (ans != true) 
                 j++;
              }
              if  (ans != true) 
              i++;
             };
             if (ans != true)
              DispRes(ans, 0, 0, 0, 0);
             Console.Write("Are you done? [yes] [no]: ");
             userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); 

                        
        }

        static bool prostoe(long m)
        {
            for (long i = 2; i < m; i++)
                if (m % i == 0) return false;
            return true;
        }

        private static void DispRes(bool ans, long i, long j, long k, long n)
        {
            Console.WriteLine("{0} – The entered number ", n);
            if (ans == true)
                Console.WriteLine("Answer - Yes {0}*{1}*{2} = {3}", i, j, k, n);
            else
                Console.WriteLine("Answer - No");    
        }
       
    }
}
