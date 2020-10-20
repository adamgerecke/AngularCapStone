using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCapStone.Models;
using AngularCapStone.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularCapStone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritesController : ControllerBase
    {
        private IDAL dal;
        public FavoritesController(IDAL dal)
        {
            this.dal = dal;
        }

        [HttpGet("addFavs")]
        public void addFavs()
        {
            Favorites myFavs = new Favorites() { id = 3, userid = "RatKing" };
            dal.AddToFavorites(myFavs);
        }

        [HttpGet("Favorites")]
        public IEnumerable<Favorites> GetFav()
        {
            return dal.GetFavorites();
        }

        [HttpPost]
        public void DeleteFav()
        {
            Favorites myFavs = new Favorites() { id = 1, userid = "RatKing" };
            dal.RemoveFromFavorites(myFavs);
        }
    }
}
