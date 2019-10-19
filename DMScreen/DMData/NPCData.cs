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
        public string GetNPCBond(int roll)
        {
            string bond = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(AppConfig.DynamicsConnectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Bond FROM NPCCreation WHERE RollOverride = @RollOverride";
                    cmd.CommandTimeout = 0;

                    cmd.Parameters.AddWithValue("@RollOverride", roll);

                    conn.Open();
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            bond = read["Bond"].ToString();
                        }
                    }
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

        public string GetNPCAppearance(int roll)
        {
            string app = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(AppConfig.DynamicsConnectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Feature FROM NPCCreation WHERE RollOverride = @RollOverride";
                    cmd.CommandTimeout = 0;

                    cmd.Parameters.AddWithValue("@RollOverride", roll);

                    conn.Open();
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            app = read["Feature"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                app = "Enjoys not having access to the database";
            }

            return app;
        }

        public List<string> GetRandomNPCIdeals(int number)
        {
            List<string> ideals = new List<string>();
            List<string> bluh = new List<string>();

            int roll = rand.Next(1, 37);

            try
            {
                using (SqlConnection conn = new SqlConnection(AppConfig.DynamicsConnectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT GoodIdeal, EvilIdeal, LawfulIdeal, ChaoticIdeal, NeutralIdeal, OtherIdeal FROM NPCCreation WHERE GoodIdeal IS NOT NULL AND EvilIdeal IS NOT NULL AND LawfulIdeal IS NOT NULL AND ChaoticIdeal IS NOT NULL AND NeutralIdeal IS NOT NULL AND OtherIdeal IS NOT NULL";

                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("@RollOverride", roll);
                    conn.Open();
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())                            
                        {
                                bluh.Add(read["GoodIdeal"].ToString());
                                bluh.Add(read["EvilIdeal"].ToString());
                                bluh.Add(read["LawfulIdeal"].ToString());
                                bluh.Add(read["ChaoticIdeal"].ToString());
                                bluh.Add(read["NeutralIdeal"].ToString());
                                bluh.Add(read["OtherIdeal"].ToString());

                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ideals.Add("Enjoys not having access to the database");
            }
            try
            {
                for (int i = 0; i < number; i++)
                {
                    int x = rand.Next(bluh.Count());
                    ideals.Add(bluh[x]);
                    bluh.RemoveAt(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ideals;
        }

        public List<string> GetNPCFlawsOrSecrets(int number)
        {
            List<string> fors = new List<string>();
            List<string> bluh = new List<string>();

            //bluh.Add("Has secret families across the countryside.");
            //bluh.Add("Once killed a man and doesn't feel regret for it.");
            //bluh.Add("Believes Capitalism is an inherently moral economic system.");
            //bluh.Add("Doesn't wash their hands after peeing.");
            //bluh.Add("Doesn't understand all the fuss over corgies.");

            try
            {
                using (SqlConnection conn = new SqlConnection(AppConfig.DynamicsConnectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT FlawOrSecret FROM NPCCreation WHERE FlawOrSecret IS NOT NULL";
                    cmd.CommandTimeout = 0;

                    conn.Open();
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            bluh.Add(read["FlawOrSecret"].ToString());
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                fors.Add("Enjoys not having access to the database");
            }

            try
            {
                for (int i = 0; i < number; i++)
                {
                    int x = rand.Next(bluh.Count());
                    fors.Add(bluh[x]);
                    bluh.RemoveAt(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return fors;
        }
        public string GetNPCTrait(int roll)
        {
            string trait = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(AppConfig.DynamicsConnectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Trait FROM NPCCreation WHERE RollOverride = @RollOverride";
                    cmd.CommandTimeout = 0;

                    cmd.Parameters.AddWithValue("@RollOverride", roll);

                    conn.Open();
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            trait = read["Trait"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trait = "Enjoys not having access to the database";
            }

            return trait;
        }
    }
}
