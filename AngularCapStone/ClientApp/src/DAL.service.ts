import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { QandA } from './app/interfaces/IQandA';
import { Favorites } from './app/interfaces/IFavorites';



@Injectable({
  providedIn: 'root'
})
export class DALService {
  constructor(private http: HttpClient) { }


  
  QandAUrl = '/api/QandA';
  FavUrl = '/api/Favorites';



  getAllQandA() {
    let test = this.http.get(this.QandAUrl);
    console.log(test);
    return this.http.get(this.QandAUrl);
  }



  getAllFavorites(id) {
    return this.http.get(`${this.FavUrl}/${id}`);
  }



 /* createEmployee(emp) {
    return this.http.post<QandA>(this.apiUrl, emp); //2 itesm, the url and the data we want to pass
  }



  updateEmployee(emp) {
    return this.http.post<Employee>(this.apiUrl, emp);
  } */

}
