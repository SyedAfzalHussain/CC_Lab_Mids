//using System;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace PasswordGenerator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string registrationNumber = "55"; // Example registration number
//            string firstName = "Afzal";
//            string lastName = "Kazmi";
//            string favoriteMovie = "Intersteller";

//            string password = GeneratePassword(registrationNumber, firstName, lastName, favoriteMovie);
//            Console.WriteLine($"Generated Password: {password}");
//        }

//        static string GeneratePassword(string registrationNumber, string firstName, string lastName, string favoriteMovie)
//        {
//            StringBuilder password = new StringBuilder();

//            // Add 2 digits from registration number using regex
//            password.Append(Regex.Match(registrationNumber, @"\d{2}").Value);

//            // Add second letters from first name and last name using regex
//            if (firstName.Length > 1) password.Append(Regex.Match(firstName, @"^.{1}(.)").Groups[1].Value);
//            if (lastName.Length > 1) password.Append(Regex.Match(lastName, @"^.{1}(.)").Groups[1].Value);

//            // Add 2 characters from favorite movie using regex
//            password.Append(Regex.Match(favoriteMovie, @".{2}").Value);

//            // Add special characters
//            password.Append("!@");

//            // Fill the rest with random characters excluding '#'
//            Random random = new Random();
//            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@$%^&*()-_=+[]{}|;:'\",.<>?/";
//            chars = Regex.Replace(chars, "#", ""); // Exclude '#'

//            while (password.Length < 14)
//            {
//                password.Append(chars[random.Next(chars.Length)]);
//            }

//            // Shuffle the password to ensure randomness
//            return Shuffle(password.ToString());
//        }

//        static string Shuffle(string str)
//        {
//            char[] array = str.ToCharArray();
//            Random random = new Random();
//            for (int i = array.Length - 1; i > 0; i--)
//            {
//                int j = random.Next(i + 1);
//                char temp = array[i];
//                array[i] = array[j];
//                array[j] = temp;
//            }
//            return new string(array);
//        }
//    }
//}
