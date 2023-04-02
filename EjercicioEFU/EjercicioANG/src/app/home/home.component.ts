import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  constructor(private router: Router) { }

  mostrarShippers() {
    this.router.navigate(['/shippers']);
  }

  buscarShippersId() {
    this.router.navigate(['/shipper-id']);
  }

  agregarShipper() {
    this.router.navigate(['/shippers/add']);
  }

  deleteShipper(){
    this.router.navigate(['/delete/shipper'])
  }


}
