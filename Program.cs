using System;

namespace vscode_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var telegrapher = new Telegrapher();

            Console.WriteLine(telegrapher.SetMode(Telegrapher.Mode.AlphabeticalToMorse).Execute("HELLO WORLD"));
            Console.WriteLine(telegrapher.SetMode(Telegrapher.Mode.MorseToAlphabetical).Execute("1111 1 1011 1011 000 / 100 000 101 1011 011"));
        }
    }
}
