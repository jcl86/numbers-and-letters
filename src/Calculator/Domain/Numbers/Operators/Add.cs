namespace Calculator
{
    public class Add : Operator
    {
        internal override int Operate(Number number1, Number number2) => number1.Value + number2.Value;
        public override string ToString() => "+";
    }

}
