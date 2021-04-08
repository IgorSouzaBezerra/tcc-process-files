using ProcessFile.API.Providers.Interface;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ProcessFile.API.Providers.implementations
{
    public class Hash : IHash
    {
        public string GenerateHash(string password)
        {
            byte[] passwordByte = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(passwordByte);

            StringBuilder output = new StringBuilder(hash.Length);

            for (int i = 0; i < hash.Length; i++)
            {
                output.Append(hash[i].ToString("X2"));
            }

            return output.ToString();
        }

        public bool CompareHash(string password, string passwordHash)
        {
            bool equal = false;
            string newPassword = GenerateHash(password);

            if (newPassword.Length == passwordHash.Length)
            {
                int i = 0;
                while ((i < newPassword.Length) && (newPassword[i] == passwordHash[i]))
                {
                    i += 1;
                }
                if (i == newPassword.Length)
                {
                    equal = true;
                }

                if (equal)
                    return true;
                else
                    return false;
            }

            return false;
        }
    }
}
