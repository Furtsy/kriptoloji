public class main {

	public static void main(String[] args) {
		String plainText = "furtsy örnek";
		System.out.println("Şifrelenmemiş Hali: " + plainText);
		SHA1 sha1Object = new SHA1();
		String digesText = sha1Object.hash(plainText);
		System.out.println("SHA1 ile şifrelenmiş hali: " + digesText);
	}

}
