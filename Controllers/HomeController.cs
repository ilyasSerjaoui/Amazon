using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using amazon.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace amazon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string em)
        {
            string connstring1 = "server=192.168.64.2; port=3306; database=test; user=learnmysql; password=password;";
            MySqlConnection mySqlConnection1 = new MySqlConnection(connstring1);
            mySqlConnection1.Open();
            MySqlCommand mySqlCommand1 = new MySqlCommand("SELECT COUNT(*) FROM cart WHERE email='" + em + "'", mySqlConnection1);
            ViewData["countelements"] = Convert.ToInt32(mySqlCommand1.ExecuteScalar());
            string path = @"Demo/cart.txt";
            getdata gd = new getdata();
            StreamReader streamReader = new StreamReader(path);
            List<string> itemfile = new List<string>();
            if (em != null)
            {
                string constring = "server=192.168.64.2; port=3306; database=test; user=learnmysql; password=password;";
                MySqlConnection mySqlConnection = new MySqlConnection(constring);
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM accounts WHERE email='" + em + "'", mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    TempData["fn"] = "Hello, " + mySqlDataReader["f_n"].ToString();
                }
            }
            else
            {
                TempData["fn"] = "login";
            }
            ViewData["email"] = em;
            ViewData["f-n"]=TempData["fn"];
            while (!streamReader.EndOfStream)
            {
                ViewBag.cartCount = streamReader.Read().ToString().Length;
            }
            return View(gd.Select("SELECT * FROM home"));
        }
        public IActionResult Details(string Name, string Em, string email)
        {
            string connstring1 = "server=192.168.64.2; port=3306; database=test; user=learnmysql; password=password;";
            MySqlConnection mySqlConnection1 = new MySqlConnection(connstring1);
            mySqlConnection1.Open();
            MySqlCommand mySqlCommand1 = new MySqlCommand("SELECT COUNT(*) FROM cart WHERE email='" + email + "'", mySqlConnection1);
            ViewData["countelements"] = Convert.ToInt32(mySqlCommand1.ExecuteScalar());
            string c = "(_\\.?)";
            ViewBag.name = Regex.Replace(Name, c, " ");
            getdata gd = new getdata();
            Home home = new Home();
            ViewData["f-n"] = Em;
            ViewData["em"] = email;
            
            return View(gd.Select("SELECT * FROM home where name='"+ ViewBag.name + "'"));
        }
        public IActionResult Cartitem(string name, string price, string image, string Em, string rating, string type, string email)
        {
            string path = @"Demo/cart.txt";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(name);
            streamWriter.WriteLine(price);
            streamWriter.WriteLine(image);
            streamWriter.WriteLine(rating);
            streamWriter.WriteLine(type);
            streamWriter.Close();
            ViewData["f-n"] = Em;
            StreamReader streamReader = new StreamReader(path);
            List<string> itemfile = new List<string>();
            getdata gd = new getdata();
            string connstring1 = "server=192.168.64.2; port=3306; database=test; user=learnmysql; password=password;";
            MySqlConnection mySqlConnection1 = new MySqlConnection(connstring1);
            mySqlConnection1.Open();
            MySqlCommand mySqlCommand1 = new MySqlCommand("SELECT * FROM cart WHERE name='" + name + "' and email='"+email+"'", mySqlConnection1);
            MySqlDataReader mySqlDataReader = mySqlCommand1.ExecuteReader();
            if (mySqlDataReader.Read())
            {
                string connstring = "server=192.168.64.2; port=3306; database=test; user=learnmysql; password=password;";
                MySqlConnection mySqlConnection = new MySqlConnection(connstring);
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT COUNT(*) FROM cart WHERE email='" + email + "'", mySqlConnection);
                ViewData["countelements"] = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                return View(gd.Select("SELECT * FROM cart Where email='" + email + "'"));
            }
            else
            {
                gd.Insert("INSERT INTO cart(id, name, price, howmush, image, email, type) VALUES(NULL, '" + name + "', '" + price + "', '" + rating + "', '" + image + "', '" + email + "', '" + type + "')");
                string connstring = "server=192.168.64.2; port=3306; database=test; user=learnmysql; password=password;";
                MySqlConnection mySqlConnection = new MySqlConnection(connstring);
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT COUNT(*) FROM cart WHERE email='" + email + "'", mySqlConnection);
                ViewData["countelements"] = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                return View(gd.Select("SELECT * FROM cart Where email='" + email + "'"));
            }
        }
        public IActionResult Ceo(string fn, string sn, string em, string ps, string bd, string gem, string gps)
        {
            ViewData["f-n"] = "login";
            getdata gd = new getdata();
            gd.Insert("INSERT INTO accounts(id, f_n, s_n, email, pass1, pass2, b_d) VALUES(NULL, '"+fn+"', '"+sn+"', '"+em+"', '"+ps+"', 'null', '"+bd+"')");
            if (gem != null && gps != null)
            {
                string constring = "server=192.168.64.2; port=3306; database=test; user=learnmysql; password=password;";
                MySqlConnection mySqlConnection = new MySqlConnection(constring);
                mySqlConnection.Open();
                List<Home> datas = new List<Home>();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM accounts WHERE email='" + gem + "' and pass1='" + gps + "'", mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                mySqlDataReader.Read();
                return Redirect("/Home/Index?em=" + mySqlDataReader["email"].ToString());
            }
            else
            {
                return View();
            }
        }
    }
}