using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_2
{
    class Program
    {
        //Ввести с клавиатуры предложение.Предложение представляет собой слова, разделенные пробелом. 
        //Знаки препинания не используются. 
        //Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»)/

        static void Main(string[] args)
        {
            Console.WriteLine("Введите пожалуйста предложение");
            string sentence = Console.ReadLine();
            string[] sentenceArray = sentence.Split();      //Разделение строки на подстроки                                                                  
            string contSentence = String.Join("", sentenceArray);   //Обратная склейка в строку без пробелов           
            contSentence = contSentence.ToLower();  //Перевод всех букв в один регистр
            char[] charArray = contSentence.ToCharArray();  //Разделение строки на массив отдельных символов
            bool palindrome = true;
            for (int i = 0, j = charArray.Length - 1; i <= j; i++, j--) //Проверка на совпадение символов при чтении в обратном порядке
                if (charArray[i] != charArray[j])
                {
                    palindrome = false;              
                }
            if (palindrome)
            {
                Console.WriteLine("Предложение является палиндромом!");
            }
            else
            {
                Console.WriteLine("Предложение не является палиндромом!");
            }
            Console.ReadKey();
        }
    }
}
