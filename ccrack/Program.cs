using System;
using System.Linq;
using System.Windows.Forms;
using static ccrack.Form1;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ccrack;
using System.Threading;
using System.Diagnostics;

namespace Utils {

    class Utilities
    {

        /*
        * Iterates over each hash and removes '\r'
        * Cleaned hashes in an array
        * 
        * @param hashes Hashes to clean
        * @return Cleaned hashes in an array.
        */
        public static string[] cleanHashes(string[] hashes)
        {
            for (int i = 0; i < hashes.Length; i++)
            {
                hashes[i] = cleanHash(hashes[i]);
            }

            return hashes;
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
            string[] charsToRemove = { "\t", "\r", "\n" };
            foreach (var c in charsToRemove)
            {
                cleanedHash = hash.Replace(c, string.Empty);
            }
            return cleanedHash.Trim('\r');
        }


        public static List<int> CalculateThreadWorkCount(int lineCount, int threadCount)
        {
            //threadCount = threadCount + 1;
            List<int> parts = new List<int>();
            if (lineCount % threadCount == 0)
            {
                for (int i = 0; i < threadCount; i++)
                    parts.Add(lineCount / threadCount);

            }
            else
            {
                int zp = threadCount - (lineCount % threadCount);
                int pp = lineCount / threadCount;
                for (int i = 0; i < threadCount; i++)
                {

                    if (i >= zp)
                        parts.Add(pp + 1);
                    else
                        parts.Add(pp);
                }
            }
            return parts;
        }

        public static List<string> StreamReadlines(string filename)
        {
            List<string> text = new List<string>();
            FileInfo fi1 = new FileInfo(filename);
            using (StreamReader sr = fi1.OpenText())
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    text.Add(s);
                }
            }
            return text;
        }


        public static List<int> CalculateIndex(List<int> count, int threadCount)
        {
            List<int> work = new List<int>();
            work.Add(0);
            for (int i = 1; i < threadCount; i++)
            {
                int sum = count[i] + work[i - 1];
                work.Add(sum);
            }
            return work;
        }
    }
}

namespace Encryption
{

    public class Encryptor
    {
        /* Sha1(input)
        * Encrypts a string into a Sha1 hash
        *
        * @param input              String to encrypt
        * 
        * @return                   Computed hash
        */
        public static string Sha1(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2"))).ToLower();
        }

        /* Sha256(input)
        * Encrypts a string into a Sha256 hash
        *
        * @param input              String to encrypt
        * 
        * @return                   Computed hash
        */
        public static string Sha256(string input)
        {
            var hash = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2"))).ToLower();
        }

        /* Sha384(input)
        * Encrypts a string into a Sha384 hash
        *
        * @param input              String to encrypt
        * 
        * @return                   Computed hash
        */
        public static string Sha384(string input)
        {
            var hash = new SHA384Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2"))).ToLower();
        }


        /* Md5(input)
        * Encrypts a string into a Md5 hash
        *
        * @param input              String to encrypt
        * 
        * @return                   Computed hash
        */
        public static string Md5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }


        /* Sha512(input)
        * Encrypts a string into a Sha512 hash
        *
        * @param input              String to encrypt
        * 
        * @return                   Computed hash
        */
        public static string Sha512(string input)
        {
            var hash = new SHA512Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2"))).ToLower();
        }

        /* Encrypt(word, encryptionMethod)
        * Encrypts a string into a hash using the provided encryption method
        *
        * @param word              Word to encrypt
        * @param encryptionMethod  encryption method E.g SHA1
        * 
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

        /* checkForMatches(hashes, computedHash, line)
         * Splits the wordlist words into N parts (threadCount). 
         * Creates threads to handle each part of the wordlist
         * 
         * @param hashes              Hashes to crack
         * @param line                Original word from textfile
         * @param computedHash        Line as a Computed hash from Encrypt()
         * 
         * @return                    NULL if the password was not found otherwise text informing the user the 
         *                            hash was cracked.
         */
        public static string checkForMatches(List<string> hashes, string line, string computedHash)
        {
            if (hashes.Contains(computedHash.ToLower()))
                return $"{computedHash}:{line}\r\n";
            return null;
        }

        /* CreateEncryptionThreads(wordlist, encryptionMethod, hashes, threadCount)
         * Splits the wordlist words into N parts (threadCount). 
         * Creates threads to handle each part of the wordlist
         * 
         * @param wordlist            Wordlist file location
         * @param encryptionMethod    Method of encryption e.g: SHA1
         * @param hashes              Hashes to crack
         */
        static public void CreateEncryptionThreads(string wordlist, string encryptionMethod, List<String> hashes, int threadCount)
        {

            List<string> words = Utils.Utilities.StreamReadlines(wordlist);
            List<int> parts = Utils.Utilities.CalculateThreadWorkCount(words.Count(), threadCount);
            List<int> indexs = Utils.Utilities.CalculateIndex(parts, threadCount);

            indexs[threadCount - 1] = indexs[threadCount - 1] - 1;
            
            var procTime = DateTime.Now - Process.GetCurrentProcess().StartTime;
            var procTimeInSec = procTime.Seconds;

            for (int i = 0; i < threadCount; i++)
            {
                int index = indexs[i];
                int count = parts[i];
                List<string> part = words.GetRange(index, count);
                Thread t = new Thread(new ThreadStart(() => ThreadEncrypt(part, hashes, encryptionMethod)));
                t.Start();
            }
            form.writeToLogBox(string.Format("Finished in {0} seconds\r\n", procTimeInSec));
        }


        /* ThreadEncrypt(part, hashes, encryptionMethod)
         * Iterates over each line in the part of the wordlist it was assigned.
         * If the result is not NULL it writes it to the output box.
         * 
         * @param part                List of strings the thread is assigned to handle
         * @param hashes              Hashes to crack
         * @param encryptionMethod    Method of encryption e.g: SHA1
         */
        public static void ThreadEncrypt(List<String> part, List<String> hashes, string encryptionMethod)
        {
            foreach (string line in part)
            {
                string encryptedLine = Encrypt(line, encryptionMethod);
                string result = checkForMatches(hashes, line, encryptedLine);
                if (result != null)
                    form.writeToOutputBox(result);
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
}
