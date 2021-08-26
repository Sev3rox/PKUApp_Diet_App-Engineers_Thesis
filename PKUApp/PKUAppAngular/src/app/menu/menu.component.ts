import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from './../shared/services/authentication.service';
import { ToastrService } from 'ngx-toastr';
import { UserService } from './../shared/services/user.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  public isUserAuthenticated: boolean;
  public isAdmin: boolean;
  public Name: string;
  constructor(private _authService: AuthenticationService, private _router: Router,private userService: UserService,
    private toastr: ToastrService) { 
    this._authService.authChanged
    .subscribe(res =>{this.isUserAuthenticated = res;
      this.userService.getName()
    .subscribe(res =>{this.Name=res; console.log(this.Name);});
    this.userService.isAdmin()
    .subscribe(res =>{this.isAdmin=res; console.log(this.isAdmin);});
    })
  }

  ngOnInit(): void {
    this._authService.authChanged
    .subscribe(res =>{this.isUserAuthenticated = res;
      this.userService.getName()
    .subscribe(res =>{this.Name=res; console.log(this.Name);});
    this.userService.isAdmin()
    .subscribe(res =>{this.isAdmin=res; console.log(this.isAdmin);});
    })

  }

  public logout = () => {
    this._authService.logout();
    this._router.navigate(["/"]);
    this.toastr.success("Logged out successfully", "Logging Out");
  }
}
