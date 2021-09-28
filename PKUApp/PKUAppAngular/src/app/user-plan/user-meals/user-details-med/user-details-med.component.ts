import { Component, Input, OnInit} from '@angular/core';
import { UserShowMealsComponent } from '../user-show-meals/user-show-meals.component'

@Component({
  selector: 'app-user-details-med',
  templateUrl: './user-details-med.component.html',
  styleUrls: ['./user-details-med.component.css']
})
export class UserDetailsMedComponent implements OnInit {

  constructor(private closing:UserShowMealsComponent) { }

  @Input()
  dayMed

  ngOnInit(): void {
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}
