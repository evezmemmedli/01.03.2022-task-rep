using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03._2022_task_rep
{
    static class Extensions
    {
        public static string isCapitalized(this string word)
        {
            #region
            word = word.ToLower();
            var newWord = word.Split(' ');
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string item in newWord)
            {
                stringBuilder.Append(char.ToUpper(item[0])); /*+item.Substring(1) + " ";*/
                for (int i = 1; i < item.Length; i++)
                {
                    stringBuilder.Append(item[i]);

                }
                stringBuilder.Append(" ");
            }
            return stringBuilder.ToString();

            #endregion
        }
    }
}
