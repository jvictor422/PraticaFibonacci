 using System;
using System.Net;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Web;

class TESTE
{
    static void Main(string[] args)
    {

        int num01Fibonacci = 2;
        int num02Fibonacci = 5;
        int FibonacciSequencia;
        double raiz;
        int n;

        FibonacciSequencia = num01Fibonacci - 1 + num02Fibonacci - 2;

        raiz = Math.Sqrt(4);
        Convert.ToBoolean(raiz);
        if (raiz * raiz == 4 )
        {
            Console.WriteLine($"O número pertence a sequencia de fibonacci!");
        }
        else
        {
            Console.WriteLine("Não pertence a sequencia");
        }

       



  

    }
} 

