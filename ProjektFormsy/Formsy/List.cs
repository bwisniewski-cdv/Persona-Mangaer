using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektFormsy.Formsy
{
    public partial class List : Form
    {
        private PersonaService personaService = PersonaService.GetInstance();
        private BindingSource bindingSource = new BindingSource();

        public List()
        {
            InitializeComponent();
            Shown += formShown;
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var row = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (senderGrid.Columns[e.ColumnIndex].Name == "Remove")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                        "Confirm Delete!",
                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        personaService.DeletePersona(row);
                    }
                }
                else
                {
                    var confirmResult = MessageBox.Show("Are you sure to edit this item?",
                        "Confirm Edit!",
                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        Edit edit = new Edit(Convert.ToInt32(row));
                        edit.Show();
                    }
                }
            }
        }

        private void formShown(object sender, EventArgs e)
        {
            foreach (var item in personaService.GetAllPersonas())
            {
                bindingSource.Add(item);
            }

            // Initialize the DataGridView.
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSize = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.DataSource = bindingSource;

            // Initialize and add a text box column.
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ID";
            column.Name = "ID";
            dataGridView.Columns.Add(column);

            // Initialize and add a check box column.
            DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "Name";
            column2.Name = "Name";
            dataGridView.Columns.Add(column2);

            // Initialize and add a check box column.
            DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "Level";
            column3.Name = "Level";
            dataGridView.Columns.Add(column3);

            // Initialize and add a check box column.

            DataGridViewColumn column6 = new DataGridViewTextBoxColumn();
            column6.DataPropertyName = "Trait";
            column6.Name = "Trait";
            dataGridView.Columns.Add(column6);

            // Initialize and add a check box column.

            DataGridViewColumn Strength = new DataGridViewTextBoxColumn();
            Strength.DataPropertyName = "Strength";
            Strength.Name = "Strength";
            Strength.Width = 30;
            dataGridView.Columns.Add(Strength);

            // Initialize and add a check box column.

            DataGridViewColumn Magic = new DataGridViewTextBoxColumn();
            Magic.DataPropertyName = "Magic";
            Magic.Name = "Magic";
            Magic.Width = 30;
            dataGridView.Columns.Add(Magic);

            // Initialize and add a check box column.

            DataGridViewColumn Endurance = new DataGridViewTextBoxColumn();
            Endurance.DataPropertyName = "Endurance";
            Endurance.Name = "Endurance";
            Endurance.Width = 30;
            dataGridView.Columns.Add(Endurance);

            // Initialize and add a check box column.

            DataGridViewColumn Agility = new DataGridViewTextBoxColumn();
            Agility.DataPropertyName = "Agility";
            Agility.Name = "Agility";
            Agility.Width = 30;
            dataGridView.Columns.Add(Agility);

            // Initialize and add a check box column.

            DataGridViewColumn Luck = new DataGridViewTextBoxColumn();
            Luck.DataPropertyName = "Luck";
            Luck.Name = "Luck";
            Luck.Width = 30;
            dataGridView.Columns.Add(Luck);

            // Initialize button box column.
            DataGridViewButtonColumn column4 = new DataGridViewButtonColumn();
            column4.HeaderText = "Remove";
            column4.Name = "Remove";
            column4.Text = "Remove";
            column4.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(column4);
            dataGridView.CellClick += new DataGridViewCellEventHandler(cellClick);
            // Initialize button box column.
            DataGridViewButtonColumn column5 = new DataGridViewButtonColumn();
            column5.HeaderText = "Edit";
            column5.Name = "Edit";
            column5.Text = "Edit";
            column5.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(column5);

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Initialize the form.
            this.Controls.Add(dataGridView);
            this.AutoSize = true;
            this.Text = "Demo";
        }
    }
}