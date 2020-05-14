using System;

namespace Lab3_var_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Text textik = new Text(3);
            //textik[0] = "Hello";
            //textik[1] = "World";
            //textik[2] = "I'm here.";
            
            //Console.WriteLine(textik[0]);
            //Console.WriteLine(textik.NumVowels);
        }
    }
    class Text
    {
        private string[] _text;
        private int count;
        public Text(int n)
        {
            _text = new string[n];
            count = _text.Length;
        }
      
        public int this[int index]
        {
            //set
            //{
            //    _text[index] = value;
            //}
            get
            {
                return _text[index].Length;
            }
        }
        public int NumVowels
        {            
            get
            {
                const string glas_lett = "AaEeIiOoYyUu";
                int cnt = 0;
                for (int kol = 0; kol < count; kol++)
                {
                    for (int i = 0; i < _text[kol].Length; ++i)
                        for (int j = 0; j < glas_lett.Length; ++j)
                            if (_text[kol][i] == glas_lett[j])
                                ++cnt;
                }
                return cnt;
            }
        }
    }
}