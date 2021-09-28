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
  ActivateEditUserSettings: boolean=false;
  ActivateEditUserLimits: boolean=false;
  ActivateResetUserLimits: boolean=false;
  ActivateDelUserMed: boolean=false;
  ActivateAddEditUserMed: boolean=false;

  med:any;

  ngOnInit(): void {
    this.getName();
    this.getLimits();
    this.getMed();
  }

  editSettings(){
    this.ModalTitle="Edit Settings";
    this.ActivateEditUserSettings=true;
  }

  editLimits(){
    this.ModalTitle="Edit Limits";
    this.ActivateEditUserLimits=true;
  }

  resetLimits(){
    this.ModalTitle="Reset Limits";
    this.ActivateResetUserLimits=true;
  }

  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;

  closeClickFromOutside(){
    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();
  }

  closeClick(){
    this.ActivateEditUserSettings=false;
    this.ActivateEditUserLimits=false;
    this.ActivateResetUserLimits=false;
    this.ActivateAddEditUserMed=false;
    this.ActivateDelUserMed=false;

    this.getName();
    this.getLimits();
    this.getMed();
  }

  getName(){
    this.userService.getName()
    .subscribe(res =>{this.Name=res;});
  }

  getLimits(){
    this.userService.getLimits()
    .subscribe(res =>{this.Limits=res;});
  }

  getMed(){
    this.userService.getMedicine().subscribe(data=>{
      this.med=data;
    })
  }

  addMed(){
    this.med={
      UserMedicineId:0,
      Phe:null,
      Calories:null,
      Protein:null,
      Fat:null,
      Carb:null
    }
    this.ModalTitle="Add Medicine";
    this.ActivateAddEditUserMed=true;
  }

  editMed(){
    this.ModalTitle="Edit Medicine";
    this.ActivateAddEditUserMed=true;
  }

  delMed(){
    this.ModalTitle="Delete Medicine";
    this.ActivateDelUserMed=true;
  }
  
}
