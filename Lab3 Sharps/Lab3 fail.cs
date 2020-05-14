using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Sharps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class MySring
    {
        private char[] str = { };
        private int length;
        public MySring()
        {
            str = new char['0'];
            length = 0;
        }
        public MySring(char[] str)
        {
            length = Dovgina(str);
            this.str = new char[length + 1];
            for (int i = 0; i < length; i++)
            {
                this.str[i] = str[i];
            }
            this.str[length] = '\0';
        }
        public int Dovgina()
        {
            int len = 0;
            while (str[len] != '\0')
            {
                len++;
            }
            return len;
        }
        public int Dovgina(char[] str)
        {
            int len = 0;
            while (str[len] != '\0')
            {
                len++;
            }
            return len;
        }
        public void Print()
        {
            Console.Write(str); Console.Write(" ");
        }
        public char[] SmenSimv(char a, char b)
        {
            for (int i = 0; i < length; i++)
            {
                if (str[i] == a)
                {
                    str[i] = b;
                }
            }
            return str;
        }



    }
    public class MyText
    {
        private MySring[] _text;
        private int cunt;
        private char[] strr;

        public MyText()
        {
            _text = new MySring[cunt];
            cunt = 0;
        }

        public MySring this[int index]
        {
            set
            {
                _text[index] = value;
            }
            get
            {
                //strr = _text[index];
                //int x = strr.Length;
                int zez = _text[index].Dovgina();
                string sroka = zez.ToString();
                MySring srok = new string;
                return srok ;
            }
        }
        public MySring[] PlussString(MySring str)
        {
            MySring[] _temptext = new MySring[cunt];
            for (int i = 0; i < cunt; i++)
            {
                _temptext[i] = _text[i];
            }
            _text = new MySring[cunt + 1];
            for (int i = 0; i < cunt; i++)
            {
                _text[i] = _temptext[i];
            }
            _text[cunt] = str;
            cunt++;
            return _text;
        }
        public MySring[] DelString(int num)
        {
            num--;
            MySring[] _temptext = new MySring[cunt - 1];
            for (int i = num; i < cunt - 1; i++)
            {
                _text[i] = _text[i + 1];
            }
            for (int i = 0; i < cunt - 1; i++)
            {
                //if (num > cunt - 1) continue;
                _temptext[i] = _text[i];
            }
            cunt--;
            return _temptext;

        }
        public int KolStrok()
        {
            return cunt;
        }

        public MySring[] SmenaSimvola(char a, char b)
        {
            for (int i = 0; i < cunt; i++)
            {
                _text[i].SmenSimv(a, b);
            }
            return _text;
        }
        public void PoiskStroki(int num)
        {
            num--;
            _text[num].Print();
        }
        public MySring[] DelText()
        {
            cunt = 0;
            _text = new MySring[cunt];

            return _text;
        }
        public void Print_t()
        {
            for (int i = 0; i < cunt; i++)
            {
                _text[i].Print();
            }
            Console.WriteLine();
        }
    }
}
