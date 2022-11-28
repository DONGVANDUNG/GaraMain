import { HttpClientModule } from '@angular/common/http';
import { Component, OnInit, ViewChild } from '@angular/core';
import { AppGaraLoginComponent } from './app-gara-login/app-gara-login.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'angular-gara';
  //@ViewChild('login') login : AppGaraLoginComponent;
  constructor(private http :HttpClientModule){

  }
  ngOnInit(): void {

  }
}
