public class main {

    public static void main(String[] args) {
        int length = 256;
        String plainText = "Furtsy denemee";
        System.out.println("Şifrelenmemiş hali: " + plainText);
        SHA3 sha3Object = new SHA3();
        String digest = sha3Object.digest(plainText, length);
        System.out.println("SHA3 ile şifrelenmiş hali: \n" + digest);
    }
}
