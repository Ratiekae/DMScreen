using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace DMScreen.DMData
{
    public class NPCData
    {
        public string GetNPCBond()
        {
            string bond = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(AppConfig.DynamicsConnectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Bond FROM NPCBonds WHERE ID=3";
                    cmd.CommandTimeout = 0;

                    //cmd.Parameters.AddWithValue("@Id", roll);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                bond = "Enjoys not having access to the database";
            }

            return bond;
        }

        public string GetNPCAppearance()
        {
            string app = "";

            app = "Looks like the Piss Boy";

            return app;
        }

        public List<string> GetNPCIdeals()
        {
            List<string> ideals = new List<string>();

            ideals.Add("Creativity");

            return ideals;
        }
    }
}
