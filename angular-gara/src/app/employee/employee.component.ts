import { outputAst } from '@angular/compiler';
import { Component, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { AgGridAngular } from 'ag-grid-angular';
import { CellClickedEvent, ColDef } from 'ag-grid-community';
import { AppGaraLoginComponent } from '../app-gara-login/app-gara-login.component';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  @Output() onChangeSelections = new EventEmitter();
  @ViewChild("login", { static: false }) login: AppGaraLoginComponent;
  employeeSelected: any;
  columnDefs = [
    { field: 'make' },
    { field: 'model' },
    { field: 'price' },
    { field: 'price' },
    { field: 'price' },
    { field: 'price' },
  ];
  defaultColDef: ColDef = {
    sortable: true, filter: true
  }
  rowData = [
    { make: 'Toyota', model: 'Celica', price: 35000, filter: true },
    { make: 'Ford', model: 'Mondeo', price: 32000, filter: true },
    { make: 'Porsche', model: 'Boxter', price: 72000, filter: true }
  ];
  constructor() { }

  ngOnInit(): void {
  }
  viewDetail() {

  }
  onCellClicked(event: CellClickedEvent) {
    console.log(event.data)
  }
  clearSelection() {
   // this.login.api.deselectAll()
  }
}
