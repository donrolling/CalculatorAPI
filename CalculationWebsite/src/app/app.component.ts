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
  //baseUrl: string = 'http://localhost:32777/';
  baseUrl: string = 'http://drolling-calculator.centralus.azurecontainer.io/';
  calculateUrl: string = `${ this.baseUrl }api/math/decimals`;

  mathFormGroup = new FormGroup({
    inputA: new FormControl(0),
    inputB: new FormControl(0)
  });
  operatorSymbol: string = '+';
  operator: Operations = Operations.Add;
  OperationsType = Operations;
  answer: string = 'x';
  a: number = 0;
  b: number = 0;

  constructor(private http: HttpClient){}

  setOperator(value: Operations){
    this.operator = value;    
    switch(this.operator){
      case Operations.Add:
        this.operatorSymbol = '+';
        break;
      case Operations.Subtract:
        this.operatorSymbol = '-';
        break;
      case Operations.Multiply:
        this.operatorSymbol = '*';
        break;
      case Operations.Divide:
        this.operatorSymbol = '/';
        break;
    }
    this.answer = 'x';
  }

  onSubmit() {
    this.a = parseFloat(this.mathFormGroup.controls.inputA.value);
    this.b = parseFloat(this.mathFormGroup.controls.inputB.value);
    var calculateOperation = {
      inputA: this.a,
      inputB: this.b,
      operation: this.operator
    };
    this.http
      .post(
        this.calculateUrl,
        calculateOperation
      )
      .subscribe(
        (data: number) => {
          this.answer = data.toString()
        },
        error => {
          alert('A math error occured, check your inputs. Did you divide by zero?');
        }
      );
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
