import { Component, OnInit } from '@angular/core';
import { ShippersService } from '../Services/shipper.service';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-shipper-delete',
  templateUrl: './shipper-delete.component.html',
  styleUrls: ['./shipper-delete.component.css']
})
export class ShipperDeleteComponent implements OnInit {
  shipperId: number;

  constructor(private route: ActivatedRoute, private shipperService: ShippersService) {
    this.shipperId = 0; // Puedes poner cualquier valor por defecto que quieras
  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.shipperId = +params['id'];
    });
  }

  deleteShipper() {
    this.shipperService.deleteShipper(this.shipperId).subscribe(shipper => {
      console.log('Shipper deleted successfully:', shipper);
      // reset form or navigate to shipper list
    }, error => {
      console.error('Error deleting shipper:', error);
    });
  }
}
