using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;


namespace AdemAKKUS.DbHelpers
{
    public class Helper
    {
    protected static readonly string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
  }
}
