using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace WeeklyTimeUtility
{
    public partial class frmMain : Form
    {
        static Random _random = new Random();

        private int hoursPerDay = 8;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("weeks.txt");

            List<string> ranges = new List<string>();

            string line = string.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                ranges.Add(line);
            }

            sr.Close();

            List<WeekData> weeks = new List<WeekData>();

            TimeSpan balance = TimeSpan.Zero;


            string data = string.Empty;
            foreach (var range in ranges)
            {
                string[] tokens = range.Split(new char[] { '-'}, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length < 2)
                {
                    continue;
                }

                var requiredDays = SubstractVacationDays();
                var workedTime = GenerateWorkedTime(requiredDays);

                WeekData wd = new WeekData(tokens[0].Trim(), tokens[1].Trim(), false, string.Empty,
                    workedTime, balance, requiredDays);
                wd.Compute();

                balance = new TimeSpan(wd.Balance.Hours, wd.Balance.Minutes, wd.Balance.Seconds);
                weeks.Add(wd);

                data += wd.ToString();
            }
            lblOutput.Text = data;

            var str = JsonConvert.SerializeObject(weeks);
            // MessageBox.Show(str);
        }

        private TimeSpan GenerateWorkedTime(int requiredDays)
        {
            var secondsRequired = hoursPerDay * requiredDays * 60 * 60;
            var variance = secondsRequired / 10;
            var secondsWorked = _random.Next(secondsRequired - variance, secondsRequired + variance);
            return new TimeSpan(0, 0, secondsWorked);
        }

        private int SubstractVacationDays()
        {
            int p = 5; // 5% chances to introduce vacation days

            List<bool> roulette = new List<bool>();

            for (int i = 0; i < 100 - p; i++)
            {
                roulette.Add(false);
            }

            for (int i = 0; i < p; i++)
            {
                roulette.Add(true);
            }

            Shuffle<bool>(roulette);

            bool shouldAddVacationDays = roulette[_random.Next(0, roulette.Count)];

            if (shouldAddVacationDays)
            {
                return _random.Next(0, 5);
            }

            return 5;
        }

        static void Shuffle<T>(List<T> deck)
        {
            int n = deck.Count;
            for (int i = 0; i < n; i++)
            {
                // NextDouble returns a random number between 0 and 1.
                // ... It is equivalent to Math.random() in Java.
                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = deck[r];
                deck[r] = deck[i];
                deck[i] = t;
            }
        }

    }
}
