import { Component, OnInit } from '@angular/core';
import { Shipper } from '../models/shipper';
import { ShippersService } from '../Services/shipper.service';
import Swal from 'sweetalert2';


@Component({
  selector: 'app-shipper-add',
  templateUrl: './shipper-add.component.html',
  styleUrls: ['./shipper-add.component.css']
})
export class ShipperAddComponent implements OnInit {
  newShipper: Shipper = {
    shipperId: 0,
    CompanyName: '',
    Phone: ''
  };
  

  constructor(private shipperService: ShippersService) { }

  ngOnInit() {
  }

  addShipper() {
    this.shipperService.addShipper(this.newShipper).subscribe(shipper => {
      console.log('Shipper added successfully:', shipper);
      Swal.fire({
        icon: 'success',
        title: 'Shipper añadito exitosamente!',
        showConfirmButton: false,
        timer: 1500
      });
    }, error => {
      console.error('Error adding shipper:', error);
      Swal.fire({
        icon: 'error',
        title: 'Error al añadir el shipper',
        text: 'Checkea tus datos y volve a intentar',
        confirmButtonText: 'OK'
      });
    });
  }
}




