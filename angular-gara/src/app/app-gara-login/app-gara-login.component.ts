import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-app-gara-login',
  templateUrl: './app-gara-login.component.html',
  styleUrls: ['./app-gara-login.component.css']
})
export class AppGaraLoginComponent implements OnInit {

  constructor() { }

  user = {
    username: "",
    password: "",
  }

  ngOnInit(): void {
    this.login();
  }

  login(){
    if(this.user.password === "123" && this.user.username === "admin" ){
      window.location.href = "/home";
    }
  }
}
