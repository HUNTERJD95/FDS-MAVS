using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://refactoring.guru/design-patterns/singleton/csharp/example
// Singleton is a creational design pattern, which ensures that only 
// one object of its kind exists and provides a single point of access 
// to it for any other code.

namespace MAVS_Projeto_Windows_Forms
{
    public sealed class DatabaseManager // Deprecated
    {
        private static DatabaseManager? instance;
        // private static readonly object padlock = new object();

        static string workingDirectory = Environment.CurrentDirectory;

        private SqlConnection connection;

        DatabaseManager()
        {
           
            // Jonas Path:
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\cs_ba\Desktop\FDS-MAVS\MAVS Projeto Windows Forms\BaseDados\Database1.mdf"";Integrated Security=True"); ;
            // Para funcionar na vossa máquina teem que colocar o vosso path
            // @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""O VOSSO PATH"";Integrated Security=True"); ;

            connection.Open();
        }

        public static DatabaseManager Instance
        {
            get
            {
                // lock (padlock)
                // {
                    if (instance == null)
                    {
                        instance = new DatabaseManager();
                    }
                    return instance;
                // }
            }
        }

      /*  public SqlConnection Connection
        {
            get
            {
                return connection;
            }
        }*/

        // Esta funcao serve para quando queremos fazer queries a database  (leitura) (Ex: Select * From)
        public SqlDataReader Query(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteReader();
        }

        // Esta funcao serve para fazer queries de escrita (Ex: Delete, update)
        public void NonQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
