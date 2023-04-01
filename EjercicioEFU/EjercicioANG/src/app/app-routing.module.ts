import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ShippersComponent } from './shippers/shippers.component';
import { ShipperIdComponent } from './shipper-id/shipper-id.component';
import { AddShipperComponent } from './add-shipper/add-shipper.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'shippers', component: ShippersComponent },
  { path: 'shipper/:id', component: ShipperIdComponent },
  // { path: 'shipper-id', component: ShipperIdComponent },
  { path: 'add-shipper', component: AddShipperComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
