import { Component, OnInit } from '@angular/core';
import { ShippersService } from '../Services/shipper.service';
import { ActivatedRoute, Router } from '@angular/router';
import Swal from 'sweetalert2';



@Component({
  selector: 'app-shipper-delete',
  templateUrl: './shipper-delete.component.html',
  styleUrls: ['./shipper-delete.component.css']
})
export class ShipperDeleteComponent implements OnInit {
  shipperId: number;

  constructor(private route: ActivatedRoute, private shipperService: ShippersService) {
    this.shipperId = 0; 
  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.shipperId = +params['id'];
    });
  }

  deleteShipper() {
    this.shipperService.deleteShipper(this.shipperId).subscribe(shipper => {
      Swal.fire({
        icon: 'success',
        title: 'Success',
        text: 'Shipper eliminado exitosamente!',
        timer: 3000
      });
    }, error => {
      Swal.fire({
        icon: 'error',
        title: 'Error',
        text: 'Debe ingresar un ID para eliminar'
      });
    });
  }
}