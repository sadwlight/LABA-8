using System;
using System.Text.RegularExpressions;

namespace EmailValidatorApp
{
    public class EmailValidator
    {
        private static readonly Regex EmailRegex = new Regex(
            @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
            RegexOptions.Compiled);

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return EmailRegex.IsMatch(email.Trim());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Валидатор Email");
            Console.Write("Введите email: ");
            string email = Console.ReadLine();

            if (EmailValidator.IsValidEmail(email))
                Console.WriteLine("Email корректен");
            else
                Console.WriteLine("Email некорректен");
        }
    }
}
