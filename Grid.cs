using System;
using System.Windows.Forms;
using System.Drawing; 
using System.Collections.Generic;
using static System.Convert;
using System.Linq;

namespace GA_schedule
{
    public class Grid
    {
        public DataGridView Param { get; }
        public int Operation, Machine;
        private const int _h = 25;
        private List<DataGridView> _grids; 

        public Grid(int machine, int operation)
        {
            this.Operation = operation;
            this.Machine = machine; 
            
            this.Param = new DataGridView
            {
                ColumnCount = this.Machine,
                RowCount = this.Operation+1,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToOrderColumns = false,
                AllowUserToResizeRows = false,
                RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                BackgroundColor = Color.FromArgb(249, 249, 249),
                BorderStyle = BorderStyle.None,
                ScrollBars = ScrollBars.None,
                Location = new Point(0, _h),
                Name = "grid",
            };
            
            this.Param.EditingControlShowing +=DgvOnEditingControlShowing;
            this.Param.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            LoopHeader(this.Param.ColumnCount, this.Param.RowCount);
            ResizeGrid();
        }

        private void ResizeGrid()
        {
            var states = DataGridViewElementStates.None;
            var totalHeight = Param.Rows.GetRowsHeight(states) + Param.ColumnHeadersHeight;
            totalHeight += Param.Rows.Count;
            var totalWidth = Param.Columns.GetColumnsWidth(states) + Param.RowHeadersWidth;
            Param.ClientSize = new Size(totalWidth, totalHeight);
        }

        private void LoopHeader(int c, int r)
        {
            for (var i = 0; i < c; i++)
            {
                var num = i + 1;
                Param.Columns[i].HeaderText = "M" + num;

            }

            for (var i = 0; i < r; i++)
            {
                var num = i + 1;
                Param.Rows[i].HeaderCell.Value = "П" + num;
            }
        }

        private void DgvOnEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(KeyPressEventHandler);
        }

        private void KeyPressEventHandler(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        public List<DataGridView> GetGrids(Panel pnl)
        {
            _grids = new List<DataGridView>() { };
            foreach (Control panels in pnl.Controls)
            {
                foreach (Control panel in panels.Controls)
                {
                    if (panel is DataGridView)
                    {
                        _grids.Add((DataGridView) panel);
                    }
                }
            }
            return _grids;
        }

        public void FillGrid(int indx)
        {
            var temp = new int[Operation, Machine];
            var rand = new Random();
            var grids = indx == 0 ? _grids : _grids.GetRange(indx-1, 1);  

            foreach (var grid in grids)
            {
                for (int i = 0; i < Operation; i++)
                {
                    for (int j = 0; j < Machine; j++)
                    {
                        var condition = rand.Next(200);
                        temp[i, j] = condition > 50 ? condition : 0;
                        grid.Rows[i].Cells[j].Value = temp[i, j];
                    }
                }
            }
        }
        public void ClearGrid(int indx)
        {
            var grids = indx == 0 ? _grids : _grids.GetRange(indx - 1, 1);

            foreach (var grid in grids)
            {
                for (int i = 0; i < Operation; i++)
                {
                    for (int j = 0; j < Machine; j++)
                    {
                        grid.Rows[i].Cells[j].Value = "";
                    }
                }
            }
        }
    }
}