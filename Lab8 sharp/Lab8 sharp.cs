using System;

namespace Lab8_sharp
{
   class STR
    {
        public static int NumberOfUppercaseSimbols(string str)
        {
            int num = 0;
            char[] simbols = new char[26] { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
            for (int i = 0; i < str.Length; i++)
            {

                for (int j = 0; j < 26; j++)
                {
                    if (str[i] == simbols[j])
                    {
                        num++;
                        break;
                    }
                }
            }
            return num;
        }
    }
    class Program
    {
        delegate int Operation(string str);
        static void Main(string[] args)
        {
            Operation del = NumberSimbols;
            string str = "Qwerty123";
            int rez = del.Invoke(str);
            Console.WriteLine($"Number of simbols in string {str} is  {rez}");
            del = STR.NumberOfUppercaseSimbols;
            rez = del.Invoke(str);
            Console.WriteLine($"Number of uppercase simbols in string {str} is  {rez}");

        }
        //private static int NumberOfUppercaseSimbols(string str)
        //{
        //    int num = 0;
        //    char[] simbols = new char[26] {'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M'};
        //    for (int i = 0; i < str.Length; i++)
        //    {

        //        for (int j = 0; j < 26; j++)
        //        {
        //            if (str[i] == simbols[j])
        //            {
        //                num++;
        //                break;
        //            }
        //        }
        //    }
        //    return num;
        //}
        private static int NumberSimbols(string str)
        {
            int num = 0;
            char[] simbols = new char[52] {'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M',
            'q','w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m'};
            for (int i = 0; i < str.Length; i++)
            {
                
                for (int j = 0; j < 52; j++)
                {
                    if (str[i] == simbols[j])
                    {
                        num++;
                        break;
                    }
                }
            }
            return num;
        }

      
    }
}
