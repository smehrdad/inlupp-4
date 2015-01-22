using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;


namespace AnimalManager
{
    public class DataAccess
    {
        System.Configuration.ConnectionStringSettings Con = ConfigurationManager.ConnectionStrings["AnimalDBConnectionString"];
        public void DeleteAnimalData()
        {

        }
        public ListView LoadAnimalData()
        {
            ListView listView = new ListView();
            //ListViewItem lv = new ListViewItem();
            
            string queryString = "SELECT * FROM dbo.Animal;";
            using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {

                    ListViewItem lv = new ListViewItem(); 
                          
                    lv.SubItems.Add(reader.GetGuid(0).ToString());
                    lv.SubItems.Add(reader.GetString(1));
                    float age = (float)reader.GetDouble(2);
                    lv.SubItems.Add(age.ToString());
                    lv.SubItems.Add(reader.GetString(3));
                    lv.SubItems.Add(reader.IsDBNull(4) ? string.Empty : reader.GetString(4));
                    listView.Items.Add(lv);
                    i++;
                }
                return listView;
            }
        }
        public void SaveAnimalData(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
             using(var command = new SqlCommand(queryString, connection))
   
            {
                //SqlCommand command = new SqlCommand(queryString, connection);
                //command.ExecuteNonQueryAsync();
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.Fill(dt);
                connection.Close();
                
            }
        }
        //public DataTable LoadAnimalData()
        //{
        //    System.Configuration.ConnectionStringSettings connectionString = ConfigurationManager.ConnectionStrings["AnimalDBConnectionString"];
        //    //string queryString = "SELECT * FROM dbo.Animal;";          
        //    // using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
        //    // {
        //    //     SqlCommand command = new SqlCommand(queryString, connection);
        //    //    connection.Open();

        //    //    SqlDataReader reader = command.ExecuteReader();

        //    //    // Call Read before accessing data.
        //    //    while (reader.Read())
        //    //    {
        //    //        DataTable dt = new DataTable();
                    
        //    //        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
        //    //    }

        //    //}


        //    //SqlConnection con = new SqlConnection(connectionString.ConnectionString);
        //    //SqlDataAdapter ada = new SqlDataAdapter("SELECT * FROM dbo.Animal", con);
        //    //DataTable dt = new DataTable();
        //    //var test= ada.Fill(dt);

        //    //for (int i = 0; i < dt.Rows.Count; i++)
        //    //{
        //    //    DataRow dr = dt.Rows[i];
        //    //    ListViewItem listitem = new ListViewItem(dr["Id"].ToString());
        //    //    listitem.SubItems.Add(dr["name"].ToString());
        //    //    //listViewListOfRegisteredAnima.Items.Add(listitem);
        //    //}



        //    //DataSet dataset = new DataSet();

        //    //var connectionString = ConfigurationManager.ConnectionStrings["CharityManagement"].ConnectionString;
        //    return null;
        //}

        public void NewRowInAnimal(string id, string name, double age, string gender, string categori, string info)
        {

        }
        public void NewRowInMammals(string species, int teeth, int quarantine)
        {

        }
        public void SaveMammalAnimal(string id, string name, double age, string gender, string categori, string info, string species, int teeth, int quarantine)
        {

        }


    }
}
