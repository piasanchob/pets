import { Component, OnInit } from '@angular/core';
import { trigger, state, style, animate, transition } from '@angular/animations';
import { Veterinarios } from 'src/app/models/vets';
import { VetsService } from 'src/app/services/vets.service';

@Component({
  selector: 'app-veterinarios',
  templateUrl: './veterinarios.component.html',
  styleUrls: ['./veterinarios.component.scss'],
  animations: [
    //animations triggers go here
    trigger(
      'openCloseSideMenu', [
        state('closed', style({
          'margin-left': '-80rem',
        })),
        state('open', style({
          'margin-left': "0",
        })),
        transition('open => closed', [animate('0.2s')]),
        transition('closed => open', [animate('0.2s')])
      ]
    )
  ]
})
export class VeterinariosComponent implements OnInit {


  veterinarios: Veterinarios[]=[];

  constructor(private vetsService:VetsService) { }

  
  ngOnInit(): void {

    this.veterinarios = this.vetsService.getVets();
    console.log(this.veterinarios);
  }

  sideMenuOpen = false;

  closeSideMenu(){
    this.sideMenuOpen = false;
  }

  openSideMenu(){
    this.sideMenuOpen = true;
  }

}
