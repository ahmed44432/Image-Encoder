using System;
using System.IO;
using System.Security.Cryptography;



namespace SimpleCrypt
{
    public class ImageCrypt
    {
        public string InputFile     {get;set;}
        public string Key {get;set;}

        byte[] IV;


        public ImageCrypt()
        {
            InputFile = "";
            Key = "";
            using (Aes aesAlg = Aes.Create()) { IV = aesAlg.IV; }
        }

        public ImageCrypt(string inputFile , string key)
        {
            InputFile = inputFile;
            Key = key;
            using (Aes aesAlg = Aes.Create()){IV = aesAlg.IV;}
        }


        public bool EncryptFile(string EncryptedFile)
        {
            bool worked = false;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(Key);
                aesAlg.IV = IV;


                using (FileStream fsInput = new FileStream(InputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(EncryptedFile, FileMode.Create))
                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                {
                    // Write the IV to the beginning of the file
                    fsOutput.Write(IV, 0, IV.Length);
                    fsInput.CopyTo(cryptoStream);
                    worked = true;
                }
            }
            return worked;
        }


        public bool DecryptFile(string DecryptedFile)
        {
            bool worked = false;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(Key);
                //aesAlg.IV = IV;

                using (FileStream fsInput = new FileStream(InputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(DecryptedFile, FileMode.Create))
                {

                    byte[] storedIV = new byte[16];
                    fsInput.Read(storedIV, 0, storedIV.Length);
                    aesAlg.IV = storedIV;

                    using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                    using (CryptoStream cryptoStream = new CryptoStream(fsOutput, decryptor, CryptoStreamMode.Write))
                    {
                        // Skip the IV at the beginning of the file
                        fsInput.Seek(IV.Length, SeekOrigin.Begin);
                        fsInput.CopyTo(cryptoStream);
                        worked = true;
                    }
                }
            }
            return worked;
        }


        public static string GenerateKey16()
        {
            byte[] key = new byte[8];
            RandomNumberGenerator.Fill(key);

            return Convert.ToHexString(key);
        }







    }


}
