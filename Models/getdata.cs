using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace amazon.Models
{
    public class getdata
    {
        public string restring { get; set; }
        public string SelectFromAcoount(string where)
        {
            string constring = "server=192.168.64.2; port=3306; database=test; user=learnmysql; password=password;";
            MySqlConnection mySqlConnection = new MySqlConnection(constring);
            mySqlConnection.Open();
            List<Home> datas= new List<Home>();
            MySqlCommand mySqlCommand = new MySqlCommand(where, mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while(mySqlDataReader.Read())
            {
                Home data = new Home();
                datas.Add(new Home()
                {
                    f_n = mySqlDataReader["f_n"].ToString(),
                    s_n = mySqlDataReader["s_n"].ToString(),
                    email = mySqlDataReader["email"].ToString(),
                    ps = mySqlDataReader["pass1"].ToString(),
                    bd = mySqlDataReader["b_d"].ToString()
                });
                datas.Add(data);
                string restring = "/Home/Index?em=" + mySqlDataReader["email"].ToString();
            }
            return restring;
        }
        public List<Home> Select(string where)
        {
            string constring = "server=192.168.64.2; port=3306; database=test; user=learnmysql; password=password;";
            MySqlConnection mySqlConnection = new MySqlConnection(constring);

            List<Home> datas = new List<Home>();
            mySqlConnection.Open();
            string sql = where;
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                Home data = new Home();

                datas.Add(new Home()
                {
                    name = mySqlDataReader["name"].ToString(),
                    image = mySqlDataReader["image"].ToString(),
                    price = mySqlDataReader["price"].ToString(),
                    type = mySqlDataReader["type"].ToString(),
                    howmush = (int)Convert.ToUInt32(mySqlDataReader["howmush"])
                });
                datas.Add(data);
            }
            return datas;
        }
        public void Insert(string insert)
        {
            string constring = "server=192.168.64.2; port=3306; database=test; user=learnmysql; password=password;";
            MySqlConnection mySqlConnection = new MySqlConnection(constring);
            mySqlConnection.Open();
            string sql = insert;
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
        }
    }
}
