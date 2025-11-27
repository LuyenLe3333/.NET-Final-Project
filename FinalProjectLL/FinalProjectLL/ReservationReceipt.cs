namespace FinalProjectLL
{
    public class ReservationReceipt {
        private string? reservationNum;
        private int reservationStat; //0=Paid, 1=Reserved, 2=Canceled
        private string? name;
        private DateTime reservationDate;
        private TimeOnly time;
        private bool paid;
        private double total;


        //receive everything except reservationNum and reservationStat
        public ReservationReceipt(string name, DateTime date, TimeOnly time, bool paid, double total)
        {

            ReservationStat = 1;
            Name = name;
            ReservationDate = date;
            Time = time;
            Paid = paid;
            Total = total;

            Random r = new Random();
            reservationNum = r.Next(6000000).ToString();
        }

        //receive everything except reservationNum
        public ReservationReceipt(int status, string name, DateTime date, TimeOnly time, bool paid, double total) { 
            ReservationStat = status;
            Name = name;
            ReservationDate = date;
            Time = time;
            Paid = paid;
            Total = total;

            Random r = new Random();
            reservationNum = r.Next(6000000).ToString();
        } 

        public string? ReservationNum { get => reservationNum; set => reservationNum = value; }
        public int ReservationStat { get => reservationStat; set => reservationStat = value; }
        public string? Name { get => name; set => name = value; }
        public DateTime ReservationDate { get => reservationDate; set => reservationDate = value; }
        public TimeOnly Time { get => time; set => time = value; }
        public bool Paid { get => paid; set => paid = value; }
        public double Total { get => total; set => total = value; }
    }
}
