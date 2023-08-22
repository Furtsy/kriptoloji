const createKeccakHash = require('keccak');

const input = 'merhaba filan falan';

const hash = createKeccakHash('keccak256').update(input).digest('hex');

console.log('Metnin şifrelenmemiş hali:', input);
console.log('keccak256 ile şifrelenmiş hali:', hash);