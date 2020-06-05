namespace Calculator
{
    public class Message
    {
        public string Title { get; set; }
        public int Objetive { get; set; }
        public int YourNumber { get; set; }
        public bool YouHaveWon => Objetive == YourNumber;

        public Message(int objetive)
        {
            Title = null;
            Objetive = objetive;
            YourNumber = 0;
        }

        public bool Show() => !string.IsNullOrWhiteSpace(Title);
    }
}