using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using TaskManager.BusinessEntities.Collections;
using TaskManager.BusinessEntities;
using System.Data.SqlClient;
using System.Configuration;

namespace TaskManager.Domain.Concrete
{
  public class TaskRepository
    { 
      //Get List of Tasks
      public static TaskCollection GetList()
      {
          TaskCollection tempList = new TaskCollection();

          string queryTxt = "SELECT *, s.name as StateName" +
                            " FROM TaskManager.dbo.tbTask t" +
                            " left join TaskManager.dbo.tbExecutor e on t.id_executor = e.id" +
                            " left join TaskManager.dbo.tbState s on t.id_state = s.id";

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

      //Get item by ID Task
      public static TaskE GetItem(int id)
      {
          TaskE mytask = new TaskE();

          string queryTxt = "SELECT *, s.name as StateName" +
                            " FROM TaskManager.dbo.tbTask t" +
                            " left join TaskManager.dbo.tbExecutor e on t.id_executor = e.id" +
                            " left join TaskManager.dbo.tbState s on t.id_state = s.id" +
                            " Where t.id = @id";

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
                              mytask = FillDataRecord(myReader);
                          }
                     
                      myReader.Close();
                  }
              }
          }
          return mytask;
      }

      // Save/Insert Task
      public static void Save(TaskE myTask)
      {      
          string queryTxt;
          if (myTask.ID == 0)
          {
            queryTxt = "INSERT INTO tbTask" +
           " (NAME, [WORKLOAD], DATE_START," +
           " DATE_END, ID_EXECUTOR, ID_STATE)" +
           " VALUES" +
           " (@NAME, @WORKLOAD, @DATE_START," +
           " @DATE_END, @ID_EXECUTOR, @ID_STATE)";
          }
          else 
          {        queryTxt = "UPDATE tbTask" + 
                             " SET NAME = @NAME," +
                                 " WORKLOAD = @WORKLOAD," +
                                 " DATE_START = @DATE_START," +
                                 " DATE_END = @DATE_END," +
                                 " ID_EXECUTOR = @ID_EXECUTOR," +
                                 " ID_STATE = @ID_STATE" +
                             " WHERE tbTask.id = @ID";
          }

           using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
          {
              using (SqlCommand myCommand = new SqlCommand(queryTxt, myConnection))
              {
                  myCommand.CommandType = CommandType.Text;

                  myCommand.Parameters.AddWithValue("@NAME", myTask.Name);
                  myCommand.Parameters.AddWithValue("@WORKLOAD", myTask.Workload);
                  myCommand.Parameters.AddWithValue("@DATE_START", myTask.DateStart);
                  myCommand.Parameters.AddWithValue("@DATE_END", myTask.DateEnd);
                  myCommand.Parameters.AddWithValue("@ID_EXECUTOR", myTask.IdExecutor);
                  myCommand.Parameters.AddWithValue("@ID_STATE", myTask.IdState);
                  myCommand.Parameters.AddWithValue("@ID", myTask.ID);    
                 

                  myConnection.Open();
                  int numberOfRecordsAffected = myCommand.ExecuteNonQuery();
                  if (numberOfRecordsAffected == 0)
                  {
                      throw new DBConcurrencyException("Can't update Task as it has been updated by someone else");
                  }
                  
              }
              myConnection.Close();
          }
         
      }

      // Delete Task by ID
      public static bool Delete(int id)
      {
          int result = 0;
          string queryTxt = "DELETE FROM tbTask" +
                             " WHERE dbo.tbTask.ID = @ID";
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

      //Fill Object from DB
      private static TaskE FillDataRecord(IDataRecord myDataRecord)
      {
          TaskE myTask = new TaskE();

          myTask.ID = myDataRecord.GetInt32(myDataRecord.GetOrdinal("Id"));
          myTask.Name = myDataRecord.GetString(myDataRecord.GetOrdinal("Name"));
          myTask.Workload = myDataRecord.GetDecimal(myDataRecord.GetOrdinal("Workload"));
          myTask.DateStart = myDataRecord.GetDateTime(myDataRecord.GetOrdinal("Date_Start"));
          myTask.DateEnd = myDataRecord.GetDateTime(myDataRecord.GetOrdinal("Date_End"));
          myTask.IdState = myDataRecord.GetInt32(myDataRecord.GetOrdinal("ID_state"));
          myTask.IdExecutor = myDataRecord.GetInt32(myDataRecord.GetOrdinal("ID_executor"));
          myTask.Exec.FirstName = myDataRecord.GetString(myDataRecord.GetOrdinal("First_Name"));
          myTask.Exec.SecondName = myDataRecord.GetString(myDataRecord.GetOrdinal("Second_Name"));
          myTask.Exec.Patronimic = myDataRecord.GetString(myDataRecord.GetOrdinal("Patronimic"));
          myTask.Stat.Name = myDataRecord.GetString(myDataRecord.GetOrdinal("StateName"));         

          return myTask;
      }

    }
}
