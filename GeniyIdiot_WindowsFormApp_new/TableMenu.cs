
using GeniyIdiot.Common;

namespace GeniyIdiot_WindowsFormApp_new
{
    public partial class TableMenu : Form
    {
        private List<Users> TableLine = StorageDiagnostic.GetUserDiagnoses();
        public TableMenu()
        {
            InitializeComponent();
            //var TableLine = StorageDiagnostic.GetUserDiagnoses();

            if (TableLine.Count == 0)
            {
                TextNotTablelabel1.Visible = true;
                dataGridView1.Visible = false;
                deleteButton.Visible = false;
            }
            else
            {
                dataGridView1.Visible = true;
                TextNotTablelabel1.Visible = false;
                deleteButton.Visible = true;

                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Points", "Points");
                dataGridView1.Columns.Add("Diagnosis", "Diagnosis");

                for (int i = 0; i < TableLine.Count; i++)
                {
                    dataGridView1.Rows.Add(TableLine[i].Name, TableLine[i].CounterCorrectAnswers, TableLine[i].Diagnosis);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (rowIndex < TableLine.Count && rowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(rowIndex);
                TableLine.RemoveAt(rowIndex);
                StorageDiagnostic.SaveListDiagnosis(TableLine);
            }
            if (TableLine.Count == 0)
            {
                TextNotTablelabel1.Visible = true;
                dataGridView1.Visible = false;
                deleteButton.Visible = false;
            }
        }
    }
}
