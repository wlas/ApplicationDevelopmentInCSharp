namespace HomeWork
{
    public class Calc : ICalc
    {
        public double Result { get; set; } = 0D;

        public event EventHandler<EventArgs> MyEventHandler;
        private Stack<double> LastResult { get; set; } = new Stack<double>();

        private void PrintResult()
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }


        public void Divide(int x)
        {
            Result /= x;
            PrintResult();
        }

        public void Multy(int x)
        {
            Result *= x;
            PrintResult();
        }

        public void Sub(int x)
        {
            Result -= x;
            PrintResult();
        }

        public void Sum(int x)
        {
            Result += x;
            PrintResult();
        }

        public void CancelLast()
        {
            if (LastResult.TryPop(out double res))
            {
                Result = res;
                Console.WriteLine("Последнее действие отменено. Результат равен:");
                PrintResult();
            }
            else
            {
                Console.WriteLine("Невозможно отменить послдеднее действие!");
            }
        }
    }
}
