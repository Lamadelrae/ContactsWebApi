using Contacts.Domain.Models.Contacts;
using Contacts.Infra.Data.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Contacts.Infra.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        readonly IContext _context;

        public ContactRepository(IContext context) => _context = context;

        public IEnumerable<Contact> Get()
        {
            using (SqlConnection connection = _context.GetConnection())
            {
                connection.Open();

                string sql = "SELECT * FROM Contact";
                return connection.Query<Contact>(sql);
            }
        }

        public Contact Get(Guid id)
        {
            using (SqlConnection connection = _context.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM Contact WHERE Id = @Id";
                return connection.Query<Contact>(sql, new { Id = id }).FirstOrDefault();
            }
        }

        public Contact Insert(Contact obj)
        {
            using (SqlConnection connection = _context.GetConnection())
            {
                connection.Open();
                string sql = @"INSERT INTO Contact VALUES (@Id, @RegistrationDate, @Name)";
                connection.Query(sql, obj);
                return obj;
            }
        }

        public Contact Update(Contact obj)
        {
            using (SqlConnection connection = _context.GetConnection())
            {
                connection.Open();
                string sql = @"UPDATE Contact
            
                               SET
                               Name = @Name

                               WHERE Id = @Id";
                connection.Query(sql, obj);
                return obj;
            }
        }

        public void Delete(Guid id)
        {
            using (SqlConnection connection = _context.GetConnection())
            {
                connection.Open();
                string sql = @"DELETE FROM Contact WHERE Id = @Id";
                connection.Query(sql, new { Id = id });
            }
        }
    }
}