using System.Collections.Generic;

namespace Calculator
{
    public class Calculation
    {
        public const string ErrorText = "Error in current operation";

        private Number number1;
        private Number number2;
        private Operator @operator;

        public IEnumerable<Number> GetNumbers()
        {
            yield return number1;
            yield return number2;
        }

        public bool IsEmpty => number1 is null && number2 is null && @operator is null;
        public bool IsFilled => number1 != null && number2 != null && @operator != null;

        public Calculation()
        {
            Restart();
        }

        public Calculation(Calculation previous)
        {
            number1 = previous.number1;
            number2 = previous.number2;
            @operator = previous.@operator;
        }

        public void Restart()
        {
            number1 = null;
            number2 = null;
            @operator = null;
        }

        public void SetNumber(Number number)
        {
            if (@operator is null)
            {
                number1 = number;
            }
            else
            {
                number2 = number;
            }
        }

        public void SetOperator(Operator @operator)
        {
            if (number1 != null)
            {
                this.@operator = @operator;
            }
        }

        public int Operate()
        {
            if (!CanBeOperated())
            {
                throw new NotComputableException(this);
            }
            return @operator.Operate(number1, number2);
        }

        public bool CanBeOperated()
        {
            if (@operator is null) 
                return false;

            return @operator.CanBeOperated(number1, number2);
        }
        
        public override string ToString() => $"{number1?.ToString() ?? ""} {@operator?.ToString() ?? ""} {number2?.ToString() ?? ""}";
        public string ToStringComplete() => $"{ToString()} = {Operate()}";
    }

}
