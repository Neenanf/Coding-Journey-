using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do you want to {1} encrypt or run {2} decrypt");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                //ask user for message
                Console.WriteLine("what message do you want to convert?");
                string imput = Console.ReadLine();
                Encrypt(imput);
            }
            else if (answer == "2")
            {
                //ask user for message
                Console.WriteLine("what message do you want to convert?");
                string imput = Console.ReadLine();
                Decrypt(imput);
            }
        }
        static void Decrypt(string imput)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string imputL = imput.ToLower();
            char[] secretMessage = imputL.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            //loop to check encryption
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                if (Array.IndexOf(alphabet, letter) != -1)
                {
                    int letterPosition = ((Array.IndexOf(alphabet, letter) - 3) % 26);
                    encryptedMessage[i] = alphabet[letterPosition];
                }
                else
                {
                    encryptedMessage[i] = secretMessage[i];
                }
            }
            // Print message
            string newMessage = string.Join("", encryptedMessage);
            Console.WriteLine(newMessage);
        }

        // TO ENCRYPT 
        static void Encrypt(string imput)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string imputL = imput.ToLower();
            char[] secretMessage = imputL.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            //loop to check encryption
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                if (Array.IndexOf(alphabet, letter) != -1)
                {
                    int letterPosition = ((Array.IndexOf(alphabet, letter) + 3) % 26);
                    encryptedMessage[i] = alphabet[letterPosition];
                }
                else
                {
                    encryptedMessage[i] = secretMessage[i];
                }
            }
            // Print message
            string newMessage = string.Join("", encryptedMessage);
            Console.WriteLine(newMessage);
        }
    }
}