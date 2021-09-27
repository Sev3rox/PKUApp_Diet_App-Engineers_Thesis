import { Component, OnInit } from '@angular/core';
import { UserChartsService } from 'src/app/shared/services/user-charts.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-user-charts',
  templateUrl: './user-charts.component.html',
  styleUrls: ['./user-charts.component.css']
})
export class UserChartsComponent implements OnInit {

  constructor(private service:UserChartsService, private datePipe: DatePipe) { }

  chartType:string="Phe";
  chartDays:number=3;
  colorScheme:any;
  yAxis:string;
  date:Date;
  chartData:any;
  chartColor:any;
  chartUnit:string="(mg)";

  chartPhe:boolean=true;
  chartCalories:boolean=false;
  chartProtein:boolean=false;
  chartFat:boolean=false;
  chartCarb:boolean=false;

  chart3Days:boolean=true;
  chart7Days:boolean=false;
  chart14Days:boolean=false;
  chart30Days:boolean=false;

  ngOnInit(): void {

    this.date=new Date();

    this.colorScheme = {
      colorCalories: {
      domain: ['#ffd900']
    },
    colorPhe: {
      domain: ['#b700ff']
    }
    ,
    colorProtein: {
      domain: ['#0059ff']
    }
    ,
    colorFat: {
      domain: ['#00b10f']
    }
    ,
    colorCarb: {
      domain: ['#ff1e00']
    }
    };

    this.chartColor=this.colorScheme.colorPhe;
    this.yAxis="Phe (mg)";

    this.getChartData();
  }

  resetChartType(){
    this.chartPhe=false;
    this.chartCalories=false;
    this.chartProtein=false;
    this.chartFat=false;
    this.chartCarb=false;
  }

  chartChange(chart){
    if(chart=="Phe"){
      this.resetChartType();
      this.chartPhe=true;
      this.chartType=chart;
      this.chartColor=this.colorScheme.colorPhe;
      this.yAxis="Phe (mg)";
      this.chartUnit="(mg)";
    }
    else if(chart=="Calories"){
      this.resetChartType();
      this.chartCalories=true;
      this.chartType=chart;
      this.chartColor=this.colorScheme.colorCalories;
      this.yAxis="Calories (kcal)";
      this.chartUnit="(kcal)";
    }
    else if(chart=="Protein"){
      this.resetChartType();
      this.chartProtein=true;
      this.chartType=chart;
      this.chartColor=this.colorScheme.colorProtein;
      this.yAxis="Protein (g)";
      this.chartUnit="(g)";
    }
    else if(chart=="Fat"){
      this.resetChartType();
      this.chartFat=true;
      this.chartType=chart;
      this.chartColor=this.colorScheme.colorFat;
      this.yAxis="Fat (g)";
      this.chartUnit="(g)";
    }
    else if(chart=="Carb"){
      this.resetChartType();
      this.chartCarb=true;
      this.chartType=chart;
      this.chartColor=this.colorScheme.colorCarb;
      this.yAxis="Carb (g)";
      this.chartUnit="(g)";
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
    this.service.getChartData(this.datePipe.transform(this.date, 'yyyy-MM-dd'), this.chartType, this.chartDays).subscribe(data=>{
      this.chartData=data
    });
  }
}
