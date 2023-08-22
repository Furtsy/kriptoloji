const crypto = require('crypto');

class SHA3 {
  digest(text, size) {
    const digestObject = crypto.createHash(`sha3-${size}`);
    digestObject.update(text, 'utf8');
    return digestObject.digest('hex');
  }
}

const length = 256;
const plainText = 'Furtsy denemee';

console.log(`Metnin şifrelenmemiş hali: ${plainText}`);

const sha3Object = new SHA3();
const digest = sha3Object.digest(plainText, length);

console.log(`SHA3 ile şifrelenmiş hali:\n${digest}`);