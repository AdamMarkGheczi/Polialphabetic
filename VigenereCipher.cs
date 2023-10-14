namespace Vigenere
{
    internal class VigenereCipher
    {
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";

        public string Encrypt(string plainText, string key) => ShiftText(plainText, key, forward: true);
        public string Decrypt(string plainText, string key) => ShiftText(plainText, key, forward: false);

        private string ShiftText(string plainText, string key, bool forward) =>
            new string(plainText.Select((c, i) => Char.IsLetter(c) ? ShiftCharacter(c, key[i % key.Length], forward) : c).ToArray());

        private char ShiftCharacter(char baseChar, char shiftChar, bool forward)
        {
            string casedAlphabet = char.IsUpper(baseChar) ? alphabet.ToUpper() : alphabet;

            int shiftAmount = forward ? casedAlphabet.IndexOf(shiftChar) : -casedAlphabet.IndexOf(shiftChar);

            return casedAlphabet[(casedAlphabet.IndexOf(baseChar) + shiftAmount + casedAlphabet.Length) % casedAlphabet.Length];
        }
    }
}
