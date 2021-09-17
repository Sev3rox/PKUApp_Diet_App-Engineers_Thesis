import { Component, OnInit, Input } from '@angular/core';
import { UserDishComponent } from '../user-dish.component'

@Component({
  selector: 'app-user-dish-summary-details',
  templateUrl: './user-dish-summary-details.component.html',
  styleUrls: ['./user-dish-summary-details.component.css']
})
export class UserDishSummaryDetailsComponent implements OnInit {

  constructor(private closing:UserDishComponent) { }

  @Input() 
  summary:any;

  ngOnInit(): void {
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}