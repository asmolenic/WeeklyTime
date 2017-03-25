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
        #region Settings

        private int hoursPerDay;
        private int percentageChanceToIntroduceVacationDays;

        #endregion Settings

        #region Utility variables

        static Random _random = new Random();
        private List<bool> vacationDaysRoulette;

        #endregion Utility variables

        public frmMain()
        {
            InitializeComponent();

            #region Initialize the setting variables

            hoursPerDay = 8;
            percentageChanceToIntroduceVacationDays = 10;

            #endregion Initialize the setting variables

            #region Initialize the vacation days roulette

            vacationDaysRoulette = new List<bool>();

            for (int i = 0; i < 100 - percentageChanceToIntroduceVacationDays; i++)
            {
                vacationDaysRoulette.Add(false);
            }

            for (int i = 0; i < percentageChanceToIntroduceVacationDays; i++)
            {
                vacationDaysRoulette.Add(true);
            }

            Shuffle<bool>(vacationDaysRoulette);

            #endregion Initialize the vacation days roulette
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // DataGridViewRow row = new DataGridViewRow();

            // dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // dgvMain.Columns[3]
            //dgvMain.DefaultCellStyle.SelectionBackColor = dgvMain.DefaultCellStyle.BackColor;
            //dgvMain.DefaultCellStyle.SelectionForeColor = dgvMain.DefaultCellStyle.ForeColor;

            StreamReader sr = new StreamReader("weeks.txt");

            List<string> ranges = new List<string>();

            string line = string.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                ranges.Add(line);
            }

            sr.Close();

            List<WeekData> weeks = new List<WeekData>();

            TimeSpan? balance = null;

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

                WeekData wd = new WeekData(tokens[0].Trim(), tokens[1].Trim(), false, string.Format("{0} days required", requiredDays),
                    workedTime, balance, new List<int>() { 0, requiredDays, 0}, requiredDays);
                wd.Compute();

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvMain, wd.ReportedString(), wd.StartDate, wd.EndDate,
                    wd.TimeSpanToString(wd.HoursWorkedThisWeek),
                    wd.TimeSpanToString(wd.ThisWeeksBalance),
                    wd.TimeSpanToString(wd.Balance), wd.Description, "Edit");
                row.Tag = wd;

                dgvMain.Rows.Add(row);

                balance = new TimeSpan(wd.Balance.Hours, wd.Balance.Minutes, wd.Balance.Seconds);
                weeks.Add(wd);

                data += wd.ToString();
            }
            lblOutput.Text = data;

            var str = JsonConvert.SerializeObject(weeks);
            // MessageBox.Show(str);

            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private TimeSpan GenerateWorkedTime(int requiredDays)
        {
            var minutesRequired = hoursPerDay * requiredDays * 60;
            var variance = minutesRequired / 10;
            var minutesWorked = _random.Next(minutesRequired - variance, minutesRequired + variance);
            return new TimeSpan(0, minutesWorked, 0);
        }

        private int SubstractVacationDays()
        {
            bool shouldAddVacationDays = vacationDaysRoulette[_random.Next(0, vacationDaysRoulette.Count)];

            if (shouldAddVacationDays)
            {
                return _random.Next(0, 5);
            }

            return 5;
        }


        #region Utility methods

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

        #endregion Utility methods


        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                launchWeekEditForm(dgvMain.Rows[e.RowIndex].Tag as WeekData, e.RowIndex);
            }
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                launchWeekEditForm(dgvMain.Rows[e.RowIndex].Tag as WeekData, e.RowIndex);
            }
        }

        private void launchWeekEditForm(WeekData wd, int index)
        {
            frmWeekEdit weekEditForm = new frmWeekEdit(wd, index + 1);
            weekEditForm.Show();
        }
    }
}
