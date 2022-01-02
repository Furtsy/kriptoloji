import org.bouncycastle.jcajce.provider.digest.SHA3.DigestSHA3;
import org.bouncycastle.util.encoders.Hex;

public class SHA3 {
    public String digest(String text, int size) {
        DigestSHA3 digestObject = new DigestSHA3(size);
        try {
            digestObject.update(text.getBytes("UTF-8"));
        } catch (Exception e) {
            digestObject.update(text.getBytes());
        }
        byte[] digest = digestObject.digest();
        return Hex.toHexString(digest);
    }
}
