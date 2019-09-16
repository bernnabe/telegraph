using System;
using System.Collections.Generic;
using System.Linq;

namespace vscode_lab
{
    public static class Telegraph
    {
        private static Dictionary<char, string> _AlphabetMap = null;
        public static bool Initilized => _AlphabetMap?.Count > 0;

        static Telegraph()
        {
            _AlphabetMap = new Dictionary<char, string>();
        }
        public static void Initilize()
        {
            Console.WriteLine("Initializing Telegraph...");

            _AlphabetMap.Add('A', ".-");
            _AlphabetMap.Add('B', "-...");
            _AlphabetMap.Add('C', "-.-.");
            _AlphabetMap.Add('D', "-..");
            _AlphabetMap.Add('E', ".");
            _AlphabetMap.Add('F', "..-.");
            _AlphabetMap.Add('G', "--.");
            _AlphabetMap.Add('H', "....");
            _AlphabetMap.Add('I', "..");
            _AlphabetMap.Add('J', ".---");
            _AlphabetMap.Add('K', "-.-");
            _AlphabetMap.Add('L', ".-..");
            _AlphabetMap.Add('M', "--");
            _AlphabetMap.Add('N', "-.");
            _AlphabetMap.Add('O', "---");
            _AlphabetMap.Add('P', ".--.");
            _AlphabetMap.Add('Q', "--.-");
            _AlphabetMap.Add('R', ".-.");
            _AlphabetMap.Add('S', "...");
            _AlphabetMap.Add('T', "-");
            _AlphabetMap.Add('U', "..-");
            _AlphabetMap.Add('V', "...-");
            _AlphabetMap.Add('W', ".--");
            _AlphabetMap.Add('X', "-..-");
            _AlphabetMap.Add('Y', "-.--");
            _AlphabetMap.Add('Z', "--..");

            _AlphabetMap.Add('0', "-----");
            _AlphabetMap.Add('1', ".----");
            _AlphabetMap.Add('2', "..---");
            _AlphabetMap.Add('3', "...--");
            _AlphabetMap.Add('4', "....-");
            _AlphabetMap.Add('5', ".....");
            _AlphabetMap.Add('6', "-....");
            _AlphabetMap.Add('7', "--...");
            _AlphabetMap.Add('8', "---..");
            _AlphabetMap.Add('9', "----.");

            Console.WriteLine("Telegraph has been intialized.");
        }

        public static string MapToMorseCharacter(char alphabeticalLetter)
        {
            if (!Initilized) throw new InvalidOperationException("Telegraph has not been initialized");

            foreach (var map in _AlphabetMap)
            {
                if (map.Key.Equals(alphabeticalLetter))
                    return map.Value;
            }

            throw new InvalidOperationException("The Telegraph doesn't contains value");
        }

        public static char MapToAlphabeticalCharacter(string morseCode)
        {
            if (!Initilized) throw new InvalidOperationException("Telegraph has not been initialized");

            foreach (var map in _AlphabetMap)
            {
                if (map.Value.Equals(morseCode))
                    return map.Key;
            }

            throw new InvalidOperationException("The Telegraph doesn't contains value");
        }
    }
}