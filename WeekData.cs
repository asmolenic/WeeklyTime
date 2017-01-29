using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTimeUtility
{
    public class WeekData
    {
        private string startDate;               // prefilled - labeling puprose only
        private string endDate;                 // prefilled - labeling puprose only
        private bool reported;                  // user managed - should be set in the constructor
        private string description;             // user managed - should be set in the constructor
        private TimeSpan hoursWorkedThisWeek;   // user managed - should be set in the constructor
        private TimeSpan thisWeeksBalance;      // to be computed
        private TimeSpan balance;               // to be computed
        private TimeSpan initialBalance;        // user managed - should be set in the constructor
        private int requiredDays;               // user managed - should be set in the constructor
        private int hoursPerDay;                // user managed - should be set in the constructor

        //default values
        private const int defaultRequiredDays = 5;
        private const int defaultHoursPerDay = 8;

        // default constructor
        public WeekData()
        {
        }

        public WeekData(string _startDate, string _endDate, bool _reported, string _description,
            TimeSpan _hoursWorkedThisWeek, TimeSpan _initialBalance, 
            int _requiredDays = defaultRequiredDays, int _hoursPerDay = defaultHoursPerDay)
        {
            StartDate = _startDate;
            EndDate = _endDate;
            Reported = _reported;
            Description = _description;
            HoursWorkedThisWeek = _hoursWorkedThisWeek;
            InitialBalance = _initialBalance;

            RequiredDays = _requiredDays;
            HoursPerDay = _hoursPerDay;

            Compute();
        }
        
        // copy constructor
        public WeekData(WeekData obj)
        {
            if (obj != null)
            {
                StartDate = obj.StartDate;
                EndDate = obj.EndDate;
                Reported = obj.Reported;
                Description = obj.Description;
                HoursWorkedThisWeek = obj.HoursWorkedThisWeek;
                ThisWeeksBalance = obj.ThisWeeksBalance;
                Balance = obj.Balance;
                InitialBalance = obj.InitialBalance;
                RequiredDays = obj.RequiredDays;
                HoursPerDay = obj.HoursPerDay;
            }
        }

        public void Compute()
        {
            TimeSpan thisWeeksTarget = new TimeSpan(RequiredDays * HoursPerDay, 0, 0);

            ThisWeeksBalance = HoursWorkedThisWeek.Subtract(thisWeeksTarget);
            Balance = InitialBalance.Add(ThisWeeksBalance);
        }

        public override string ToString()
        {
            string output = string.Format("[{0}]  {1}-{2}  {3}  {4}  {5}  {6}",
                reported ? "X" : " ", StartDate, EndDate, (HoursWorkedThisWeek),
                (ThisWeeksBalance), (Balance), 
                string.IsNullOrWhiteSpace(Description) ? string.Format("{0} days required", RequiredDays) : Description);
            string x = TimeSpanToString(HoursWorkedThisWeek);
            return output + Environment.NewLine;
        }

        private string TimeSpanToString(TimeSpan input)
        {
            string output = string.Empty;

            int totalHours = (int)Math.Floor(input.TotalHours);
            var remaining = input.Subtract(new TimeSpan(totalHours, 0, 0));
            int minutes = (int)Math.Floor(remaining.TotalMinutes);

            return string.Format("{0,4}H {1:D2}M", totalHours, minutes);
        }

        public string StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public string EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public bool Reported
        {
            get
            {
                return reported;
            }

            set
            {
                reported = value;
            }
        }

        public TimeSpan ThisWeeksBalance
        {
            get
            {
                return thisWeeksBalance;
            }

            set
            {
                thisWeeksBalance = value;
            }
        }

        public TimeSpan Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public int RequiredDays
        {
            get
            {
                return requiredDays;
            }

            set
            {
                requiredDays = value;
            }
        }

        public TimeSpan HoursWorkedThisWeek
        {
            get
            {
                return hoursWorkedThisWeek;
            }

            set
            {
                hoursWorkedThisWeek = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public TimeSpan InitialBalance
        {
            get
            {
                return initialBalance;
            }

            set
            {
                initialBalance = value;
            }
        }

        public int HoursPerDay
        {
            get
            {
                return hoursPerDay;
            }

            set
            {
                hoursPerDay = value;
            }
        }
    }
}
