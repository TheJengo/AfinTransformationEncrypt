using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfinTransformationEncrypt
{
    public abstract class Afin
    {
        public int a { get; set; }
        public int b { get; set; }

        public Boolean isPrime { get; set; }

        public string word { get; set; } 

        public char[] alphabet = new  char[]{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

        public Afin()
        {

        }
        public Afin(int a, int b, string word)
        {
            this.a = a;
            this.b = b;
            this.word = word;
            
            if(GCD(this.a,this.b) == 1)
            {
                isPrime = true;
            }
        }
        public int GCD(int a, int b) 
        {

            while(a != b)
            {
                if (a > b)
                    a = a - b;
                if (b > a)
                    b = b - a;
            }
            return a;
        }
        public abstract string AfinOutput();
    }
}
