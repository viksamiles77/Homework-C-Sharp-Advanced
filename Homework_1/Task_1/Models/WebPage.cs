namespace Models
{
    public class WebPage : ISearchable
    {

        public string Text { get; set; }

        public WebPage(string text)
        {
            Text = text;
        }

        public WebPage()
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
