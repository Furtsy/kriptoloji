using System;
using System.Text;
using System.Security.Cryptography;

class SHA2 {
  public string Digest(string text, string functionValue) {
    byte[] bytes = Encoding.UTF8.GetBytes(text);
    using (var sha2 = SHA256.Create()) {
      byte[] hashBytes = sha2.ComputeHash(bytes);
      StringBuilder sb = new StringBuilder();
      foreach (byte b in hashBytes) {
        sb.Append(b.ToString("x2"));
      }
      return sb.ToString();
    }
  }
}

class Program {
  static void Main(string[] args) {
    string functionValue = "SHA-256";
    string plainText = "furtsy örnekekkk";
    Console.WriteLine($"Metnin şifrelenmemiş hali: {plainText}");
    SHA2 sha2Object = new SHA2();
    string digest = sha2Object.Digest(plainText, functionValue);
    Console.WriteLine($"Metnin SHA2 ile şifrelenmiş hali:\n{digest}");
  }
}
