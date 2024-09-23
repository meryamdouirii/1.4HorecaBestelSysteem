using Model.Password;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Service
{
    public class PasswordService
    {
        PasswordWithSaltHasher pwHasher;

        public PasswordService()
        {   
            pwHasher = new PasswordWithSaltHasher();
        }

        public HashWithSaltResult MakeHashandSalt(string password)
        {
            HashWithSaltResult result = pwHasher.HashWithSalt(password, 64, SHA256.Create());
            return result;
        }

        public bool VerifyPassword(string password, string salt, string hash)
        {
            return pwHasher.VerifyPassword(password, salt, hash, SHA256.Create());
        }
    }
}
