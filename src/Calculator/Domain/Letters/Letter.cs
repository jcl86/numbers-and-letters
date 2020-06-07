namespace Calculator
{
    public class Letter
    {
        private readonly char letter;
        public bool IsUsed { get; private set; }
        public void Use() => IsUsed = true;
        public void Reset() => IsUsed = false;

        public Letter(char letter)
        {
            this.letter = letter;
            IsUsed = false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (obj is Letter other)
            {
                return other.letter.Equals(letter);
            }
            return false;
        }

        public override int GetHashCode() => letter.GetHashCode();
        public override string ToString() => letter.ToString().ToUpper();
    }
}
