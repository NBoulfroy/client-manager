using System;
using System.Security.AccessControl;
using System.Security.Principal;
using System.IO;

namespace DataLibrary
{
    [Serializable]
    public abstract class Database
    {
        /// <summary>
        /// Return string like "Nicolas" or "Pierre-Robert".
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        protected static string FirstNameManipulation(string firstName)
        {
            string manipulation;

            if (firstName.Contains("-"))
            {
                string[] words = firstName.Split('-');
                manipulation = "";

                for (int i = 0; i < words.Length; i++)
                {
                    manipulation += words[i].Substring(0, 1).ToUpper() + words[i].Substring(1, words[i].Length - 1).ToLower() + "-";

                    if (i == words.Length - 1)
                    {
                        return manipulation = manipulation.Substring(0, manipulation.Length - 1);
                    }
                }

                return manipulation;
            }
            else
            {
                string firstName_begin = firstName.Substring(0, 1).ToUpper();
                string firstName_end = firstName.Substring(1, firstName.Length - 1);
                return manipulation = firstName_begin + firstName_end;
            }
        }

        /// <summary>
        /// Return string like "BOULFROY", "DE MONTMORENCY" and "DUPONT-SMITH.
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        protected static string LastNameManipulation(string lastName)
        {
            string manipulation;
            manipulation = "";

            if (lastName.Contains(" "))
            {
                string[] words = lastName.Split(' ');
                manipulation = "";

                for (int i = 0; i < words.Length; i++)
                {
                    manipulation += words[i].Substring(0, words[i].Length).ToUpper() + " ";

                    if (i == words.Length - 1)
                    {
                        return manipulation = manipulation.Substring(0, manipulation.Length - 1);
                    }
                }
            }

            if (lastName.Contains("-"))
            {
                string[] words = lastName.Split('-');
                manipulation = "";

                for (int i = 0; i < words.Length; i++)
                {
                    manipulation += words[i].Substring(0, words[i].Length).ToUpper() + "-";

                    if (i == words.Length - 1)
                    {
                        return manipulation = manipulation.Substring(0, manipulation.Length - 1);
                    }
                }
            }

            if (lastName.Contains(" de ") || lastName.Contains(" DE ") || lastName.Contains(" dE ") || lastName.Contains(" De "))
            {
                string[] words = lastName.Split('-');
                manipulation = "";

                for (int i = 0; i < words.Length; i++)
                {
                    manipulation += words[i].Substring(0, words[i].Length).ToUpper() + " DE ";

                    if (i == words.Length - 1)
                    {
                        return manipulation = manipulation.Substring(0, manipulation.Length - 4);
                    }
                }
            }

            return manipulation = lastName.ToUpper();
        }
    }
}
