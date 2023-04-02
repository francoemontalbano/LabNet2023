import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders  } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Shipper } from '../models/shipper';

@Injectable({
  providedIn: 'root'
})



export class ShippersService {

  private apiUrl = 'https://localhost:44330/api/shippers';

  constructor(private http: HttpClient) { }

  getShippers(): Observable<Shipper[]> {
    return this.http.get<Shipper[]>(this.apiUrl);
  }

  getShipperById(shipperId: number): Observable<Shipper> {
    return this.http.get<Shipper>(`${this.apiUrl}/${shipperId}`);
  }

  addShipper(shipper: Shipper) {
    return this.http.post<Shipper>(`${this.apiUrl}/shippers`, shipper);
  }

  updateShipper(shipper: Shipper): Observable<any> {
    return this.http.put(`${this.apiUrl}/${shipper.shipperId}`, shipper);
  }

  deleteShipper(shipperId: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/${shipperId}`)
  }


}
