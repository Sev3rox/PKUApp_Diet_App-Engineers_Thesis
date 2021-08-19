import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '.././shared/services/authentication.service';

@Component({
  selector: 'app-privacy',
  templateUrl: './privacy.component.html',
  styleUrls: ['./privacy.component.css']
})
export class PrivacyComponent implements OnInit {
  public claims: any [];
  constructor(private _authService: AuthenticationService) { }
  ngOnInit(): void {
    this.getClaims();
  }
  public getClaims = () =>{
    this._authService.privacy('api/products/privacy').subscribe(res => {
      this.claims = res as [];
    })
  }
}
