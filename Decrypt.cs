using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfinTransformationEncrypt
{
    public class Decrypt : Afin
    {
        public Decrypt()
        {

        }
        public Decrypt(int a, int b, string word) : base( a, b, word)
        {

        }
        public override string AfinOutput()
        {
            if (!isPrime)
            {
                return "Your encryption keys \nare not appropriate.";
            }
            else
            {
                int i, j, index, ust;
                StringBuilder sb = new StringBuilder(word.ToUpper());

                for (i = 0; i < word.Length; i++)
                {
                    for (j = 0; j < alphabet.Length; j++)
                    {
                        if(word[i] == alphabet[j])
                        {
                            ust = j-b;
                            while(ust < 0 || ust % a != 0)
                            {
                                ust += 26;
                            }
                            index = (ust/a) % 26;
                            sb[i] = alphabet[index];                            
                        }
                    }
                }
                word = sb.ToString();
                return word;
            }
           
        }
    }
}
