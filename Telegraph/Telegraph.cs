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

            _AlphabetMap.Add('A', "10");
            _AlphabetMap.Add('B', "0111");
            _AlphabetMap.Add('C', "0101");
            _AlphabetMap.Add('D', "011");
            _AlphabetMap.Add('E', "1");
            _AlphabetMap.Add('F', "1101");
            _AlphabetMap.Add('G', "001");
            _AlphabetMap.Add('H', "1111");
            _AlphabetMap.Add('I', "11");
            _AlphabetMap.Add('J', "1000");
            _AlphabetMap.Add('K', "1000");
            _AlphabetMap.Add('L', "1011");
            _AlphabetMap.Add('M', "00");
            _AlphabetMap.Add('N', "01");
            _AlphabetMap.Add('O', "000");
            _AlphabetMap.Add('P', "1001");
            _AlphabetMap.Add('Q', "0010");
            _AlphabetMap.Add('R', "101");
            _AlphabetMap.Add('S', "111");
            _AlphabetMap.Add('T', "0");
            _AlphabetMap.Add('U', "110");
            _AlphabetMap.Add('V', "1110");
            _AlphabetMap.Add('W', "100");
            _AlphabetMap.Add('X', "0110");
            _AlphabetMap.Add('Y', "0100");
            _AlphabetMap.Add('Z', "0011");

            _AlphabetMap.Add('0', "00000");
            _AlphabetMap.Add('1', "10000");
            _AlphabetMap.Add('2', "11000");
            _AlphabetMap.Add('3', "11100");
            _AlphabetMap.Add('4', "11110");
            _AlphabetMap.Add('5', "11111");
            _AlphabetMap.Add('6', "01111");
            _AlphabetMap.Add('7', "00111");
            _AlphabetMap.Add('8', "00011");
            _AlphabetMap.Add('9', "00001");

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

            throw new InvalidOperationException("The Telegraph doesn't contains de value");
        }

        public static char MapToAlphabeticalCharacter(string morseCode)
        {
            if (!Initilized) throw new InvalidOperationException("Telegraph has not been initialized");

            foreach (var map in _AlphabetMap)
            {
                if (map.Value.Equals(morseCode))
                    return map.Key;
            }

            throw new InvalidOperationException("The Telegraph doesn't contains de value");
        }
    }
}