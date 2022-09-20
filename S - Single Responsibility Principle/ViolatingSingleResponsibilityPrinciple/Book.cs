namespace ViolatingSingleResponsibilityPrinciple
{
    public class Book
    {
        public Book(string name, string author, string text)
        {
            Name = name;
            Author = author;
            Text = text;
        }

        public string Name { get; }
        public string Author { get; }
        public string Text { get; }

        public string ReplaceWordInText(string word, string replacementWord)
        {
            return Text.Replace(word, replacementWord);
        }

        public bool IsWordInText(string word)
        {
            return Text.Contains(word);
        }

        /* 
        The book class purpose is not to provide and handle printing.
        Therefore it's violating the SRP principle.
        To fulfill the SRP - move the book printing logic out of the book class.
        */
        public void PrintBookTextToConsole()
        {
            Console.WriteLine(Text);
        }
    }
}