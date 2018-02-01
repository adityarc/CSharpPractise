using System;

namespace AdisNamespace
{
    class Indexer
    {
        string[] str = new string[5];
        public string this[int idx]
        {
            get { return str[idx]; }
            set { str[idx] = value; }
        }
        static void Main(string[] args)
        {
            Indexer obj = new Indexer();
            obj[0] = "ABC";
            obj[1] = "DEF";
            obj[2] = "GHI";
            obj[3] = "JKL";
            obj[4] = "MNO";
            int i = 0;
            for (; i < 5; i++)
            {
                Console.WriteLine("obj[" + i + "]:\t" + obj[i]);
            }
        }
    }
}
