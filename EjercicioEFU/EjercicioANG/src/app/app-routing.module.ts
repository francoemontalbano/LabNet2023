import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ShippersComponent } from './shippers/shippers.component';
import { ShipperIdComponent } from './shipper-id/shipper-id.component';



const routes: Routes = [
  { path: '', redirectTo: '/shippers', pathMatch: 'full' },
  { path: 'shippers', component: ShippersComponent },
  { path: 'shippers/buscar', component: ShipperIdComponent },
  



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
