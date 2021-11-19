using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана строка S.Из строки требуется удалить текст, заключенный в фигурные скобки.
            //В строке может быть несколько фрагментов, заключённых в фигурные скобки.
            //Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
            string sentence = "Ничто так не {{ограничивает} полет} мысли {начинающего} программиста, как компилятор.";
            StringBuilder modSentence = new StringBuilder();  //инициализация модифицированной строки                
            int i = 0;
            foreach (char symbol in sentence)       //выбор символов добавляемых к новой строке
            {
                if (symbol == '{')
                {
                    i++;
                }
                else if (symbol == '}')
                {
                    i--;
                }
                else if (i == 0) 
                {
                    modSentence.Append(symbol);     //добавление символов в новую строку
                }                
            }
            Console.WriteLine(modSentence);     //вывод исправленного приложения на монитор
            Console.ReadKey();
        }
    }
}
