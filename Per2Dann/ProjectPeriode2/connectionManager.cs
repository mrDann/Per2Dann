using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProjectPeriode2
{
    class connectionManager
    {

        //Connection string doorgeven. LET OP: localhost, dus je moet een lokale database hebben.
        public static SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=RestaurantDB3;Integrated Security=True");

        public static void openConnection()
        {
            try
            {
                
                //Eerst checken of de verbinding open is. Als hij open is, dan moeten we niet nog een verbinding openmaken.
                if (connection.State == ConnectionState.Open)
                {
                    return;
                }
                else
                {
                    connection.Open();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij openen verbinding met database: " + ex.ToString());
            }
        }
        
        public static void closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij sluiten verbinding met database: " + ex.ToString());
            }
        }




    }
}
