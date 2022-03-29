namespace compliments.Services
{
    public class ComplimentGenerator
    {
        public string _sentenceAppend;
        private string _nameAppend;

        public ComplimentGenerator(string name)
        {
            _nameAppend = name;
        }

        public string ComplimentGetString()
        {
            List<string> appendables;
            Random random;
            GenerateAppendables(out appendables, out random);

            _sentenceAppend = GenerateSentence(random);

            var complimentString = _nameAppend + _sentenceAppend + appendables[random.Next(0, 5)];


            return complimentString;

        }
        private static void GenerateAppendables(out List<string> appendables, out Random random)
        {
            appendables = new List<string>();
            appendables.Add("cool");
            appendables.Add("funny");
            appendables.Add("great");
            appendables.Add("smart");
            appendables.Add("helpful");
            appendables.Add("kind");

            random = new Random();
        }
        private static string GenerateSentence(Random random)
        {
            var sentences = new List<string>();
            sentences.Add(" I think you are very ");
            sentences.Add(" your friends say you're ");
            sentences.Add(" you are very ");
            sentences.Add(" I've heard people find you ");


            return sentences[random.Next(0,3)];
        }
    }
}
