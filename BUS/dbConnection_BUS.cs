using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class dbConnection_BUS
    {
        dbConnection con = new dbConnection();

        public DataTable getData(string sql)
        {
            return con.getData(sql).Tables[0];
        }
    }
}
