using System;

namespace CharacterEscapeSequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(\a + \b + \f + \n + \r + \t + \v + \0 + \' + \" + \\);
        }
    }
}
