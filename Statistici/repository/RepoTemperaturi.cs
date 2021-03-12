using Statistici.entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistici.repository
{
    class RepoTemperaturi
    {
        private List<Temperatura> temperaturi;
        private DBConnection dbConnection;
        private SqlConnection sqlConnection;

        public RepoTemperaturi()
        {
            this.temperaturi = new List<Temperatura>();
            this.dbConnection = new DBConnection(@"Data Source=DESKTOP-DNPLVS7;Initial Catalog=ratbv;Trusted_Connection=True");
            dbConnection.connect();
            this.sqlConnection = dbConnection.sqlConnection;
            load_data();
        }

        private void load_data()
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from TemperaturaPoianaBrasov", sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DateTime data_masurare = DateTime.Parse(reader.GetString(reader.GetOrdinal("data_masurare")));
                double minim = reader.GetDouble(reader.GetOrdinal("minim"));
                double maxim = reader.GetDouble(reader.GetOrdinal("maxim"));
                Temperatura temperatura = new Temperatura(minim, maxim, data_masurare);
                temperaturi.Add(temperatura);
            }
            reader.Close();
        }

        public List<Temperatura> get_all()
        {
            return this.temperaturi;
        }
    }
}
