using System;

namespace Lab2_Sharps
{
    class Program
    {
        static void Main(string[] args)
        {
            MySring str=new MySring (new char[] { 'H','e','l','l','o','\0' });
            MySring str2 = new MySring(new char[] { 'W','o','r','l','d','\0' });
            MySring str3 = new MySring(new char[] { 'I','m',' ','h','e','r','e','\0'});
            int kol;
            //str.Print();
            MyText txt=new MyText();
            txt.PlussString(str); // Добавление строки str
            txt.PlussString(str2);
            txt.PlussString(str3);
            txt.Print_t();

            txt.DelString(1); // Удаление первой строки
            txt.Print_t();
            txt.PlussString(str);

            kol = txt.KolStrok(); // Количество строк
            Console.WriteLine(kol);
            txt.Print_t();

            txt.SmenaSimvola('r', 'F'); // Смена всех о на r  в тексте
            txt.Print_t();

            txt.PoiskStroki(2); // Поиск и вывод заданой строки

            txt.DelText(); //  Очистка текста
            txt.Print_t();
        }
    }
    public class MySring
    {
        private char[] str= { };
        private int length;
        public MySring()
        {
            str = new char['0'];
            length = 0;
        }
        public MySring( char[] str) {
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
        public int  Dovgina(char[] str) {

        int len = 0;
	    while (str[len] != '\0') {
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
        private MySring[] _text ={ };
        private int cunt;

        public MyText()
        {

            _text = new MySring[cunt];
            cunt = 0;
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
            for (int i = 0; i < cunt-1; i++)
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

        public MySring[] SmenaSimvola(char a,char b) {
	    for (int i = 0; i<cunt; i++) {
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
