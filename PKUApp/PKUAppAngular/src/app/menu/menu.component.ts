import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from './../shared/services/authentication.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  public isUserAuthenticated: boolean;
  constructor(private _authService: AuthenticationService, private _router: Router,
    private toastr: ToastrService) { 
    this._authService.authChanged
    .subscribe(res => {
      this.isUserAuthenticated = res;
    })
  }

  ngOnInit(): void {
    this._authService.authChanged
    .subscribe(res =>this.isUserAuthenticated = res)
  }

  public logout = () => {
    this._authService.logout();
    this._router.navigate(["/"]);
    this.toastr.success("Logged out successfully", "Logging Out");
  }
}
