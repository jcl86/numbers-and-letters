using Calculator.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class NumbersGame
    {
        public Calculation CurrentCalculation { get; set; }

        public List<Calculation> CalculationList { get; }

        public int Objetive { get; private set; }
        public List<Number> Numbers { get; private set; }
        public List<CalculatedNumber> CalculatedNumbers { get; }
        public Message Message { get; private set; }

        public NumbersGame(INumbersGamePreparer gamePreparer)
        {
            Objetive = gamePreparer.CreateObjetive();
            Numbers = gamePreparer.CreateNumbers().Select(value => new Number(value)).ToList();
            CurrentCalculation = new Calculation();
            CalculationList = new List<Calculation>();
            CalculatedNumbers = new List<CalculatedNumber>();

            RestartGame();
        }

        public void RestartGame()
        {
            foreach (var number in Numbers)
            {
                number.Enable();
            }
            CalculatedNumbers.Clear();
            Message = new Message(Objetive);
            CurrentCalculation.Restart();
            CalculationList.Clear();
        }

        public bool IsStarted => CalculationList.Any();

        public void Resolve()
        {
            if (CurrentCalculation.CanBeOperated())
            {
                CalculatedNumbers.Add(new CalculatedNumber(CurrentCalculation));
                CalculationList.Add(new Calculation(CurrentCalculation));
                RemoveValuesFromLists(CurrentCalculation);
                CurrentCalculation.Restart();
                SetMessage();
            }
        }

        private void RemoveValuesFromLists(Calculation calculation)
        {
            foreach (var number in calculation.GetNumbers())
            {
                if (number is CalculatedNumber calculatedNumber)
                {
                    CalculatedNumbers.Remove(calculatedNumber);
                }
                else
                {
                    Numbers.First(x => x.Equals(number)).Disable();
                }
            }
        }

        private void SetMessage()
        {
            if (GameFinished)
            {
                if (YouHaveWon())
                {
                    Message.Title = "Congratulations! You Won!";
                }
                else
                {
                    Message.Title = "That was close!";
                }
                Message.YourNumber = YourNumber();
            }
        }

        private bool GameFinished => CalculatedNumbers.Count == 1 && !Numbers.Any(x => !x.IsDisabled);
        private bool YouHaveWon() => GameFinished && DistanceToObjetive() == 0;
        private int YourNumber()
        {
            if (!CalculatedNumbers.Any())
            {
                return Objetive;
            }
            return CalculatedNumbers.First().Value;
        }
        private int DistanceToObjetive()
        {
            if (!CalculatedNumbers.Any())
            {
                return Objetive;
            }
            return Math.Abs(Objetive - CalculatedNumbers.First().Value);
        }
    }
}
