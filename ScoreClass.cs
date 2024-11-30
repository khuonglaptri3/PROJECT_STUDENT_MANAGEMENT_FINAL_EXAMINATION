using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    class ScoreClass
    {
        DBconnect connect = new DBconnect();

        // Create a function to add score
        public bool insertScore(int stdid, string courName, double scor, string desc)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score (StudentId, CourseName, Score, Description) VALUES (@stid, @cn, @sco, @desc)", connect.getconnection);
            //@stid, @cn, @sco, @desc
            command.Parameters.Add("@stid", SqlDbType.Int).Value = stdid;
            command.Parameters.Add("@cn", SqlDbType.VarChar).Value = courName;
            command.Parameters.Add("@sco", SqlDbType.Float).Value = scor;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        // Create a function to get list
        public DataTable getList(SqlCommand command)
        {
            command.Connection = connect.getconnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Create a function to check if a course score already exists
        public bool checkScore(int stdId, string cName)
        {
            DataTable table = getList(new SqlCommand("SELECT * FROM score WHERE StudentId= '" + stdId + "' AND CourseName= '" + cName + "'"));
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to edit score data
        public bool updateScore(int stdid, string scn, double scor, string desc)
        {
            SqlCommand command = new SqlCommand("UPDATE score SET Score=@sco, Description=@desc WHERE StudentId=@stid AND CourseName=@scn", connect.getconnection);
            //@stid, @sco, @desc
            command.Parameters.Add("@scn", SqlDbType.VarChar).Value = scn;
            command.Parameters.Add("@stid", SqlDbType.Int).Value = stdid;
            command.Parameters.Add("@sco", SqlDbType.Float).Value = scor;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        // Create a function to delete a score data
        public bool deleteScore(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE StudentId=@id", connect.getconnection);
            //@id
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
    }
}
