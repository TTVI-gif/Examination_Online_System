using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Text;

namespace ExaminationOnlineSystem.HashPBKDF2
{
    public class Hash
    {
        public static string HashPassWord(string password, string salt)
        {
            var valueBytes = KeyDerivation.Pbkdf2(password: password,
                salt: Encoding.UTF8.GetBytes(salt),
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 10000,
                numBytesRequested: 256 / 8);
            return Convert.ToBase64String(valueBytes);
        }

        public static bool Validate(string value, string salt, string hash)
     => HashPassWord(value, salt) == hash;
    }


}
