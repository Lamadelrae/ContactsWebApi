using Contacts.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infra.Data.Context
{
    public class ContactsContext : IContext
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Server=Localhost\SQL2019;Database=Contacts;User Id=sa;Password=pass*123;");
        }
    }
}