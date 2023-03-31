import { Component } from '@angular/core';
import { ShippersService } from '../Services/shipper.service';
import { Shipper } from '../models/shipper';
import { Router } from '@angular/router'; 


import Swal from 'sweetalert2';


@Component({
  selector: 'app-shipper-id',
  templateUrl: './shipper-id.component.html',
  styleUrls: ['./shipper-id.component.css']
})
export class ShipperIdComponent {
  shipperId: number = 0;
  shipper: Shipper = {} as Shipper;

  constructor(private shippersService: ShippersService, private router: Router) { }

  onSubmit() {
    this.shippersService.getShipperById(this.shipperId).subscribe(
      response => {
        this.shipper = response;
        this.router.navigate(['/shippers', this.shipperId]);
      },
      error => {
        console.log(error);
        Swal.fire({
          icon: 'error',
          title: 'Error',
          text: 'Ingrese un ID válido. Intentelo nuevamente',
        });
      }
    );
  }
}






