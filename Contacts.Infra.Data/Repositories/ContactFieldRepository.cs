using Contacts.Domain.Models.Contacts;
using Contacts.Infra.Data.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Contacts.Infra.Data.Repositories
{
    public class ContactFieldRepository : IContactFieldRepository
    {
        readonly IContext _context;

        public ContactFieldRepository(IContext context) => _context = context;

        public IEnumerable<ContactField> Get()
        {
            using (SqlConnection connection = _context.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM ContactField";
                return connection.Query<ContactField>(sql);
            }
        }

        public ContactField Get(Guid id)
        {
            using (SqlConnection connection = _context.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM ContactField WHERE Id = @Id";
                return connection.Query<ContactField>(sql, new { Id = id}).FirstOrDefault();
            }
        }

        public IEnumerable<ContactField> GetFieldsByContactId(Guid id)
        {
            using (SqlConnection connection = _context.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM ContactField WHERE ContactId = @Id";
                return connection.Query<ContactField>(sql, new { ContactId = id });
            }
        }

        public ContactField Insert(ContactField obj)
        {
            using (SqlConnection connection = _context.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO ContactField VALUES (@Id, @RegistrationDate, @ContactId, @Type, @Value)";
                connection.Query<ContactField>(sql, obj);
                return obj;
            }
        }

        public ContactField Update(ContactField obj)
        {
            using (SqlConnection connection = _context.GetConnection())
            {
                connection.Open();
                string sql = @"UPDATE ContactField

                               SET
                               Type = @Type,
                               Value = @Value
                               WHERE Id = @Id";

                connection.Query<ContactField>(sql, obj);
                return obj;
            }
        }

        public void Delete(Guid id)
        {
            using (SqlConnection connection = _context.GetConnection())
            {
                connection.Open();
                string sql = @"DELETE FROM ContactField WHERE Id = @Id";

                connection.Query<ContactField>(sql, new { Id = id});
            }
        }
    }
}