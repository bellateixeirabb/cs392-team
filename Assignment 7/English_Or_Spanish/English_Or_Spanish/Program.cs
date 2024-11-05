using System;
using System.IO;
using Google.Cloud.Translation.V2;
using Google.Apis.Auth.OAuth2;
using System.Text;

namespace English_Or_Spanish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a translator object
            Translator translator = new Translator();
            //Ask for input
            Console.WriteLine("Please input the text to be translated:");
            //Read input
            string input = Console.ReadLine();
            //Translate
            string translatedText = translator.TranslateText(input);
            //Give output
            Console.WriteLine("Translated text: " + translatedText);
            //Keep console open
            Console.ReadLine();
        }
    }

    public class Translator
    {
        private TranslationClient client;

        public Translator()
        {
            // Specify the path to the credentials file for the API access
            string credentialsPath = Path.Combine(Directory.GetCurrentDirectory(), "Credentials", "google_credentials.json");

            // Load credentials directly from the JSON file
            var credential = GoogleCredential.FromFile("google_credentials.json");
            client = TranslationClient.Create(credential);
        }

        public string TranslateText(string text)
        {
            //Select the language to translate to (es = spanish)
            var response = client.TranslateText(text, "es");
            //Return translated text
            return response.TranslatedText;
        }
    }
}
