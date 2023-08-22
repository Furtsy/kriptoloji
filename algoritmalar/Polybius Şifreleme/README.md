# Polybius Şifreleme

Polybius tablosu veya dama tahtası(?), harf ve sembollerin isteğe göre eklenip çıkartılabilen, satır ve sütunlardan oluşan bir şifreleme tablosudur. Harfler, tablodaki satır ve sütun koordinatlarına dönüştürülerek şifrelenir. 

## Kullanım

Tablosu  şu şekildedir:

|   | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 |
|---|---|---|---|---|---|---|---|---|
| 1 | a | b | c | ç | d | e | f | g |
| 2 | ğ | h | ı | i | j | k | l | m |
| 3 | n | o | ö | p | r | s | ş | t |
| 4 | u | ü | v | y | z | q | w | x |

Yukarda yazıldığı gibi her harfin bulunduğu satıra ve sütundaki değerler birleştirilip iki basamaklı bir sayı elde edilir.

Kısa örnek vermek gerekirse, "s" harfi 3. satır, 5. sütunda olduğu için "36" şeklinde yazılır.
Cümleli örnek vermek gerekirse, "merhaba ben falan filan" metni şifrelenirse "28163522111211 121631 1711271131 1724271131" şeklinde olur.

C# ile yazdığım bu algoritmaya örnek olabilecek kodu bu dizine koyacağım.
