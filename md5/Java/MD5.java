import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
public class MD5 {
public String hash(String textToHash) {
	String digesText = null;
	try {
		MessageDigest md = MessageDigest.getInstance("MD5");
		byte[] bytes = md.digest(textToHash.getBytes());
		StringBuilder sb = new StringBuilder();
		for(int i = 0; i < bytes.length; i++)
			sb.append(Integer.toString((bytes[i] & 0xff) + 0x100, 16)
					.substring(1));
		digesText = sb.toString();
	} catch (NoSuchAlgorithmException e) {
		e.printStackTrace();
	}
	return digesText;
}

}
