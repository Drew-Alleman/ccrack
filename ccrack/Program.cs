using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ccrack.Form1;
using System.Security.Cryptography;
using System.Text;
using System.IO;


namespace Encryption
{

    public class Encryptor
    {
        /*
        * Encrypts a string into a sha1 hash
        *
        * @param str String to Encrypt
        * @return computed hash
        */
        public static string Sha1(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2"))).ToLower();
        }

        /*
        * Encrypts a string into a Sha256 hash
        *
        * @param str String to Encrypt
        * @return computed hash
        */
        public static string Sha256(string input)
        {
            var hash = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2"))).ToLower();
        }

        /*
        * Encrypts a string into a Sha384 hash
        *
        * @param str String to Encrypt
        * @return computed hash
        */
        public static string Sha384(string input)
        {
            var hash = new SHA384Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2"))).ToLower();
        }
        /*
        * Encrypts a string into a Md5 hash
        *
        * @param str String to Encrypt
        * @return computed hash
        */
        public static string Md5(string input)
        {
            using (MD5 md5 =MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }

        /*
        * Encrypts a string into a Sha512 hash
        *
        * @param str String to Encrypt
        * @return computed hash
        */
        public static string Sha512(string input)
        {
            var hash = new SHA512Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2"))).ToLower();
        }

        /*
        * Encrypts a string into a hash using the provided encryption method
        *
        * @param word String to Encrypt
        * @param encryptionMethod  encryption method
        * @param input String to Encrypt 
        * @return Returns the computed hash
        */
        public static string Encrypt(string word, string encryptionMethod)
        {
            string result = "";
            switch (encryptionMethod)
            {
                case "SHA1":
                    result = Sha1(word);
                    break;
                case "SHA265":
                    result = Sha256(word);
                    break;
                case "SHA384":
                    result = Sha256(word);
                    break;
                case "SHA512":
                    result = Sha384(word);
                    break;
                case "MD5":
                    result = Md5(word);
                    break;
            }
            return result;
        }


        /*
        * Removes new lines and bytes'\r'
        * 
        * @param hashes Hashes to clean
        * @return Clean hash
        */
        public static string cleanHash(string hash)
        {
            string cleanedHash = string.Empty;
            string[] charsToRemove = { "\t", "\r", "\n"};
            foreach (var c in charsToRemove)
            {
                cleanedHash = hash.Replace(c, string.Empty);
            }
            return cleanedHash.Trim('\r');
        }


        public static string checkForMatches(string[] hashes, string computedHash, string line)
        {
            if (hashes.Contains(computedHash.ToLower()))
                return $"{computedHash}:{line}\r\n";
            return null;
        }

         /*
         * Iterates over each hash and removes '\r'
         * Cleaned hashes in an array
         * 
         * @param hashes Hashes to clean
         * @return Cleaned hashes in an array.
         */
        public string[] cleanHashes(string[] hashes) {
            for (int i = 0; i < hashes.Length; i++)
            {
                hashes[i] = cleanHash(hashes[i]);
            }

            return hashes;
        }


        /*
         * Iterates over each line in the wordlist and encrypts the data
         * When finished it writes the result to the output box
         * 
         * @param wordlist Wordlist file location
         * @param encryptionMethod Method of encryption e.g: SHA1
         * @param hashToCrack Hash to crack
         * @return correct password or a message informing the user that it was unable to be cracked. 
         */
        public void encryptLines(string wordlist, string encryptionMethod, string[] hashes)
        {
            foreach (var line in File.ReadLines(wordlist))
                {
                    string encryptedLine = Encrypt(line, encryptionMethod);
                    string result = checkForMatches(hashes, encryptedLine, line);
                    if (result != null)
                        form.writeToTextBox(result);
                }
            form.writeToTextBox("Completed!");
        }
    }
}


namespace ccrack {
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
