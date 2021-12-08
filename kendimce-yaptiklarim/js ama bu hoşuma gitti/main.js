// Courtesy by Renato Mangini from Google:
// https://developers.google.com/web/updates/2012/06/How-to-convert-ArrayBuffer-to-and-from-String
function stringToArrayBuffer(str) {
    const buff = new ArrayBuffer(str.length*2) // Because there are 2 bytes for each char.
    const buffView = new Uint16Array(buff);
    for(let i = 0, strLen = str.length; i < strLen; i++) {
      buffView[i] = str.charCodeAt(i);
    }
    return buff;
  }
  
function arrayBufferToString(buff) {
    return String.fromCharCode.apply(null, new Uint16Array(buff));
  }

// See more examples here:
// https://github.com/diafygi/webcrypto-examples
async function generateKey() {

		const stringToEncrypt = 'https://localhost:3001';
    // https://github.com/diafygi/webcrypto-examples#rsa-oaep---generatekey
    // The resultant publicKey will be used to encrypt
    // and the privateKey will be used to decrypt. 
    // Note: This will generate new keys each time, you must store both of them in order for 
    // you to keep encrypting and decrypting.
    //
    // I warn you that storing them in the localStorage may be a bad idea, and it gets out of the scope
    // of this post. 
    const key = await crypto.subtle.generateKey({
      name: 'RSA-OAEP',
      modulusLength: 4096,
      publicExponent:  new Uint8Array([0x01, 0x00, 0x01]),
      hash: {name: 'SHA-512'},
      
    }, true,
    // This depends a lot on the algorithm used
    // Look down below https://auth0.com/docs/protocols/oauth2/redirect-users 
    // and see the table. Since we're using RSA-OAEP we have encrypt and decrypt
    // available
    ['encrypt', 'decrypt']);

    // key will yield a key.publicKey and key.privateKey property.

    const encryptedUri = await crypto.subtle.encrypt({
      name: 'RSA-OAEP'
    }, key.publicKey, stringToArrayBuffer(stringToEncrypt))
    
    const msg = await  crypto.subtle.decrypt({
      name: 'RSA-OAEP',
    }, key.privateKey, encryptedUri);

    
    console.log('The encrypted string is', encryptedUri);
    console.log('\n\n');
    console.log(`Derypted Uri is ${arrayBufferToString(msg)}`)
    
    }
    
    generateKey();
