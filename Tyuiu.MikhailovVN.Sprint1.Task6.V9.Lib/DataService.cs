
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MikhailovVN.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string[] words = value.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

               
                if (word.Length > 1)
                {
                    char lastLetter = word[word.Length - 1]; 
                    string restOfWord = word.Substring(0, word.Length - 1); 

                    words[i] = lastLetter + restOfWord; 
                }
            }

           
            return string.Join(" ", words);
        }
    }
}
