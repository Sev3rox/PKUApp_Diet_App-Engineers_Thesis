import { Component, Input, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { UserProfileComponent } from '../user-profile.component'
import { UserService } from './../../shared/services/user.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-del-med',
  templateUrl: './del-med.component.html',
  styleUrls: ['./del-med.component.css']
})
export class DelMedComponent implements OnInit {

  constructor(private toastr: ToastrService, private closing:UserProfileComponent, private service:UserService, private datePipe: DatePipe) { }
  
  @Input()
  med

  date:any

  ngOnInit(): void {
  }

  Delete(){
    this.date=new Date();
    this.service.deleteMedicine(this.med.UserMedicineId, this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(_=>{
      this.toastr.success("Medicine deleted successfully", "User Management");
      this.closing.closeClickFromOutside();
    });
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}
