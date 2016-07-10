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
    public class ExecutorRepository
    {        
        public static ExecutorCollection GetList()
        {
            ExecutorCollection tempList = new ExecutorCollection();

            string queryTxt = "SELECT * FROM tbExecutor";

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

        public static Executor GetItem(int id)
        {
            Executor myExcutor = new Executor();

            string queryTxt =  "SELECT * FROM tbExecutor t Where t.id = @id";

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand(queryTxt, myConnection))
                {
                    myCommand.CommandType = CommandType.Text;
                    myCommand.Parameters.AddWithValue("@id", id);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            myExcutor = FillDataRecord(myReader);
                        }

                        myReader.Close();
                    }
                }
            }
            return myExcutor;
        }

        public static void Save(Executor myExecutor)
        {
            string queryTxt;
            if (myExecutor.ID == 0)
            {
                queryTxt = "INSERT INTO tbExecutor" +
                           " (FIRST_NAME, SECOND_NAME, PATRONIMIC)" +
                           " VALUES" +
                           " (@FIRST_NAME, @SECOND_NAME, @PATRONIMIC)";
            }
            else
            {
                queryTxt = "UPDATE tbExecutor" +
                           " SET FIRST_NAME = @FIRST_NAME," +
                               " SECOND_NAME = @SECOND_NAME," +
                               " PATRONIMIC = @PATRONIMIC" +
                           " WHERE tbExecutor.id = @ID";
            }

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand(queryTxt, myConnection))
                {
                    myCommand.CommandType = CommandType.Text;

                    myCommand.Parameters.AddWithValue("@FIRST_NAME", myExecutor.FirstName);
                    myCommand.Parameters.AddWithValue("@SECOND_NAME", myExecutor.SecondName);
                    myCommand.Parameters.AddWithValue("@PATRONIMIC", myExecutor.Patronimic);
                    myCommand.Parameters.AddWithValue("@ID", myExecutor.ID);    

                    myConnection.Open();
                    int numberOfRecordsAffected = myCommand.ExecuteNonQuery();
                    if (numberOfRecordsAffected == 0)
                    {
                        throw new DBConcurrencyException("Can't update Executor as it has been updated by someone else");
                    }

                }
                myConnection.Close();
            }

        }

        public static bool Delete(int id)
        {
            int result = 0;
            string queryTxt = "DELETE FROM tbExecutor" +
                               " WHERE tbExecutor.ID = @ID";
            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand(queryTxt, myConnection))
                {
                    myCommand.CommandType = CommandType.Text;
                    myCommand.Parameters.AddWithValue("@id", id);
                    myConnection.Open();
                    result = myCommand.ExecuteNonQuery();
                }
                myConnection.Close();
            }
            return result > 0;
        }

        private static Executor FillDataRecord(SqlDataReader myDataRecord)
        {
            Executor myExecutor = new Executor();

            myExecutor.ID = myDataRecord.GetInt32(myDataRecord.GetOrdinal("ID"));
            myExecutor.FirstName = myDataRecord.GetString(myDataRecord.GetOrdinal("FIRST_NAME"));
            myExecutor.SecondName = myDataRecord.GetString(myDataRecord.GetOrdinal("SECOND_NAME"));
            myExecutor.Patronimic = myDataRecord.GetString(myDataRecord.GetOrdinal("PATRONIMIC"));

            return myExecutor;
        }
    }
}
