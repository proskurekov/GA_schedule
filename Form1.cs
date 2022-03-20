using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert; 

namespace GA_schedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int CountJobs, Operation, Machine;
        const int Hlabel = 25;
        public Grid grid;

        void CreateJobs()
        {
            var location = 0;

            for ((int i, int l) = (0, 1); i < CountJobs; i++, l++)
            {
                grid = new Grid(Machine, Operation);

                var panel = CreatePanel(grid.Param.Width, grid.Param.Height + Hlabel);
                var label = CreateLabel();
                var y = grid.Param.ClientSize.Height;
                var margin = 20 + Hlabel;
                panel.Location = new Point(0, location);
                location += y + margin;
                label.Text = "Работа " + l;
                panel.Controls.Add(label);
                panel.Controls.Add(grid.Param);
                jobsPanel.Controls.Add(panel);
            }

            grid.GetGrids(jobsPanel);
        }

        Panel CreatePanel(int w, int h)
        {
            Panel panel = new Panel()
            {
                Width = w,
                Height = h,
                Location = new Point(0, 0),
                Name = "panel",
            };
            return panel;
        }
        Label CreateLabel()
        {
            Label label = new Label()
            {
                Font = new Font("Arial", 9f),
                AutoSize = false,
                Text = "",
                ForeColor = Color.Purple,
                Width = 60,
                Height = Hlabel,
            };
            return label;
        }

        private void BtnSrart_Click(object sender, EventArgs e)
        {
            CountJobs = ToInt32(numJobs.Value);
            Operation = ToInt32(numOperations.Value);
            Machine = ToInt32(numMachine.Value);
            jobsPanel.Controls.Clear();
            CreateJobs();
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            grid.FillGrid();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            grid.ClearGrid();
        }
    }
}
