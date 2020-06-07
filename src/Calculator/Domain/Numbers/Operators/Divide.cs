namespace Calculator
{
    public class Divide : Operator
    {
        internal override int Operate(Number number1, Number number2) => number1.Value / number2.Value;
        protected override bool ConcreteOperationCanBeOperated(Number number1, Number number2)
        {
            return number2.Value != 0 && number1.Value % number2.Value == 0;
        }

        public override string ToString() => "/";
    }

}
