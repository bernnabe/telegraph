using System;

namespace vscode_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var telegrapher = new Telegrapher();

            Console.WriteLine(telegrapher.SetMode(Telegrapher.Mode.AlphabeticalToMorse).Execute("HELLO WORLD"));
            Console.WriteLine(telegrapher.SetMode(Telegrapher.Mode.MorseToAlphabetical).Execute(".... . .-.. .-.. --- / .-- --- .-. .-.. -.."));
        }
    }
}
