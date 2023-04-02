import { Component, OnInit } from '@angular/core';
import { Shipper } from '../models/shipper';
import { ShippersService } from '../Services/shipper.service';

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
      // reset form or navigate to shipper list
    }, error => {
      console.error('Error adding shipper:', error);
    });
  }
}
