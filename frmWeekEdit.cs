using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeklyTimeUtility
{
    public partial class frmWeekEdit : Form
    {
        public WeekData week;

        private int index;
        private readonly List<ComboBox> _cmbsDays = null;

        public frmWeekEdit()
        {
            InitializeComponent(); 
        }

        public frmWeekEdit(WeekData wd, int i)
        {
            InitializeComponent();

            week = wd;
            index = i;

            _cmbsDays = new[] { cmbState, cmbStatutory, cmbUnpaid }.ToList();
            _cmbsDays.ForEach(cmb => cmb.SelectedIndexChanged += combo_SelectedIndexChanged);
        }

        private void frmWeekEdit_Load(object sender, EventArgs e)
        {
            _cmbsDays.ForEach(cmb => initializeCombo(cmb, week.vDays[_cmbsDays.IndexOf(cmb)]));
            _cmbsDays.ForEach(cmb => adjustCombo(cmb));

            lblWeekIndex.Text += index;
            lblWeekInterval.Text = string.Format("{0} - {1}", week.StartDate, week.EndDate);
            lblDaysReqVal.Text = week.RequiredDays.ToString();
        }

        private void initializeCombo(ComboBox combo, int days)
        {
            combo.Items.Clear();

            for (int i = 0; i <= days; i++)
            {
                combo.Items.Add(i);
            }

            combo.SelectedIndex = days;
            combo.Tag = days;
        }

        private void adjustCombo(ComboBox cmb)
        {
            for (int i = cmb.Items.Count - 1; i > cmb.SelectedIndex; i--)
            {
                cmb.Items.RemoveAt(i);
            }

            for (int i = 1; i <= MissingDays; i++)
            {
                cmb.Items.Add(cmb.Items.Count);
            }
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cmbsDays.ForEach(cmb => adjustCombo(cmb));

            lblDaysReqVal.Text = MissingDays.ToString();
        }

        private int VDaysSum
        {
            get { return _cmbsDays.Sum(cmb => cmb.SelectedIndex); }
        }

        private int MissingDays
        {
            get { return 5 - VDaysSum; }
        }

        private void lblWeekIndex_Click(object sender, EventArgs e)
        {

        }
    }
}
