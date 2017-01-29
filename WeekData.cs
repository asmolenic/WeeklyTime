using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTimeUtility
{
    public class WeekData
    {
        private string _startDate;               // prefilled - labeling puprose only
        private string _endDate;                 // prefilled - labeling puprose only
        private bool _reported;                  // user managed - should be set in the constructor
        private string _description;             // user managed - should be set in the constructor
        private TimeSpan _hoursWorkedThisWeek;   // user managed - should be set in the constructor
        private TimeSpan _thisWeeksBalance;      // to be computed
        private TimeSpan _balance;               // to be computed
        private TimeSpan _initialBalance;        // user managed - should be set in the constructor
        private int _requiredDays;               // user managed - should be set in the constructor
        private int _hoursPerDay;                // user managed - should be set in the constructor

        //default values
        private const int DEFAULT_REQUIRED_DAYS = 5;
        private const int DEFAULT_HOURS_PER_DAY = 8;

        // default constructor
        public WeekData()
        {
        }

        public WeekData(string startDate, string endDate, bool reported, string description,
            TimeSpan hoursWorkedThisWeek, TimeSpan initialBalance, 
            int requiredDays = DEFAULT_REQUIRED_DAYS, int hoursPerDay = DEFAULT_HOURS_PER_DAY)
        {
            StartDate = startDate;
            EndDate = endDate;
            Reported = reported;
            Description = description;
            HoursWorkedThisWeek = hoursWorkedThisWeek;
            InitialBalance = initialBalance;

            RequiredDays = requiredDays;
            HoursPerDay = hoursPerDay;

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
                _reported ? "X" : " ", StartDate, EndDate, TimeSpanToString(HoursWorkedThisWeek),
                TimeSpanToString(ThisWeeksBalance), TimeSpanToString(Balance), 
                string.IsNullOrWhiteSpace(Description) ? string.Format("{0} days required", RequiredDays) : Description);
            string x = TimeSpanToString(HoursWorkedThisWeek);
            return output + Environment.NewLine;
        }

        private string TimeSpanToString(TimeSpan input)
        {
            //string output = string.Empty;

            //int totalHours = (int)Math.Floor(input.TotalHours);
            //var remaining = input.Subtract(new TimeSpan(totalHours, 0, 0));
            //int minutes = (int)Math.Floor(remaining.TotalMinutes);
            int totalHours = (int)input.TotalHours;
            var remaining = input.Subtract(new TimeSpan(totalHours, 0, 0));
            int minutes = Math.Abs(input.Minutes);

            return string.Format("{2}{0:D2}H {1:D2}M", Math.Abs(totalHours), minutes, input >= TimeSpan.Zero ? " " : "-");
        }

        public string StartDate
        {
            get
            {
                return _startDate;
            }

            set
            {
                _startDate = value;
            }
        }

        public string EndDate
        {
            get
            {
                return _endDate;
            }

            set
            {
                _endDate = value;
            }
        }

        public bool Reported
        {
            get
            {
                return _reported;
            }

            set
            {
                _reported = value;
            }
        }

        public TimeSpan ThisWeeksBalance
        {
            get
            {
                return _thisWeeksBalance;
            }

            set
            {
                _thisWeeksBalance = value;
            }
        }

        public TimeSpan Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            }
        }

        public int RequiredDays
        {
            get
            {
                return _requiredDays;
            }

            set
            {
                _requiredDays = value;
            }
        }

        public TimeSpan HoursWorkedThisWeek
        {
            get
            {
                return _hoursWorkedThisWeek;
            }

            set
            {
                _hoursWorkedThisWeek = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public TimeSpan InitialBalance
        {
            get
            {
                return _initialBalance;
            }

            set
            {
                _initialBalance = value;
            }
        }

        public int HoursPerDay
        {
            get
            {
                return _hoursPerDay;
            }

            set
            {
                _hoursPerDay = value;
            }
        }
    }
}
