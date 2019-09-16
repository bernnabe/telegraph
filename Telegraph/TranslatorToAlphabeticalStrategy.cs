namespace vscode_lab
{
    public class TranslatorToAlphabeticalStrategy : ITelegrapherStrategy
    {
        private const string OUTPUT_WORD_SEPARATOR = " ";
        private const string INPUT_WORD_SEPARATOR = " / ";
        private const string INPUT_CHAR_SEPARATOR = " ";

        public string Execute(string phrase)
        {
            string[] wordsToTranslate = phrase.Split(INPUT_WORD_SEPARATOR);

            //TODO: Cambiar a StringBuilder
            string result = string.Empty;

            for (int i = 0; i <= wordsToTranslate.Length - 1; i++)
            {
                string[] letters = wordsToTranslate[i].Split(INPUT_CHAR_SEPARATOR);
                
                //TODO: Cambiar a StringBuilder
                string translatedWord = string.Empty;
                for (int l = 0; l <= letters.Length - 1; l++)
                {
                    translatedWord += Telegraph.MapToAlphabeticalCharacter(letters[l]);
                }

                if (!result.Equals(string.Empty)) result += OUTPUT_WORD_SEPARATOR;
                result += translatedWord;
            }

            return result;
        }

    }
}