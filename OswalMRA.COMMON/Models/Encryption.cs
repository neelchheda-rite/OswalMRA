using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.COMMON.Models {
    public class Encryption {
        #region Static Member Variables
        static byte[] _keyBytes = Encoding.ASCII.GetBytes("}n`=|,^#H%~<8g(@");
        static byte[] _initVectorBytes = Encoding.ASCII.GetBytes("+~*w>/c$@0!^m&]Z");
        #endregion
        // Encrypt a password using AES encryption
        public static bool EncryptText(string sPlainText, ref string sEncryptedText)
        {
            //Declare and initialze the boolean return variable as false
            bool bReturn = false;

            //Set encrypted text variable as blank
            sEncryptedText = "";

            try
            {
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(sPlainText);

                // Create Rijndael encryption object and set encryption mode to Cipher Block Chaining (CBC)
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;

                // Generate encryptor from the existing key bytes and initialization vector
                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(_keyBytes, _initVectorBytes);

                // Define memory stream which will be used to hold encrypted data.
                MemoryStream memoryStream = new MemoryStream();

                // Define cryptographic stream (always use Write mode for encryption).
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

                // Start encrypting.
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

                // Finish encrypting.
                cryptoStream.FlushFinalBlock();

                // Convert encrypted data from a memory stream into a byte array.
                byte[] cipherTextBytes = memoryStream.ToArray();

                // Close both streams.
                memoryStream.Close();
                cryptoStream.Close();

                // Convert encrypted data into a base64-encoded string and assign it to specified variable
                sEncryptedText = Convert.ToBase64String(cipherTextBytes);

                // Set the boolean return variable to true
                bReturn = true;
            }
            catch (Exception ex)
            {
                // Set the boolean return variable to false
                bReturn = false;

                // Assign exception details to the encrypted string variable
                sEncryptedText = "Exception in Encryption.EncryptText(): " + ex.Message + Environment.NewLine + "Details: " + ex.ToString();
            }

            return bReturn;
        }

        // Decrypt an encrypted password
        public static bool DecryptText(string sEncryptedText, ref string sPlainText)
        {
            //Declare and initialze the boolean return variable as false
            bool bReturn = false;

            //Set decrypted text variable as blank
            sPlainText = "";
            if (string.IsNullOrWhiteSpace(sEncryptedText))
                return bReturn;
            try
            {
                byte[] cipherTextBytes = Convert.FromBase64String(sEncryptedText);

                // Create Rijndael encryption object and set encryption mode to Cipher Block Chaining (CBC)
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;

                // Generate decryptor from the existing key bytes and initialization vector
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(_keyBytes, _initVectorBytes);

                // Define memory stream which will be used to hold decrypted data.
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

                // Define cryptographic stream (always use Read mode for decryption).
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

                // Since at this point we don't know what the size of decrypted data will be, allocate the buffer long enough to hold ciphertext;
                // plaintext is never longer than ciphertext
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];

                // Start decrypting.
                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

                // Close both streams.
                memoryStream.Close();
                cryptoStream.Close();

                // Convert decrypted data into a string and assign it to specified variable
                sPlainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);

                // Set the boolean return variable to true
                bReturn = true;
            }
            catch (Exception ex)
            {
                // Set the boolean return variable to false
                bReturn = false;

                // Assign exception details to the decrypted string variable
                sPlainText = "Exception in Encryption.DecryptText(): " + ex.Message + Environment.NewLine + "Details: " + ex.ToString();
            }

            return bReturn;
        }
    }
}
