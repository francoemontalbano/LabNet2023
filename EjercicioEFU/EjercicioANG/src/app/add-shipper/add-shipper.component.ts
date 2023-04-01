import { Component, OnInit } from '@angular/core';
import { Shipper } from '../models/shipper';
import { ShippersService } from '../Services/shipper.service';


@Component({
  selector: 'app-add-shipper',
  templateUrl: './add-shipper.component.html',
  styleUrls: ['./add-shipper.component.css']
})
export class AddShipperComponent {
  shipperId: number | null = null;
  CompanyName: string = '';
  Phone: string = '';

  constructor(private shipperService: ShippersService) { }

  onSubmit() {
    const newShipper: Shipper = {
      shipperId: null,
      CompanyName: this.CompanyName,
      Phone: this.Phone
    };
    
    this.shipperService.addShipper(newShipper).subscribe();
  }
}
