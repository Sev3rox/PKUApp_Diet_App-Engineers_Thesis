import { Component, OnInit } from '@angular/core';
import { UserExercisesService } from 'src/app/shared/services/user-exercises.service';
import { DatePipe } from '@angular/common';


@Component({
  selector: 'app-user-exercise-chart',
  templateUrl: './user-exercise-chart.component.html',
  styleUrls: ['./user-exercise-chart.component.css']
})
export class UserExerciseChartComponent implements OnInit {

  constructor(private service:UserExercisesService, private datePipe: DatePipe) { }

  chartType:string="Calories";
  chartDays:number=3;
  colorScheme:any;
  yAxis:string;
  date:Date;
  chartData:any;
  chartColor:any;
  chartUnit:string="(kcal)";
  loaded:boolean=false;

  chartTime:boolean=false;
  chartCalories:boolean=true;

  chart3Days:boolean=true;
  chart7Days:boolean=false;
  chart14Days:boolean=false;
  chart30Days:boolean=false;

  ngOnInit(): void {

    this.date=new Date();

    this.colorScheme = {
      colorCalories: {
      domain: ['#ff8800']
    },
    colorTime: {
      domain: ['#00ffea']
    }
    };

    this.chartColor=this.colorScheme.colorCalories;
    this.yAxis="Calories (kcal)";

    this.getChartData();
  }

  resetChartType(){
    this.chartTime=false;
    this.chartCalories=false;
  }

  chartChange(chart){
    if(chart=="Calories"){
      this.resetChartType();
      this.chartCalories=true;
      this.chartType=chart;
      this.chartColor=this.colorScheme.colorCalories;
      this.yAxis="Calories (kcal)";
      this.chartUnit="(kcal)";
    }
    else if(chart=="Time"){
      this.resetChartType();
      this.chartTime=true;
      this.chartType=chart;
      this.chartColor=this.colorScheme.colorTime;
      this.yAxis="Time (min)";
      this.chartUnit="(min)";
    }

    this.getChartData();
  }

  resetChartDays(){
    this.chart3Days=false;
    this.chart7Days=false;
    this.chart14Days=false;
    this.chart30Days=false;
  }

  daysChange(days){
    if(days==3){
      this.resetChartDays();
      this.chart3Days=true;
      this.chartDays=days;
    }
    else if(days==7){
      this.resetChartDays();
      this.chart7Days=true;
      this.chartDays=days;
    }
    else if(days==14){
      this.resetChartDays();
      this.chart14Days=true;
      this.chartDays=days;
    }
    else if(days==30){
      this.resetChartDays();
      this.chart30Days=true;
      this.chartDays=days;
    }

    this.getChartData();
  }

  getChartData(){
    this.loaded=false;
    this.service.getChartData(this.datePipe.transform(this.date, 'yyyy-MM-dd'), this.chartType, this.chartDays).subscribe(data=>{
      this.chartData=data
      this.loaded=true;
    });
  }
}
