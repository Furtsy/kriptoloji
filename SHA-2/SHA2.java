import java.security.MessageDigest;

import org.bouncycastle.util.encoders.Hex;

public class SHA2 {
  public String digest(String text, String functionValue) {
    MessageDigest digestObject = null;
    try {
      digestObject = MessageDigest.getInstance(functionValue);
      digestObject.update(text.getBytes("UTF-8"));
    } catch (Exception e) {
      digestObject.update(text.getBytes());
    }
    byte[] digest = digestObject.digest();
    return Hex.toHexString(digest);
  }

}
