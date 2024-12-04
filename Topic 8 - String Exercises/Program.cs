using System.Transactions;

namespace Topic_8___String_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, studentNumber, username, email, reverseName, backwards, palindrome, palindromeReversed;

            Console.WriteLine("What is your first name? ");
            firstName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What is your last name? ");
            lastName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What is your student number? ");
            studentNumber = Console.ReadLine();

            Console.WriteLine();

            username = firstName.Substring(0, 3).ToLower() + lastName.Substring(0, 3).ToLower() + studentNumber.Substring(studentNumber.Length - 3);

            email = firstName[0].ToString().ToLower() + lastName.ToLower() + "@parkside.ca";

            Console.WriteLine("Hello, " + firstName + " " + lastName + " your username is " + username + " and your email is " + email + "!");

            Console.WriteLine();

            Console.WriteLine(firstName.ToUpper() + " " + lastName.ToLower());

            Console.WriteLine();

            reverseName = firstName + lastName;

            Console.WriteLine(reverseName);

            backwards = reverseName;

            for (int i = 0; i < backwards.Length; i++)
            {
                backwards = backwards.Insert(i, backwards[backwards.Length - 1].ToString());
                backwards = backwards.Remove(backwards.Length - 1);
            }

            Console.WriteLine(backwards);

            Console.WriteLine();

            Console.Write("Give me a palindrome: ");
            palindrome = Console.ReadLine();

            Console.WriteLine();

            palindromeReversed = palindrome;

            for (int i = 0; i < palindromeReversed.Length; i++)
            {
                palindromeReversed = palindromeReversed.Insert(i, palindromeReversed[palindromeReversed.Length - 1].ToString());
                palindromeReversed = palindromeReversed.Remove(palindromeReversed.Length - 1);
            }


        }
    }
}
