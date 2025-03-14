﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMScreen;
using Microsoft.SqlServer;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using DMData.AppConfig;

namespace DMScreen.DMData
{
    public class NPCData
    {
        public string GetNPCBond()
        {
            string app = "";
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
                //MessageBox.Show(ex.Message);
            }

            return app;
        }
    }
}
