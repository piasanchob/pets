import { Component, OnInit } from '@angular/core';
import {NgbDateStruct} from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    //this.birthday.minDate = new Date(1900,0);
  }

  getInputValue(nombre:string,id:string,email:string,nacimiento:string,usuario:string,password:string ){
    console.log(nombre,id,email,nacimiento, usuario,password)
  }

  birthday: NgbDateStruct;

}
