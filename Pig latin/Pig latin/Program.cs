using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_latin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I dont know how to write a program for a speech based game. There were few instructions so I just kinda made something IDK what but yeah.");
            Console.WriteLine("This is something I made and as always just type in - to exit the program.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            while (true)
            {

                //setup word
                int consonant = 0;
                int check = 0;
                string word = "";
                int wordListLength = 0;
                Console.Clear();
                Console.WriteLine("Input word to translate into pig latin: ");
                word = Console.ReadLine();
                var letters = word.ToArray();
                List<char> wordList = new List<char>(word.Length);
                wordListLength = word.Length;

                //convert word to list
                for (int i = 0; i < word.Length; i++)
                {
                    wordList.Add(letters[i]);
                }
                Console.Clear();

                //starts loop 

                for (int i = 0; i < wordListLength; i++)
                {
                    char temp = wordList[i];

                    if (check == 0)
                    {
                        //start by moving the first letter to the end of the word
                        wordList.Add(letters[0]);
                        wordList.Remove(letters[0]);

                        if (temp == '-')
                        {
                            return;
                        }
                        else
                        {
                            check = 1;
                        }
                    }
                    else
                    {

                        //start with consonant = add 'ay'
                        if (temp != 'a' && temp != 'e' && temp != 'o' && temp != 'u' && consonant == 0)
                        {
                            consonant = 1;
                        }

                        //start with consonant clusters = add 'ay' after moving another letter to the end
                        if (temp != 'a' && temp != 'e' && temp != 'o' && temp != 'u' && consonant == 1)
                        {
                            wordList.Add(letters[i]);
                            wordList.Remove(letters[i]);
                            wordList.Add('a');
                            wordList.Add('y');
                            consonant = 2;
                        }

                        //start with vowel sound (vowels by themselves) = add 'yay'/'way'/'hay'
                        if (temp == 'a' && i == 0 || temp == 'e' && i == 0 || temp == 'o' && i == 0 || temp == 'u' && i == 0)
                        {
                            wordList.Add('y');
                            wordList.Add('a');
                            wordList.Add('y');
                            consonant = 3;
                        }
                    }
                }

                //Rules:
                //start by moving the first letter to the end of the word
                //if start with consonant = add 'ay'
                //if start with consonant clusters = add 'ay' after moving another letter to the end
                //if start with vowel sound (vowels by themselves) = add 'yay'/'way'/'hay'

                Console.Clear();

                wordListLength = wordList.Count;
                for (int i = 0; i < wordListLength; i++)
                {
                    Console.Write(wordList[i]);
                }

                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
