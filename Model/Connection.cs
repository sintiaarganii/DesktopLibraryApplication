﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace DesktopLibraryApplication.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;

        public MySqlConnection GetConn()
        {

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=puskesmas";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid connection" + ex.Message);
            }
            return conn;
        }
    }
}
