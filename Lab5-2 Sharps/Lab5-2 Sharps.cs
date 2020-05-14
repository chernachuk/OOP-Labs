using System;

namespace Lab5_2_Sharps
{
    class Strings : Exception
    {

        protected char[] str = { };
        protected int length;

        public Strings()
        {
            str = new char['0'];
            length = 0;
        }
        public Strings(char[] str) {
        length = Lent(str);
		this.str = new char[length + 1];
		for (int i = 0; i<length; i++) {
			this.str[i] = str[i];
		}

        this.str[length] = '\0';

    }

    virtual public int Len()
    {
        int len = 0;
        while (str[len] != '\0')
        {
            len++;
        }
        return len;
    }
    public int Lent(char[] str)
    {
        int len = 0;
        while (str[len] != '\0')
        {
            len++;
        }
        return len;
    }
        virtual public char[] Return()
    {
        return str;
    }
    virtual public void Decrease(int n)
    { // Уменьшение
        char[] _tempstr = new char[length - n+1];

        for (int i = 0; i < length - n; i++)
        {
            _tempstr[i] = str[i];
        }
        _tempstr[length - n] = '\0';
        str = new char[length - n+1];
        str = _tempstr;

    }

};
class Simbols : Strings
{


        public Simbols()
    {
            str = new char['0'];
            length = 0;
    }
        public Simbols(char[] str) {

        length = Lent(str);
		this.str = new char[length + 1];
		for (int i = 0; i<length; i++) {
			this.str[i] = str[i];
		}
        char[] numbers = new char[11] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '\0' };

        this.str[length] = '\0';
		for (int i = 0; i<length; i++) {
            try
            {
                for (int j = 0; j < Lent(numbers); j++)
                {
                    if (str[i] == numbers[j])
                    {
                        throw new ArgumentException("Simbols can't have numbers.");
                        break;
                    }
                }
            }
            catch (ArgumentException e) {
                    Console.WriteLine("It was mistake: " + e);
                }
        }
}

    override public int Len() {
    int len = 0;
    while (str[len] != '\0')
    {
        len++;
    }
    return len;
}
    override public char[] Return() {
    return str;
}


    override public void Decrease(int n) {
    char[] _tempstr = new char[length / 2+1];
    _tempstr[length / 2] = '\0';
    int j = 0;
    for (float i = 0.5f; j < length / 2; i++)
    {
        int k = Convert.ToInt32(i * 2) ;
        _tempstr[j] = str[k];
        j++;
    }
    str = new char[length / 2+1];
    str = _tempstr;
}

};
class Numbers : Strings
{

        public Numbers()
    {
            str = new char['0'];
            length = 0;
    }
        public Numbers( char[] str) {

        length = Lent(str);
		this.str = new char[length + 1];
		for (int i = 0; i<length; i++) {
			this.str[i] = str[i];
		}
char[] simbols = new char[53] {'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M',
            'q','w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m', '\0'};

        this.str[length] = '\0';
		for (int i = 0; i<length; i++) {
    try
    {
        for (int j = 0; j < Lent(simbols); j++)
        {
            if (str[i] == simbols[j])
            {
                throw new ArgumentException("Numers can't have simbols.");
                break;
            }
        }
    }
    catch (ArgumentException e) {
                    Console.WriteLine("It was mistake: " + e);
                }
    }
    }

    override public void Decrease(int n) {
    char[] _tempstr = new char[length / 2 + 2];
    _tempstr[length / 2 +1] = '\0';
    for (int i = 0; i < length / 2 + 1; i++)
    {
        _tempstr[i] = str[i * 2];
    }

    str = new char[length / 2 + 2];
    str = _tempstr;
}
    override public char[] Return() {
    return str;
}
    override public int Len() {
    int len = 0;
    while (str[len] != '\0')
    {
        len++;
    }
    return len;
}


};
class Program
    {
        static void Main(string[] args)
        {
            Strings str = new Strings (new char[]{ 'H','e','l','l','o','\0' });
            Console.WriteLine(str.Return());
            Console.WriteLine(str.Len());           
            str.Decrease(2);
            Console.WriteLine(str.Len());
            Console.WriteLine(str.Return());
            Console.WriteLine();

            Simbols simb = new Simbols(new char[] { 'W', 'o', 'r', 'l', 'd', '\0' });
            Console.WriteLine(simb.Return());
            Console.WriteLine(simb.Len());
            simb.Decrease(2);
            Console.WriteLine(simb.Len());
            Console.WriteLine(simb.Return());
            Console.WriteLine();

            Numbers num = new Numbers(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8',  '\0' });
            Console.WriteLine(num.Return());
            Console.WriteLine(num.Len());
            num.Decrease(2);
            Console.WriteLine(num.Len());
            Console.WriteLine(num.Return());
            Console.WriteLine();


        }
    }
}
