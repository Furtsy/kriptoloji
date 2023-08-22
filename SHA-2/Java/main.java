public class main {

	public static void main(String[] args) {
		String functionValue = "SHA-256";
		String plainText = "furtsy örnekekkk";
		System.out.println("Metnin şifrelenmemiş hali: " + plainText);
		SHA2 sha2Object = new SHA2();
		String digest = sha2Object.digest(plainText, functionValue);
		System.out.println("Metnin SHA2 ile şifrelenmiş hali: \n" + digest);
	}

}
