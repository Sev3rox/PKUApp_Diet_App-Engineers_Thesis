import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { UserProfileComponent } from '../user-profile.component'
import { UserService } from './../../shared/services/user.service';

@Component({
  selector: 'app-reset-limits',
  templateUrl: './reset-limits.component.html',
  styleUrls: ['./reset-limits.component.css']
})
export class ResetLimitsComponent implements OnInit {

  constructor(private toastr: ToastrService, private closing:UserProfileComponent, private service:UserService) { }

  ngOnInit(): void {
  }

  resetLimits(){
    this.service.resetLimits().subscribe(_=>{
      this.toastr.success("Limits reseted successfully", "User Management");
      this.closing.closeClickFromOutside();
    });
  }

  Close(){
    this.closing.closeClickFromOutside();
  }
}
