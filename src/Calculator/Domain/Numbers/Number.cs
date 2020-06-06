using System;

namespace Calculator
{
    public class Number
    {
        public Guid Id { get; }
        public int Value { get; }
        public bool IsDisabled { get; private set; }
        public void Enable() => IsDisabled = false;
        public void Disable() => IsDisabled = true;

        public Number(int value)
        {
            Id = Guid.NewGuid();
            Value = value;
            IsDisabled = false;
        }

        public int GetWidthInRems()
        {
            if (Value > 999) return 11;
            if (Value > 99) return 9;
            return 7;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (obj is Number number)
            {
                return number.Id == Id;
            }
            return false;
        }

        public override int GetHashCode() => Id.GetHashCode();
        public override string ToString() => Value.ToString();
    }
}
