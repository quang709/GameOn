﻿using System;
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
            connect = new SqlConnection(@"Data Source=WIN-NFCBAIKD9UE\SQLEXPRESS;Initial Catalog=BlogGame;Integrated Security=True");
        }
    }
}
