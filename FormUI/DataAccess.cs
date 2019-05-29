using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBConnectionHelper.CnnValue("Books")))
            {
                //var output = connection.Query<Person>($"select * from People where Name = '{ name }'").ToList();
                var output = connection.Query<Person>("dbo.booksStoredProcedureAuthors @Name", new { Name = name}).ToList();
                return output;
            }  
        }

        public void InserPerson(string authorId, string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBConnectionHelper.CnnValue("Books")))
            {
                //Person InsertPerson = new Person { AuthorId = authorId, Name = name };

                //Person Insert = new Person();
                //Insert.AuthorId = authorId;
                //Insert.Name = name;

                List<Person> people = new List<Person>();
                people.Add( new Person {AuthorId = authorId, Name = name});

                connection.Execute("dbo.Books_Sp @authorId, @name", people);
            }
            
        }
    }
}
