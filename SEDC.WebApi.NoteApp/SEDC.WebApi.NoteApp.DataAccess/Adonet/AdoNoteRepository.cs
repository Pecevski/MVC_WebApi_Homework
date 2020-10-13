using SEDC.WebApi.NoteApp.DataModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SEDC.WebApi.NoteApp.DataAccess.Adonet
{
    public class AdoNoteRepository : IRepository<Note>
    {
        private readonly string _connectionString;

        public AdoNoteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<Note> GetAll()
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = "Select * from dbo.[Notes]";

            SqlDataReader dataReader = cmd.ExecuteReader();

            List<Note> notes = new List<Note>();

            while (dataReader.Read())
            {
                var note = new Note
                {
                    Id = (int)dataReader["Id"],
                    Text = (string)dataReader["Text"],
                    Color = (string)dataReader["Color"],
                    Tag = (int)dataReader["Tag"]
                };

                notes.Add(note);
            }
            connection.Close();

            return notes;
        }

        public void Insert(Note entity)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;

                    cmd.CommandText = $"Insert into dbo.[Notes](Text, Color, Tag)" + $"Values(@noteText, @noteColor, @noteTag)";

                    cmd.Parameters.AddWithValue("@noteText", entity.Text);
                    cmd.Parameters.AddWithValue("@noteColor", entity.Color);
                    cmd.Parameters.AddWithValue("@noteTag", entity.Tag);

                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void Update(Note entity)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;

            cmd.CommandText = $"Update dbo.[Notes]" +
                              $"Set Text = @noteText, Color = @noteColor, Tag = @noteTag" +
                              $"Where Id = @Id";

            cmd.Parameters.AddWithValue("@noteText", entity.Text);
            cmd.Parameters.AddWithValue("@noteColor", entity.Color);
            cmd.Parameters.AddWithValue("@noteTag", entity.Tag);
            cmd.Parameters.AddWithValue("@Id", entity.Id);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Remove(Note entity)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;

            cmd.CommandText = $"Delete from dbo.[Notes] Where Id = @Id";

            cmd.Parameters.AddWithValue("@Id", entity.Id);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
