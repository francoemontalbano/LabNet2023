// import { Component } from '@angular/core';
// import { ShippersService } from '../Services/shipper.service';
// import { Shipper } from '../models/shipper';
// import { Router } from '@angular/router'; 
// import Swal from 'sweetalert2';


// @Component({
//   selector: 'app-shipper-id',
//   templateUrl: './shipper-id.component.html',
//   styleUrls: ['./shipper-id.component.css']
// })
// export class ShipperIdComponent {
//   shipperId: number = 0;
//   shipper: Shipper = {} as Shipper;

//   constructor(private shippersService: ShippersService, private router: Router) { }

//   onSubmit() {
//     this.shippersService.getShipperById(this.shipperId).subscribe(
//       response => {
//         this.shipper = response;
//         this.router.navigate(['/shippers', this.shipperId]);
//       },
//       error => {
//         console.log(error);
//         Swal.fire({
//           icon: 'error',
//           title: 'Error',
//           text: 'Ingrese un ID válido. Intentelo nuevamente',
//         });
//       }
//     );
//   }
// }

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ShippersService } from '../Services/shipper.service';
import { Shipper } from '../models/shipper';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-shipper-id',
  templateUrl: './shipper-id.component.html',
  styleUrls: ['./shipper-id.component.css']
})
export class ShipperIdComponent implements OnInit {
  shipperId: number = 0;
  shipper: Shipper = {} as Shipper;
  isFirstLoad = true;

  constructor(private route: ActivatedRoute, private shippersService: ShippersService) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      const id = params.get('id');
      if (id !== null) {
        this.shipperId = +id;
        if (!this.isFirstLoad) { 
          this.getShipperById();
        }
        else {
          this.isFirstLoad = false; 
        }
      }
    });
  }
  

  getShipperById() {
    this.shippersService.getShipperById(this.shipperId).subscribe(
      response => {
        this.shipper = response;
      },
      error => {
        console.log(error);
        Swal.fire({
          icon: 'error',
          title: 'Error',
          text: 'No se pudo obtener el transportista. Intente nuevamente',
        });
      }
    );
  }
}







