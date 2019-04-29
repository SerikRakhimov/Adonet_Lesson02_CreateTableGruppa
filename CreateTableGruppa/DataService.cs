using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTableGruppa
{
    public class DataService
    {
        public void CreateGruppa()
        {
            string _connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\РахимовСерик\My\AcademyStep\VisualStudioProjects\ADONET\CreateTableGruppa\CreateTableGruppa\CreateTableGruppa\Database.mdf;Integrated Security = True";

            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand
                ("CREATE TABLE [dbo].[Gruppa]([Id] INT NOT NULL PRIMARY KEY,[NAME] NVARCHAR(50) NULL)", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlCommand = new SqlCommand("INSERT INTO Gruppa (Id, Name) VALUES (1, 'SIB-172-1')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Console.WriteLine("Таблица добавлена.");
            Console.ReadLine();
        }
    }
}
