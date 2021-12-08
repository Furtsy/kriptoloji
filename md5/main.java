public class main {

	public static void main(String[] args) {
		String plainText = "furtsy örnek";
		System.out.println("Şifrelenmemiş Hali: " + plainText);
		MD5 md5Object = new MD5();
		String digesText = md5Object.hash(plainText);
		System.out.println("MD5 ile şifrelenmiş hali: " + digesText);
	}

}
