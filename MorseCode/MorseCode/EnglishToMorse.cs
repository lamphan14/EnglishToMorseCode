using System.Collections.Generic;
using System;
namespace MorseCode
{
    class EnglishToMorse
    {
        private string Text;
        public EnglishToMorse() { }
        public EnglishToMorse(string text)
        {

            this.Text = text;

        }
        public void SetText(string text)
        {
            this.Text = text;
        }
        public string GetText()
        {
            return Text;
        }
  


        public void E2M(string text)
        { //add morse code to the dictionary
        //char -> morse &&  number ->morse
        var dictionary = new Dictionary<string, string>();
        //null -> null
        dictionary.Add(" ", " ");
            //char -> morse
            dictionary.Add("A", ".-");
            dictionary.Add("B", "-...");
            dictionary.Add("C", "-.-.");
            dictionary.Add("D", "-..");
            dictionary.Add("E", ".");
            dictionary.Add("F", "..-.");
            dictionary.Add("G", "--.");
            dictionary.Add("H", "....");
            dictionary.Add("I", "..");
            dictionary.Add("J", ".---");
            dictionary.Add("K", "-.-");
            dictionary.Add("L", ".-..");
            dictionary.Add("M", "--");
            dictionary.Add("N", "-.");
            dictionary.Add("O", "---");
            dictionary.Add("P", ".--.");
            dictionary.Add("Q", "--.-");
            dictionary.Add("R", ".-.");
            dictionary.Add("S", "...");
            dictionary.Add("T", "-");
            dictionary.Add("U", "..-");
            dictionary.Add("V", "...-");
            dictionary.Add("W", ".--");
            dictionary.Add("X", "-..-");
            dictionary.Add("Y", "-.--");
            dictionary.Add("Z", "--..");
            //number->morse
            dictionary.Add("1", ".----");
            dictionary.Add("2", "..---");
            dictionary.Add("3", "...--");
            dictionary.Add("4", "....-");
            dictionary.Add("5", ".....");
            dictionary.Add("6", "-....");
            dictionary.Add("7", "--...");
            dictionary.Add("8", "---..");
            dictionary.Add("9", "----.");
            dictionary.Add("0", "-----");
            //special character to morse
            dictionary.Add("?", "..--.."); //question mark
            dictionary.Add("!", "-.-.--"); //exclamation
            dictionary.Add(".", ".-.-.-"); //a period or a full stop
            dictionary.Add(",", "--..--"); // comma
            dictionary.Add(":", "---..."); //colon
            dictionary.Add(";", "-.-.-."); //semicolon
            dictionary.Add("-", "-....-"); //hyphen
            dictionary.Add("'", ".----.");//Apostrophe
            dictionary.Add("/", "-..-.");//fraction bar or a slash
            dictionary.Add("@", ".--.-."); //at sign
            dictionary.Add("=", "-...-"); //equal sign
            dictionary.Add(" \" " , "-...-");//Quotation marks
            dictionary.Add("_", "..__._"); //underline


            try
            {
                Console.WriteLine($"text: {text}");
                var morse = string.Empty;
                foreach (var c in text)
                {
                    morse += dictionary[c.ToString().ToUpper()] + " ";
                }
                Console.WriteLine($"morse: {morse}");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("One or more characters you entered is not in Morse dictionary!");
            }


        }

        ~EnglishToMorse() {}

    }
}
