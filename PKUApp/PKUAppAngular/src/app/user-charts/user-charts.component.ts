import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-charts',
  templateUrl: './user-charts.component.html',
  styleUrls: ['./user-charts.component.css']
})
export class UserChartsComponent implements OnInit {

  constructor() { }

  chartPhe:boolean=false;
  chartCalories:boolean=false;
  chartProteins:boolean=false;
  chartFat:boolean=false;
  chartCarb:boolean=false;

  chart3Days:boolean=false;
  chart7Days:boolean=false;
  chart14Days:boolean=false;
  chart30Days:boolean=false;

  ngOnInit(): void {
  }

  chartChange(chart){

  }

  daysChange(days){

  }

}
