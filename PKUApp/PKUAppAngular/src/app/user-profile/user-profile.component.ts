import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { UserService } from './../shared/services/user.service';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.css']
})
export class UserProfileComponent implements OnInit {

  constructor(private userService: UserService) { }
  Limits: any;
  Name: string="";
  ModalTitle: string="";
  ActivateEditUserSettings: boolean=false
  ActivateEditUserLimits: boolean=false

  ngOnInit(): void {
    this.getName();
    this.getLimits();
  }

  editSettings(){
    this.ActivateEditUserSettings=true;
  }

  editLimits(){
    this.ActivateEditUserLimits=true;
  }

  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;

  closeClickFromOutside(){
    this.ActivateEditUserSettings=false;
    this.ActivateEditUserLimits=false;

    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();

    this.getName();
    this.getLimits();
  }

  closeClick(){
    this.ActivateEditUserSettings=false;
    this.ActivateEditUserLimits=false;

    this.getName();
    this.getLimits();
  }

  getName(){
    this.userService.getName()
    .subscribe(res =>{this.Name=res;});
  }

  getLimits(){

  }
  
}
