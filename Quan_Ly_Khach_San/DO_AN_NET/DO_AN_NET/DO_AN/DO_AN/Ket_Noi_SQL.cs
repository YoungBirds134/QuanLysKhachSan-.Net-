using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace DO_AN
{
    public class Ket_Noi_SQL
    {
        string _tenMay{get;set;}
        string _tenCSDL {get;set;}
        string user{get;set;}
        string pass{get;set;}

       public SqlConnection conn;
        public Ket_Noi_SQL() { }
        public void Ket_Noi_SQLll(){
        
        conn= new SqlConnection("Data Source="+_tenMay+";Initial Catalog="+_tenCSDL+";User ID="+user+";Password="+pass+"");
        }


        public bool KT_KetNoiSQL(string tenmay, string tensql,string usersql,string passsql) {
            _tenMay = tenmay;
            _tenCSDL = tensql;
            user = usersql;
            pass = passsql;
            Ket_Noi_SQLll();
            
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
