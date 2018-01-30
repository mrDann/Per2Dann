using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectPeriode2
{
    public partial class menuPage : Form
    {
        public menuPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addMenuPage addMenuKnop = new addMenuPage();
            addMenuKnop.Show();
        }

        private void menuPage_Load(object sender, EventArgs e)
        {
            //Voer een SQL query uit...
            string query = "SELECT Voorgerecht, Hoofdgerecht, Nagerecht, Prijs from Menu ORDER BY MenuID";
            //Benodigd om onze database in het programma te krijgen.
            var dataAdapter = new SqlDataAdapter(query, connectionManager.connection);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            //Haalt de data uit de database en laat hem zien in de view.
            menuView.ReadOnly = true;
            menuView.DataSource = dataSet.Tables[0];
        }

        private void delMenuButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("menu verwijderen voltooid!", "menu verwijderen", MessageBoxButtons.OK);
        }
    }
}
