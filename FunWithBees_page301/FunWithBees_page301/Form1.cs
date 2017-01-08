using Bees.BeeHive;
using Configuration.JobsList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithBees_page301
{
    public partial class MainForm : Form
    {
        Queen queen;
        public MainForm()
        {
            InitializeComponent();
            comboBoxWorkerBeeJob.SelectedIndex = 0;

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(BeesJobsList.GetList(0, 1), 175);
            workers[1] = new Worker(BeesJobsList.GetList(2, 3), 114);
            workers[2] = new Worker(BeesJobsList.GetList(4, 5), 149);
            workers[3] = new Worker(BeesJobsList.List, 155);

            queen = new Queen(workers, 275);
        }

        private void buttonNextShift_Click(object sender, EventArgs e)
        {
            textBoxReport.Text += queen.WorkTheNextShift() + "\r\n\n";
            //textBoxReport.Text += "------------------------------------------------------\r\n";
        }

        private void buttonAssignJob_Click(object sender, EventArgs e)
        {
            if (!queen.AssignWork(comboBoxWorkerBeeJob.Text, (int)numericUpDownShifts.Value))
                MessageBox.Show($"Для этого задания рабочих нет '{comboBoxWorkerBeeJob.Text}'", "Матка говорит...");
            else
                MessageBox.Show($"Задание '{comboBoxWorkerBeeJob.Text}' будет закончено через {numericUpDownShifts.Value} смен", "Матка говорит...");
        }
    }
}
