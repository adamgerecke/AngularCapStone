import { Component } from '@angular/core';
import { DALService } from 'src/DAL.service';
import { Favorites } from 'src/app/interfaces/IFavorites';

@Component({
    selector: 'app-favorites',
    templateUrl: './favorites.component.html',
    styleUrls: ['./favorites.component.css']
})
/** favorites component*/
export class FavoritesComponent {
    /** favorites ctor */
  constructor(private dal: DALService) {

  }

  favlist;

  ngOnInit(): void {
    this.dal.getAllFavorites().subscribe(
      (data: Favorites) =>
        this.favlist = data
    );
    console.log(this.dal.getAllFavorites());
  }
}
