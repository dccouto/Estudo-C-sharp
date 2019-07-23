using System;

namespace ContratroTrabalho.Entities
{
    class HourContract
    {
        public DateTime Date { set; get; }
        public double ValuePerHour { set; get; }
        public int Hours { set; get; }

        public HourContract() { }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

    }
}
