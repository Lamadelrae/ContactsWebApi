using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infra.Data.Interfaces
{
    public interface IContext
    {
        SqlConnection GetConnection();
    }
}
