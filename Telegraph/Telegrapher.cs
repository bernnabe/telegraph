namespace vscode_lab
{
    public class Telegrapher
    {
        private Mode _Mode;

        public enum Mode
        {
            AlphabeticalToMorse,
            MorseToAlphabetical
        }

        public Telegrapher()
        {
            Telegraph.Initilize();
        }

        public Telegrapher SetMode(Mode mode)
        {
            _Mode = mode;
            return this;
        }

        public string Execute(string phrase)
        {
            ITelegrapherStrategy strategy = null;

            switch (_Mode)
            {
                case Mode.AlphabeticalToMorse:
                    strategy = new TranslatorToMorseStrategy();
                    break;
                case Mode.MorseToAlphabetical:
                    strategy = new TranslatorToAlphabeticalStrategy();
                    break;
            }

            return strategy.Execute(phrase);
        }
    }

    public interface ITelegrapherStrategy
    {
        string Execute(string phrase);
    }
}