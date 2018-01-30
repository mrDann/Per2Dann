using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectPeriode2
{
    public partial class addMenuPage : Form
    {
        public addMenuPage()
        {
            InitializeComponent();
        }

        public menuPage menuPage = new menuPage();

        private void addMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Voer een SQL query uit...
                string query = "INSERT INTO Menu(Voorgerecht, Hoofdgerecht, Nagerecht, Prijs)values('" + inputVoorgerecht.Text + "','" + inputHoofdgerecht.Text + "','" + inputNagerecht.Text + "','" + inputPrijs.Text + "');";
                //Benodigd om onze database in het programma te krijgen.
                var dataAdapter = new SqlDataAdapter(query, connectionManager.connection);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                DialogResult dr;
                dr = MessageBox.Show("menu aanmaken voltooid!", "menu aanmaken", MessageBoxButtons.OK);

                if (dr == DialogResult.OK)
                {
                    menuPage.Refresh();
                    this.Close(); //Sluit de klant addKlant venster.
                }

            }
            catch (Exception ex)
            {
                connectionManager.closeConnection();
                MessageBox.Show("Fout bij het aanmaken van menu: " + ex.ToString());
            }
        }
    }
}
