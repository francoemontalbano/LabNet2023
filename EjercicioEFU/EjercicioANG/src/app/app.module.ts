import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { ShippersComponent } from './shippers/shippers.component';
import { RouterModule } from '@angular/router';
import { ShipperIdComponent } from './shipper-id/shipper-id.component';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { AddShipperComponent } from './add-shipper/add-shipper.component';




@NgModule({
  declarations: [
    AppComponent,
    ShippersComponent,
    ShipperIdComponent,
    HomeComponent,
    AddShipperComponent,
  ],
  exports: [RouterModule],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
