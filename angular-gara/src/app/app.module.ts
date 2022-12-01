import { AppGaraLoginComponent } from './app-gara-login/app-gara-login.component';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './employee/employee.component';
import { HttpClientModule, HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ProductComponent } from './product/product.component';
import { ListProductComponent } from './list-product/list-product.component'
import { AgGridModule } from 'ag-grid-angular';
import { AppNavigationComponent } from './app-navigation/app-navigation.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    AppGaraLoginComponent,
    ProductComponent,
    ListProductComponent,
    AppNavigationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    AgGridModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
