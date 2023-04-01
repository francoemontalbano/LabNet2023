import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders  } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Shipper } from '../models/shipper';


const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})



export class ShippersService {

  private apiUrl = 'https://localhost:44330/api/shippers';

  constructor(private http: HttpClient) { }

  getShippers(): Observable<Shipper[]> {
    return this.http.get<Shipper[]>(this.apiUrl);
  }

  getShipperById(id: number): Observable<Shipper> {
    return this.http.get<Shipper>(`${this.apiUrl}/${id}`);
  }

  addShipper(shipper: Shipper): Observable<Shipper> {
    return this.http.post<Shipper>(this.apiUrl, shipper, httpOptions);
  }

}
