using System;

namespace MorseCode
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EnglishToMorse aline = new EnglishToMorse();
            aline.E2M("Hello everyone");
            EnglishToMorse aline1 = new EnglishToMorse();
            aline1.E2M("How are you doing? :D ");
        }
    }
}