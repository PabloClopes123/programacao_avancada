// Pesquisa em uma String
const text = "A quick brown fox jumps over the lazy dog";
const pattern = /brown/;
const result = text.match(pattern);
console.log(result); // ["brown"]

// Substituição de uma String
const text2 = "A quick brown fox jumps over the lazy dog";
const pattern2 = /brown/;
const replacement = "red";
const result2 = text2.replace(pattern2, replacement);
console.log(result2); // "A quick red fox jumps over the lazy dog"

// Validação de uma String
const email = "example@example.com";
const emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
const isValidEmail = emailPattern.test(email);
console.log(isValidEmail); // true

// Extração de Substrings
const text3 = "Data de nascimento: 1990-12-25";
const datePattern = /(\d{4}-\d{2}-\d{2})/;
const result3 = text3.match(datePattern);
console.log(result3[1]); // "1990-12-25"

// Pesquisa global com múltiplas correspondências
const text4 = "A rápida raposa marrom pula sobre o cão preguiçoso.";
const pattern4 = /r\w+/g;
const result4 = text4.match(pattern4);
console.log(result4); // ["rápida", "raposa", "marrom"]
