namespace HomeWork
{
    public interface ICalc
    {
        double Result { get; set; }
        void Sum(double x);
        void Sub(double x);
        void Multy(double x);
        void Divide(double x);
        void CancelLast();

        event EventHandler<EventArgs> MyEventHandler;
    }
}
