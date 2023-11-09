using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring all possible variables in the password
            string uppercaseLetters = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            string lowercaseUppercase = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string characterLetters = "!@#$%^&*?_-";

            Random random = new Random();
            bool generatingPassword = true;

            while (generatingPassword)
            {
                // User gets to choose which elements the password should concist of
                Console.WriteLine("Welcome to password generator!");
                Console.WriteLine("What's your desired password length?");
                int passwordLength = int.Parse(Console.ReadLine());

                Console.WriteLine("Uppercase or lowercase letters or both in the password (U/L/B)?");
                string letterPreference = Console.ReadLine();

                Console.WriteLine("Do you want numbers in it (Y/N)?");
                string numberPreference = Console.ReadLine();

                Console.WriteLine("Do you want characters in it (Y/N)?");
                string characterPreference = Console.ReadLine();

                char[] arrayPassword = new char[passwordLength];

                for (int i = 0; i < passwordLength; i++)
                {
                    string randomPassword = "";
                    if (letterPreference == "U")
                    {
                        randomPassword += uppercaseLetters;
                    }

                    else if (letterPreference == "B")
                    {
                        randomPassword += lowercaseUppercase;
                    }

                    else
                    {
                        randomPassword += lowercaseLetters;
                    }

                    if (characterPreference == "Y")
                    {
                        randomPassword += characterLetters;
                    }

                    if (numberPreference == "Y")
                    {
                        randomPassword += numbers;
                    }

                    arrayPassword[i] = randomPassword[random.Next(0, randomPassword.Length)];
                }

                Console.Write($"Password generated: ");
                Console.WriteLine(arrayPassword);

                string newPassword = new string(arrayPassword);

                Console.WriteLine($"Generate new password or keep it (N/K)?");
                string continuePassword = Console.ReadLine();
                if (continuePassword == "N")
                {
                    generatingPassword = true;
                }

                else
                {
                    generatingPassword = false;
                    Console.WriteLine($"Password changed: {newPassword}");
                }
            }
        }
    }
}
