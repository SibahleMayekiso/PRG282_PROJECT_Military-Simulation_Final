using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PRG282_PROJECT
{
    
    class FileNotExistException: ApplicationException //This is the custom exeption class
    {
        public void NoFileException()
        {
            MessageBox.Show("Error! The file could not be connected to. Please check to see if the file exists");
        }
    }
    class FileHandler
    {
        SqlConnection conn = new SqlConnection("Server=.; Initial Catalog=MilitaryDB; Integrated Security=SSPI");
        
        public void openConnection()
        {
            //Below is the implementation of our custom exception "FileNotExistException"
            try
            {
                conn.Open();
            }
            catch (FileNotExistException ex)
            {

                ex.NoFileException();
            }
        }

        //List<Aircraft> lstAircraft = new List<Aircraft>();

        //This method will be used to get the data from the database and store it into 
        // a DataTable
        //public void getAircraftData()
        //{
        //    string query = @"SELECT * FROM Aircraft";

        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();

        //    adapter.Fill(table);

        //    //Here we are adding contents of the DataTable into a list ("lstAircraft")
        //    foreach (DataRow row in table.Rows)
        //    {
        //        lstAircraft.Add(new Aircraft(row["ID"], row["AircraftName"], row["Model"], row["FuelTankSize"], row["TopSpeed"], row["Health"], row["Weapon"], row["Ammunition"], row["DamageScale"], row["Quantity"]));
        //    }
        //}

        
        
    }
}
