using System;
using System.Text;
using Org.BouncyCastle.Crypto.Digests;

class SHA3 {
  public string Digest(string text, int size) {
    byte[] bytes = Encoding.UTF8.GetBytes(text);
    var sha3 = new Sha3Digest(size);
    sha3.BlockUpdate(bytes, 0, bytes.Length);
    byte[] hashBytes = new byte[sha3.GetDigestSize()];
    sha3.DoFinal(hashBytes, 0);
    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
  }
}

class Program {
  static void Main(string[] args) {
    int length = 256;
    string plainText = "Furtsy denemee";
    Console.WriteLine($"Metnin şifrelenmemiş hali: {plainText}");
    SHA3 sha3Object = new SHA3();
    string digest = sha3Object.Digest(plainText, length);
    Console.WriteLine($"SHA3 ile şifrelenmiş hali:\n{digest}");
  }
}