using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
            //Знаки препинания не используются. Найти самое длинное слово в строке.                   

            Console.WriteLine("Введите пожалуйста предложение");
            string sentence = Console.ReadLine();
            string[] sentenceArray = sentence.Split();
            string maxWord = sentenceArray[0];

            foreach (string word in sentenceArray)      //поиск "самого длинного" слова
            {
                if (maxWord.Length < word.Length)
                {
                    maxWord = word;
                }
            }
            Console.WriteLine("Самое длинное слово(а) в предложении: ");    
            Console.Write("{0} ", maxWord);
            foreach (string word in sentenceArray)      //поиск слов, длина которых аналогична "самому длинному"
            {
                if (maxWord.Length == word.Length && maxWord != word)
                {
                    Console.WriteLine("{0} ", word);
                }
            }
            Console.ReadKey();
        }
    }
}
