using Dapper;
using Dapper.Contrib.Extensions;
using Remotion.Linq.Clauses;
using SEDC.WebApi.NoteApp.DataModel;
using SEDC.WebApi.NoteApp.DataModels.DbModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SEDC.WebApi.NoteApp.DataAccess.Dapper
{
    public class DapperNoteRepository : IRepository<Note>
    {
        private readonly string _connectionString;

        public DapperNoteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<Note> GetAll()
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var notes = connection
                            .Query<Note>("Select * from dbo.[Notes]")
                            .ToList();
                return notes;
            }
        }

        public void Insert(Note entity)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.Insert(entity);
            }
        }

        public void Update(Note entity)
        {
           using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.Update(entity);
            }
        }

        public void Remove(Note entity)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.Delete(entity);
            }
        }
    }
}
