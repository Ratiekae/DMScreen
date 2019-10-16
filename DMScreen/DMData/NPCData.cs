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
        Random rand = new Random();
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

        public List<string> GetNPCIdeals(int number)
        {
            List<string> ideals = new List<string>();
            List<string> bluh = new List<string>();

            bluh.Add("Creativity");
            bluh.Add("Anarchy");
            bluh.Add("Personal Freedom");

            for (int i = 0; i < number; i++)
            {
                int x = rand.Next(bluh.Count());
                ideals.Add(bluh[x]);
                bluh.RemoveAt(x);
            }

            return ideals;
        }
        public List<string> GetNPCFlawsOrSecrets(int number)
        {
            List<string> fors = new List<string>();
            List<string> bluh = new List<string>();


            bluh.Add("Has secret families across the countryside.");
            bluh.Add("Once killed a man and doesn't feel regret for it.");
            bluh.Add("Believes Capitalism is an inherently moral economic system.");
            bluh.Add("Doesn't wash their hands after peeing.");
            bluh.Add("Doesn't understand all the fuss over corgies.");

            for (int i = 0; i < number; i++)
            {
                int x = rand.Next(bluh.Count());
                fors.Add(bluh[x]);
                bluh.RemoveAt(x);
            }

            return fors;
        }
    }
}
