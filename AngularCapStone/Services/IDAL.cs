using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCapStone.Models;

namespace AngularCapStone.Services
{
    public interface IDAL
    {
        IEnumerable<QandA> GetQandA();

        IEnumerable<Favorites> GetFavorites();

        void AddQandA(QandA qandA);

        void AddToFavorites(Favorites myFavs);

        void RemoveFromFavorites(Favorites myFavs);

    }
}
