import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ShippersComponent } from './shippers/shippers.component';
import { ShipperIdComponent } from './shipper-id/shipper-id.component';
import { ShipperAddComponent } from './shipper-add/shipper-add.component';
import { ShipperDeleteComponent } from './shipper-delete/shipper-delete.component';


const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'shippers', component: ShippersComponent },
  { path: 'shipper/:id', component: ShipperIdComponent },
  { path: 'shippers/add', component: ShipperAddComponent },
  { path: 'delete/shipper', component: ShipperDeleteComponent },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
