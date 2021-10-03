import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from './../shared/services/authentication.service';
import { UserService } from './../shared/services/user.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private _authService: AuthenticationService, private _router: Router, private userService: UserService, route:ActivatedRoute) {
    route.params.subscribe(val => {
      
      this.isUserAuthenticated=this._authService.isUserAuthenticated();
      this.userService.isAdmin()
      .subscribe(res2 =>{this.isAdmin=res2;
  
        if(this.isAdmin==true){
          this._router.navigate(["/admin-products"]);
        }
        else if(this.isUserAuthenticated==true){
          this._router.navigate(['/user-plan']);
        }
        else{
          this._router.navigate(["/products"]);
        }
      })

    });
   }

  public isUserAuthenticated: boolean;
  public isAdmin: boolean;
  public Name: string;

  ngOnInit(): void {

}
}
