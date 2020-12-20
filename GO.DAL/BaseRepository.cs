using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GO.DAL
{
    public class BaseRepository
    {
        protected IDbConnection connect;
        public BaseRepository()
        {
            connect = new SqlConnection(@"Ket noi database");
        }
    }
}
