using System;

class Program
{
    static void Main(string[] args)
    {
        // polybius dama tablosu(?) veya listesi(?)
        char[,] polybiusTable = new char[,]
        {
            {'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g'},
            {'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm'},
            {'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't'},
            {'u', 'ü', 'v', 'y', 'z', 'q', 'w', 'x'}
        };

        // şifrelenmesini istediğimiz metin
        string plaintext = "s";

        // polybius şifreleme kullanarak şifrelemeyi yapıyoruz burda
        string encryptedText = PolybiusEncrypt(plaintext, polybiusTable);
        Console.WriteLine("Şifrelenmiş Metin: " + encryptedText);

        //şifreyi çözmeye yarar
        string decryptedText = PolybiusDecrypt(encryptedText, polybiusTable);
        Console.WriteLine("Çözülmüş Metin: " + decryptedText);
    }

    // polybius şifreleme yöntemi kullanarak şifreler
    static string PolybiusEncrypt(string input, char[,] table)
    {
        input = input.ToLower();
        string encryptedText = "";

        foreach (char c in input) //harf harf dedğimiz
        {
            bool found = false;

            for (int i = 0; i < table.GetLength(0); i++) //tablo(?) dama tablosunun satırlarını dolaşmak için döngü 
            {
                for (int j = 0; j < table.GetLength(1); j++) //buda sütunlarını dolaşmak için döngü
                {
                    if (table[i, j] == c)//eğer tablo(?) dakine eşitse encryptedText a ekliyor 
                    {
                        encryptedText += (i + 1).ToString() + (j + 1).ToString();
                        found = true;
                        break;
                    }
                }

                if (found)
                    break;
            }

            if (!found && c == ' ') //yoksa veya boşluk ise boşluk eklemektedir burasıda
            {
                encryptedText += " ";
            }
        }

        return encryptedText;
    }

    //şifreyi çözmeyi yarar bura
    static string PolybiusDecrypt(string input, char[,] table)
    {
        string decryptedText = "";

        for (int i = 0; i < input.Length; i += 2)
        {
            if (input[i] == ' ')
            {
                decryptedText += " ";
                i--;
            }
            else
            {
                int row = int.Parse(input[i].ToString()) - 1;
                int col = int.Parse(input[i + 1].ToString()) - 1;
                decryptedText += table[row, col];
            }
        }

        return decryptedText;
    }
}
//evet