using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;


namespace Email_Auth.BLL.hash
{
    class HashFunction
    {


        public static byte[] GetSecretKey()
        {
            byte[] secretkey = new Byte[64];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(secretkey);
                return secretkey;

            }

        }


        public static string ToHexString(byte[] array)
        {
            StringBuilder hex = new StringBuilder(array.Length * 2);
            foreach (byte b in array)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        public static string Hash(string df, byte[] secretkey)
        {
            string dataFile;
            string signedFile;
            //If no file names are specified, create them.
              dataFile = df;
                signedFile = @"D:signedFile.txt";

                if (!File.Exists(dataFile))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(dataFile))
                    {
                        sw.WriteLine("Here is a message to sign");
                    }
                }
                
            try
            {


                // Use the secret key to sign the message file.
                string HashHexBased;

                   HashHexBased =  SignFile(secretkey, dataFile, signedFile);

                    // Verify the signed file
                    VerifyFile(secretkey, signedFile);


                return HashHexBased;
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: File not found", e);
            }

            return "";
        }


        public static string SignFile(byte[] key, String sourceFile, String destFile)
        {
            // Initialize the keyed hash object.
            //  SHA265 + KEY ==> Message authintication code 


            using (HMACSHA256 hmac = new HMACSHA256(key))
            {
                using (FileStream inStream = new FileStream(sourceFile, FileMode.Open))
                {
                    using (FileStream outStream = new FileStream(destFile, FileMode.Create))
                    {
                        // Compute the hash of the input file.
                        byte[] hashValue = hmac.ComputeHash(inStream);
                        // Reset inStream to the beginning of the file.
                        inStream.Position = 0;
                        // Write the computed hash value to the output file.
                        // string HashHexBased = ToHexString(hashValue);

                        
                        outStream.Write(Encoding.ASCII.GetBytes(ToHexString(hashValue)), 0, hashValue.Length);
                        // Copy the contents of the sourceFile to the destFile.
                        int bytesRead;
                        // read 1K at a time
                        byte[] buffer = new byte[1024];
                        do
                        {
                            // Read from the wrapping CryptoStream.
                            bytesRead = inStream.Read(buffer, 0, 1024);
                            outStream.Write(buffer, 0, bytesRead);
                        } while (bytesRead > 0);

                        return ToHexString(hashValue);
                    }
                }
            }
         }

        public static bool VerifyFile(byte[] key, String sourceFile)
        {
            bool err = false;
            // Initialize the keyed hash object.
            using (HMACSHA256 hmac = new HMACSHA256(key))
            {
                // Create an array to hold the keyed hash value read from the file.
                byte[] storedHash = new byte[hmac.HashSize / 8];
                // Create a FileStream for the source file.
                using (FileStream inStream = new FileStream(sourceFile, FileMode.Open))
                {
                    // Read in the storedHash.
                    inStream.Read(storedHash, 0, storedHash.Length);
                    // Compute the hash of the remaining contents of the file.
                    // The stream is properly positioned at the beginning of the content,
                    // immediately after the stored hash value.
                    byte[] computedHash = hmac.ComputeHash(inStream);
                    // compare the computed hash with the stored value

                    for (int i = 0; i < storedHash.Length; i++)
                    {
                        if (computedHash[i] != storedHash[i])
                        {
                            err = true;
                        }
                    }
                }
            }
            if (err)
            {
                Console.WriteLine("Hash values differ! Signed file has been tampered with!");
                return false;
            }
            else
            {
                Console.WriteLine("Hash values agree -- no tampering occurred.");
                return true;
            }
        }


       



    }


}
