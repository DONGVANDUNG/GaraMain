import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppGaraLoginComponent } from './app-gara-login/app-gara-login.component';
import { ListProductComponent } from './list-product/list-product.component';

const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot([
    {
      path: "",
      children: [
        { path: "home", component: ListProductComponent},
      ],
    },
    {
      path: "",
      children: [
        { path: "login", component: AppGaraLoginComponent},
      ],
    },


  ])],
  exports: [RouterModule]
})
export class AppRoutingModule { }
