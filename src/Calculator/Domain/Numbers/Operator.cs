namespace Calculator
{
    public abstract class Operator
    {
        public static Operator Add => new Add();
        public static Operator Substract => new Substract();
        public static Operator Multiply => new Multiply();
        public static Operator Divide => new Divide();

        abstract internal int Operate(Number number1, Number number2);

        public bool CanBeOperated(Number number1, Number number2)
        {
            if (number1 is null|| number2 is null) return false;
            if (number1.Equals(number2)) return false;
            return ConcreteOperationCanBeOperated(number1, number2);
        }

        protected virtual bool ConcreteOperationCanBeOperated(Number number1, Number number2) => true;
    }
}
