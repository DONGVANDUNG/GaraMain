import { Component, OnInit, ViewChild } from '@angular/core';
import {ModalDirective} from "ngx-bootstrap/modal";

@Component({
  selector: 'app-gara-login',
  templateUrl: './app-gara-login.component.html',
  styleUrls: ['./app-gara-login.component.css']
})
export class AppGaraLoginComponent implements OnInit {
  @ViewChild('logins') modal: ModalDirective;
  constructor() { }

  user = {
    username: "",
    password: "",
  }

  ngOnInit(): void {
    //this.login();
  }

  login() {
    if (this.user.password === "123" && this.user.username === "admin") {
      window.location.href = "/home";
    }
  }
  show() {
    this.modal.show();
  }
}
