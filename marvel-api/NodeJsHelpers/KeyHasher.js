/*
Authentication for Server-Side Applications
Server-side applications must pass two parameters in addition to the apikey parameter:

ts - a timestamp (or other long string which can change on a request-by-request basis)
hash - a md5 digest of the ts parameter, your private key and your public key (e.g. md5(ts+privateKey+publicKey)
For example, a user with a public key of "1234" and a private key of "abcd" could construct a 
valid call as follows: http://gateway.marvel.com/v1/public/comics?ts=1&apikey=1234&hash=ffd275c5130566a2916217b101f26150 
(the hash value is the md5 digest of 1abcd1234)

*/

const crypto = require('crypto');
// Generate ISO 8601 timestamp
//iso string -> a standardised description of a date that a computer understands
const timestamp = new Date().toISOString();

// Add to URL

console.log("timestamp: " + timestamp);

const apiKey = timestamp + 'private+public';

// Generate MD5 hash
//md5 -> encryption algorithm
const md5Hash = crypto.createHash('md5').update(apiKey).digest('hex');

console.log("hash: " + md5Hash);