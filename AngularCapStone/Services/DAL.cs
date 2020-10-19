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
        public DAL (IConfiguration config)
        {
            connString = config.GetConnectionString("default");
        }
        public void AddQandA(QandA qandA)
        {
            SqlConnection conn = new SqlConnection(connString);
            //string command = "INSERT INTO QandA (qandA.Question, qandA.Answer) ";
            //command += "VALUES (@qandA.Question, @qandA.Answer)";

            //conn.Query(command);
            conn.Insert<QandA>(qandA);
        }

        public void addToFavorites(long id, string userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Favorites> GetFavorites()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QandA> GetQandA()
        {
            throw new NotImplementedException();
        }

        public void removeFromFavorites(long id, string userID)
        {
            throw new NotImplementedException();
        }
    }
}
