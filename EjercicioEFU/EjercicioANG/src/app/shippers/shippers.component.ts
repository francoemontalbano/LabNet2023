import { Component} from '@angular/core';
import { ShippersService } from '../Services/shipper.service';
import { Shipper } from '../models/shipper';


@Component({
  selector: 'app-shippers',
  templateUrl: 'shippers.component.html',
  styleUrls: ['shippers.component.css']
})
export class ShippersComponent {

  shippers: Shipper[] = [];

  constructor(private shippersService: ShippersService) { }

  ngOnInit() {
    this.getShippers(); 
  }

  getShippers() {
    this.shippersService.getShippers().subscribe(
      response => {
        this.shippers = response;
      },
      error => {
        console.log(error);
      }
    );
  }
}
