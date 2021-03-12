using Statistici.entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Statistici.entities.Validare;

namespace Statistici.repository
{
    class RepoValidari
    {
        private List<Validare> validari;
        private DBConnection dbConnection;
        private SqlConnection sqlConnection;
        public RepoValidari()
        {
            this.validari = new List<Validare>();
            this.dbConnection = new DBConnection(@"Data Source=DESKTOP-DNPLVS7;Initial Catalog=ratbv;Trusted_Connection=True");
            dbConnection.connect();
            this.sqlConnection = dbConnection.sqlConnection;
            load_data();
        }

        private void load_data()
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Validari", sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            int i = 0;
            while(reader.Read() && i< 63992)
            {
                String titlu_calatorie= reader.GetString(reader.GetOrdinal("Titlu_Calatorie"));
                String auto = reader.GetString(reader.GetOrdinal("Auto"));
                String ziua = reader.GetString(reader.GetOrdinal("Data_Validarii"));

                TITLU_CALATORIE titlu = (TITLU_CALATORIE)Enum.Parse(typeof(TITLU_CALATORIE), titlu_calatorie, true);
                AUTOBUZ autobuz = (AUTOBUZ)Enum.Parse(typeof(AUTOBUZ), auto, true);
                Validare validare = new Validare(titlu, autobuz, DateTime.Parse(ziua));

                validari.Add(validare);
                i++;
            }
            reader.Close();
        }

        public List<Validare> get_all()
        {
            return this.validari;
        }

        public int get_nr_validari(int day, int month, int year)
        {
            string d = "";
            if (day < 10)
                d = "0" + day.ToString();
            else
                d = day.ToString();
            string m = "";
            if (month < 10)
                m = "0" + month.ToString();
            else
                m = month.ToString();
            SqlCommand sqlCommand = new SqlCommand(@"Select count(*) as Nr from Validari where Ziua like '" + year + "-" + m + "-" + d + "'", sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            int nr = 0;
            while (reader.Read())
            {
                nr = reader.GetInt32(reader.GetOrdinal("Nr"));
            }
            reader.Close();
            return nr;
        }
    }
}
