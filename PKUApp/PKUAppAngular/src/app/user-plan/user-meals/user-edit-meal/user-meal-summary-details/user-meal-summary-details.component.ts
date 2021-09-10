import { Component, OnInit, Input } from '@angular/core';
import { UserEditMealComponent } from '../user-edit-meal.component'

@Component({
  selector: 'app-user-meal-summary-details',
  templateUrl: './user-meal-summary-details.component.html',
  styleUrls: ['./user-meal-summary-details.component.css']
})
export class UserMealSummaryDetailsComponent implements OnInit {

  constructor(private closing:UserEditMealComponent) { }

  @Input() 
  summary:any;

  ngOnInit(): void {
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}
