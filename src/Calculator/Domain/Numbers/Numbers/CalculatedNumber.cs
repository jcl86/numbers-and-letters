namespace Calculator
{
    public class CalculatedNumber : Number
    {
        public CalculatedNumber(Calculation calculation) : base(calculation.Operate()) { }
    }
}
