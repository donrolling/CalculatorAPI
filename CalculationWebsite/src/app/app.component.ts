import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Operations } from '../models/Operations';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Calculation Website';
  baseUrl: string = "https://localhost:32770/";
  calculateUrl: string = `${ this.baseUrl }api/math`;

  mathFormGroup = new FormGroup({
    inputA: new FormControl(0),
    inputB: new FormControl(0)
  });
  operatorSymbol: string = "+";
  operator: Operations = Operations.Add;
  OperationsType = Operations;
  answer: number = 0; 
  a: number = 0; 
  b: number = 0; 

  constructor(private http: HttpClient){}

  setOperator(value: Operations){
    this.operator = value;
  }
  
  onSubmit() {
    switch(this.operator){
      case Operations.Add:
        this.operatorSymbol = "+";
        break;
      case Operations.Subtract:
        this.operatorSymbol = "-";
        break;
      case Operations.Multiply:
        this.operatorSymbol = "*";
        break;
      case Operations.Divide:
        this.operatorSymbol = "/";
        break;
    }
    this.a = parseFloat(this.mathFormGroup.controls.inputA.value);
    this.b = parseFloat(this.mathFormGroup.controls.inputB.value);
    var calculateOperation = {
      inputA: this.a,
      inputB: this.b,
      operation: this.operator
    };
    const data = JSON.stringify(calculateOperation);
    console.log(data);
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Accept': '*/*',
      'Access-Control-Allow-Methods': 'GET, PUT, POST, DELETE, HEAD, OPTIONS',
      'Access-Control-Allow-Origin': '*'
    });
    this.http
      .post(
        this.calculateUrl,
        data, 
        {
          headers: headers
        }
      ).subscribe((data: number) => this.answer = data);
  }
  
  numberOnly(event): boolean {
    const charCode = (event.which) ? event.which : event.keyCode;
    if (charCode === 46) {
      return true;
    }
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
      return false;
    }
    return true;
  }
}
