using System.IO.Compression;
using System.Security.Cryptography;

namespace PasswordGeneratorApi.Wordlist
{
    public static class WordGenerator
    {
        private static readonly string wordListZipPath = "Wordlist/words.zip";
        private static readonly string wordListFileName = "words.txt";

        private static readonly string Symbols = "!@#$%-_.,&* ";
        private static readonly string[] Words = LoadZip();

        public static char GetSymbol() => Symbols[GenerateRandomNumber(0, Symbols.Length - 1)];

        public static string GetWord() => Words[GenerateRandomNumber(0, Words.Length - 1)];

        public static int GetNumber() => GenerateRandomNumber(0, 9);

        private static int GenerateRandomNumber(int min, int max) => RandomNumberGenerator.GetInt32(min, max + 1);

        private static string[] LoadZip()
        {
            using (ZipArchive archive = ZipFile.OpenRead(wordListZipPath))
            {
                var entry = archive.GetEntry(wordListFileName);
                if (entry == null)
                    throw new FileNotFoundException("Wordlist not found or not accessible.");

                using (var reader = new StreamReader(entry.Open()))
                {
                    return reader.ReadToEnd().Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                }
            }
        }
    }
}
