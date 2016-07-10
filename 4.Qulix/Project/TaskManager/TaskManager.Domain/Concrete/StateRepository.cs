using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.BusinessEntities.Collections;
using TaskManager.BusinessEntities;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace TaskManager.Domain.Concrete
{
    public class StateRepository
    {
        
        public static StateCollection GetList()
        {
            StateCollection tempList = new StateCollection();

            string queryTxt = "SELECT * FROM tbState";

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand(queryTxt, myConnection))
                {
                    myCommand.CommandType = CommandType.Text;
                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            while (myReader.Read())
                            {
                                tempList.Add(FillDataRecord(myReader));
                            }
                        }
                        myReader.Close();
                    }
                }
            }
            return tempList;
        }

        private static State FillDataRecord(SqlDataReader myDataRecord)
        {
            State myState = new State();

            myState.ID = myDataRecord.GetInt32(myDataRecord.GetOrdinal("Id"));
            myState.Name = myDataRecord.GetString(myDataRecord.GetOrdinal("Name"));

            return myState;
        }
    }
}
