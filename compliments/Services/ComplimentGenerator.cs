namespace compliments.Services
{
    public class ComplimentGenerator
    {
        private string _complimentAppend;

        public ComplimentGenerator(string ComplimentAppend)
        {
            _complimentAppend = ComplimentAppend;

        }

        public string ComplimentGetString() {

            var appendables = new List<string>();

            appendables.Add("cool");
            appendables.Add("funny");
            appendables.Add("great");
            appendables.Add("smart");
            appendables.Add("helpful");
            appendables.Add("kind");

            var random = new Random();

            var complimentString = _complimentAppend + appendables[random.Next(0,5)];


            return complimentString;   

        }


    }
}
