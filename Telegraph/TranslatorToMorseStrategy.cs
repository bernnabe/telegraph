namespace vscode_lab
{
    public class TranslatorToMorseStrategy : ITelegrapherStrategy
    {
        private const string OUTPUT_WORD_SEPARATOR = " / ";
        private const string OUTPUT_CHAR_SEPARATOR = " ";
        private const string INPUT_WORD_SEPARATOR = " ";

        public string Execute(string phrase)
        {
            string[] wordsToTranslate = phrase.Split(INPUT_WORD_SEPARATOR);

            //TODO: Cambiar a StringBuilder
            string result = string.Empty;

            for (int i = 0; i <= wordsToTranslate.Length - 1; i++)
            {
                char[] word = wordsToTranslate[i].ToCharArray();

                //TODO: Cambiar a StringBuilder
                string translatedWord = string.Empty;
                for (int l = 0; l <= word.Length - 1; l++)
                {
                    translatedWord += Telegraph.MapToMorseCharacter(word[l]);

                    if (l + 1 < word.Length) translatedWord += OUTPUT_CHAR_SEPARATOR;
                }

                if (!result.Equals(string.Empty)) result += OUTPUT_WORD_SEPARATOR;
                result += translatedWord;
            }

            return result;
        }

    }
}