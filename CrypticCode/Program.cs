using CrypticCode;

Encrypter e = new Encrypter();

string secret = e.Encrypt("THE quiCk BrownfOx jumpS OvEr The Lazy Dog?");

string answer = e.Decrypt(secret);

Console.WriteLine(
    $"String: THE quiCk BrownfOx jumpS OvEr The Lazy Dog?" +
    $"\n\nEncrypted: {secret}" +
    $"\n\nDecrypted: {answer}");

Console.ReadLine();