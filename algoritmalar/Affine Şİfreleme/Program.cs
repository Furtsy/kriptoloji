using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, int> characterToNumber = new Dictionary<char, int>
    {
        { 'a', 0 },
        { 'b', 1 },
        { 'c', 2 },
        { 'ç', 3 },
        { 'd', 4 },
        { 'e', 5 },
        { 'f', 6 },
        { 'g', 7 },
        { 'ğ', 8 },
        { 'h', 9 },
        { 'ı', 10 },
        { 'i', 11 },
        { 'j', 12 },
        { 'k', 13 },
        { 'l', 14 },
        { 'm', 15 },
        { 'n', 16 },
        { 'o', 17 },
        { 'ö', 18 },
        { 'p', 19 },
        { 'q', 20 },
        { 'r', 21 },
        { 's', 22 },
        { 'ş', 23 },
        { 't', 24 },
        { 'u', 25 },
        { 'ü', 26 },
        { 'v', 27 },
        { 'w', 28 },
        { 'x', 29 },
        { 'y', 30 },
        { 'z', 31 }
    };

    static Dictionary<int, char> numberToCharacter = new Dictionary<int, char>();

    static int ModInverse(int a, int m)
    {
        for (int x = 1; x < m; x++)
        {
            if ((a * x) % m == 1)
                return x;
        }
        return -1;
    }

    static string Encrypt(string plainText, int a, int b, int modc)
    {
        string encryptedText = "";

        foreach (char c in plainText)
        {
            if (characterToNumber.ContainsKey(c))
            {
                int x = characterToNumber[c];
                int y = (a * x + b) % modc;
                encryptedText += numberToCharacter[y];
            }
            else
            {
                encryptedText += c;
            }
        }

        return encryptedText;
    }

    static string Decrypt(string encryptedText, int a, int b, int modc)
    {
        int aInverse = ModInverse(a, modc);
        string decryptedText = "";

        foreach (char ch in encryptedText)
        {
            if (characterToNumber.ContainsKey(ch))
            {
                int y = characterToNumber[ch];
                int x = (aInverse * (y - b + modc)) % modc;
                decryptedText += numberToCharacter[(x + modc) % modc];
            }
            else
            {
                decryptedText += ch;
            }
        }

        return decryptedText;
    }

    static void Main(string[] args)
    {
        foreach (var kvp in characterToNumber)
        {
            numberToCharacter[kvp.Value] = kvp.Key;
        }

        int a = 7;
        int b = 3;
        int modc = 32;

        string Text = "merhaba falan filan";
        string encryptedText = Encrypt(Text, a, b, modc);
        string decryptedText = Decrypt(encryptedText, a, b, modc);

        Console.WriteLine("Metnin şifrelenmemiş hali: " + Text); //merhaba falan filan
        Console.WriteLine("Şifrelenmiş hali: " + encryptedText); //jfscçıç kçeçp kneçp
        Console.WriteLine("Şifre çözülmüş hali: " + decryptedText); //merhaba falan filan
    }
}
//evet