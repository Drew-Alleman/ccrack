using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;


namespace Encryption {

    public class Encryptor {
         /*
         * Encrypts a string into a sha1 hash
         *
         * @param str String to Encrypt
         * @return computed hash
         */
        public static string Sha1(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
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
            return string.Concat(hash.Select(b => b.ToString("x2")));
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
            return string.Concat(hash.Select(b => b.ToString("x2")));
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
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }

        /*
        * Encrypts a string into a hash using the provided encryption method
        *
        * @param input String to Encrypt
        * @param encryptionMethod  encryption method
        * @param input String to Encrypt 
        * @return Returns input if the hash was cracked else return null
        */
        public static string Encrypt(string input, string encryptionMethod, string hashToCrack)
        {
            string hash = "";
            if (encryptionMethod == "SHA1")
            {
                hash = Encryption.Encryptor.Sha1(input);
            }
            else if (encryptionMethod == "SHA256")
            {
                hash = Encryption.Encryptor.Sha256(input);
            }
            else if (encryptionMethod == "SHA384")
            {
                hash = Encryption.Encryptor.Sha384(input);
            }
            else if (encryptionMethod == "SHA512")
            {
                hash = Encryption.Encryptor.Sha384(input);
            }
            if (hashToCrack.Equals(hash))
            {
                return input;
            }
            return null;
        }
    }
}


namespace Utils
{
    public class Utilities {    
        /*
         * Iterates over each line in the wordlist and encrypts the data
         *
         * @param wordlist Wordlist file location
         * @param encryptionMethod Method of encryption e.g: SHA1
         * @param hashToCrack Hash to crack
         * @return correct password or null
         */
        public string HandleWordlistLines(string wordlist, string encryptionMethod, string hashToCrack) {
            foreach (string line in System.IO.File.ReadLines(wordlist))
            {
                var result = Encryption.Encryptor.Encrypt(line, encryptionMethod, hashToCrack);
                if (result != null) {
                    return result += "\r\n";
                }
            }
            return null;
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
