using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Samoshina_Lab2 {
    class line
    {
        static int Count(string strB,char strS)
        {
            int count = strB.Count(f => f == strS); 
            /*  for (int i=0;i<strB.Length;i++)
              {
                  if (strB[i] == strS) { count++; }
              }
             */
            return count;
        }
        static string Delete(string strB) {
            string strCopy = "";
            for (int i = 0; i < strB.Length; i++)
            {
                if (!(char.IsDigit(strB[i]))) { strCopy += strB[i]; }
            }
            return strCopy;
        }
        static bool Findkey(string strB, string key)
        {
            char[] b = key.ToCharArray();
            foreach (char x in b)
            {
                if (strB.IndexOf(x) == -1) { return false; }
            }
          //  if (strB.IndexOf("k") != -1 && strB.IndexOf("e")!=-1 && strB.IndexOf("y") != -1) { return true; }

            return true;
        }
        static bool Skoboshki(string strB)
        {
            int count = 0;
            for(int i=0; i<strB.Length; i++)
            {
                if (strB[i] == '(') count++;
                if(strB[i] == ')') count--;
                if (count < 0) return false;
            }
            return count == 0;
        }
        static void Main() {
            var strBig = Console.ReadLine();
            char strSmall = Console.ReadLine()[0];
            var key = "key";
            if (strBig != null)
            {
                Console.WriteLine(Count(strBig, strSmall)); //сколько подстроки в строке
                Console.WriteLine(Delete(strBig)); // удаляет цифры
                Console.WriteLine(Findkey(strBig, key)); //ищет слово
                Console.Write(Skoboshki(strBig));//нормальные ли скобки
            }
        }
    }
}