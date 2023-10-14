namespace Vigenere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VigenereCipher vigenere = new VigenereCipher();

            string text = "This is some sample text";
            string key = "vigenere";

            string encrypted = vigenere.Encrypt(text, key);
            string decrypted = vigenere.Decrypt(encrypted, key);

            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"Key: {key}");
            Console.WriteLine($"Encrypted: {encrypted}");
            Console.WriteLine($"Decrypted: {decrypted}");
        }
    }
}