namespace RespectingSingleResponsibilityPrinciple
{
    public class BookPrinter
    {
        public void PrintToConsole(string text)
        {
            Console.WriteLine(text);
        }

        public void PrintToAnotherMedium(string text)
        {
            // code for writing to any other location..
        }
    }
}
