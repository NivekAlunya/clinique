using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Clinique.View
{
    static class CommonBehaviourView
    {
        public static void createColumnDataGridView(DataGridView dgvAgenda)
        {
            dgvAgenda.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "ag";
            col.HeaderText = "object";
            col.Width = 50;
            col.Visible = false;
            dgvAgenda.Columns.Add(col);
            col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "hour";
            col.HeaderText = "Heure";
            col.Width = 50;
            dgvAgenda.Columns.Add(col);
            col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "Nom";
            col.HeaderText = "Client";
            col.Width = 140;
            dgvAgenda.Columns.Add(col);
            col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "animal";
            col.HeaderText = "Animal";
            col.Width = 140;
            dgvAgenda.Columns.Add(col);
            col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "race";
            col.HeaderText = "Race";
            col.Width = 80;
            dgvAgenda.Columns.Add(col);
        }
    }
}
