namespace Models
{
    public class MyDocument : ISearchable
    {

        public string Text { get; set; }

        public MyDocument(string text)
        {
            Text = text;
        }

        public MyDocument()
        {

        }
        public string Search(string word)
        {
            if (Text.Contains(word))
                return $"The word '{word}' was found.";
            else
                return $"The word '{word}' was not found.";
        }
    }
}
