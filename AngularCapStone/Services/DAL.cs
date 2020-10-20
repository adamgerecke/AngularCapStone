using AngularCapStone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using AngularCapStone.Services;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;



namespace AngularCapStone.Services
{
    public class DAL : IDAL
    {
        private string connString;
        private SqlConnection conn;

        public DAL (IConfiguration config)
        {
            connString = config.GetConnectionString("default");
            conn = new SqlConnection(connString);
        }
        public void AddQandA(QandA qandA)  //FINISHED
        {

            conn.Insert<QandA>(qandA);
        }

        public void AddToFavorites(Favorites myFave)
        {
            string query = "SELECT * FROM Favorites";
            List<Favorites> list = conn.Query<Favorites>(query).ToList();
            foreach (Favorites item in list)
            {
                if (item.Qid == myFave.Qid && item.UserID == myFave.UserID)
                {
                    return;
                }
            }
            conn.Insert<Favorites>(myFave);
        }

        public IEnumerable<Favorites> GetFavorites() //FINISHED
        {
            
            string query = "SELECT * FROM Favorites";
            return conn.Query<Favorites>(query).ToList();
        }

        public IEnumerable<QandA> GetQandA() //FINISHED
        {
            return conn.GetAll<QandA>().ToList();
        }

        public void RemoveFromFavorites(Favorites myFavs) //FINISHED
        {
            conn.Delete(myFavs);
        }
    }
}
