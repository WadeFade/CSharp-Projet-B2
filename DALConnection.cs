using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidCardCoin
{
    public class DALConnection
    {
        private static string server;
        private static string database;
        private static string uid;
        private static string password;

        public static MySqlConnection connection;

        public static MySqlConnection OpenConnection()
        {
            if (connection == null) //  Si la connexion est déjà établi, il ne la refera pas 
            {
                // Pour environnement de développement
                
                server = "localhost";
                database = "mathis_gauthier";
                uid = "root";
                password = "";
               

               // Pour environnement de production (MySQL / MariaDB)
               /*
                server = "172.16.2.7";
                database = "mathis_gauthier";
                uid = "mathis_gauthier";
                password = "Epsi2021!";
               */

                // Pour environnement de production (SQL Server)
                /*
                server = "172.16.1.7";
                database = "mathis_gauthier";
                uid = "mathis_gauthier";
                password = "Epsi2021!";
                */
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            return connection;
        }

    }
}
