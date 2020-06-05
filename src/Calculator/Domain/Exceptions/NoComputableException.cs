namespace Calculator
{
    public class NotComputableException : DomainException
    {
        private readonly Calculation calculation;
        public NotComputableException(Calculation calculation)
        {
            this.calculation = calculation;
        }

        public override string Message
        {
            get
            {
                return $"Can not operate {calculation}";
            }
        }
    }
}
