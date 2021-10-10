import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { DatePipe } from '@angular/common';
import { UserExercisesService } from 'src/app/shared/services/user-exercises.service';
 
@Component({
  selector: 'app-user-exercise-plan',
  templateUrl: './user-exercise-plan.component.html',
  styleUrls: ['./user-exercise-plan.component.css']
})
export class UserExercisePlanComponent implements OnInit {
  
  constructor(private datePipe: DatePipe,private service:UserExercisesService) { }
 
  date:Date;
  minDate:Date;
  maxDate:Date;
  currDate:Date;
  isToday:boolean=true;
  time:number=0;
  userId:string="";

  ExercisesList:any=[];
  ExercisesInDayList:any=[];
  ModalTitle:string;
  ActivateDetailsExerciseComp:boolean=false;
  ActivateAddEditExerciseComp:boolean=false;
  ActivateDetailsExerciseOnPlanComp:boolean=false;
  ActivateDeleteExerciseComp:boolean=false;
  exercise:any;
  exerciseSearch:string="";
  sortNameHelp:string="Name";
  asc:boolean=true;
  page:number=1;
  count:number=1;
  pageSize:number=1;
  pageInDay:number=1;
  countInDay:number=1;
  pageSizeInDay:number=1;
  daySummary:any;
  userExerciseId:any;

  sortName:boolean=true;
  sortCalories:boolean=false;
 
  ngOnInit(): void {
 
    this.minDate=new Date();
    this.maxDate=new Date();
    this.currDate=new Date();
 
    this.date=new Date();
    this.maxDate.setDate(this.maxDate.getDate()+6);
    this.minDate.setDate(this.minDate.getDate()-6);
    this.currDate.setDate(this.currDate.getDate());
 
    if(this.datePipe.transform(this.date, 'yyyy-MM-dd')!=this.datePipe.transform(new Date(), 'yyyy-MM-dd')){
      this.isToday=false;
    }
    else{
      this.isToday=true;
    }
    
    this.refreshExercisesList();
    this.refreshExercisesInDayList();
    this.refreshDaySummary()
  }
 
  dateClick(val){
    this.date.setDate(this.date.getDate()+val);
    this.date=new Date(this.date);
    if(this.datePipe.transform(this.date, 'yyyy-MM-dd')!=this.datePipe.transform(new Date(), 'yyyy-MM-dd')){
      this.isToday=false;
    }
    else{
      this.isToday=true;
    }

    this.refreshExercisesList();
    this.refreshExercisesInDayList();
    this.refreshDaySummary()
  }

  dateChangeinput(indate){

    this.date=new Date(indate);
    if(this.datePipe.transform(this.date, 'yyyy-MM-dd')!=this.datePipe.transform(new Date(), 'yyyy-MM-dd')){
      this.isToday=false;
    }
    else{
      this.isToday=true;
    }
    this.refreshExercisesList();
    this.refreshExercisesInDayList();
    this.refreshDaySummary()
  }
 
  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;
 
  closeClickFromOutside(){
    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();
  }
 
  closeClick(){
    this.ActivateDetailsExerciseComp=false;
    this.ActivateAddEditExerciseComp=false;
    this.ActivateDetailsExerciseOnPlanComp=false;
    this.ActivateDeleteExerciseComp=false;
    this.refreshExercisesList();
    this.refreshExercisesInDayList();
    this.refreshDaySummary()
  }

  detailsClick(item){
    this.exercise=item.Exercise;
    this.ModalTitle="Exercise Details";
    this.ActivateDetailsExerciseComp=true;
  }

  sortRefresh(){
    this.sortName=false;
    this.sortCalories=false;
  }

  sortResult(prop){
    this.page=1;
    this.sortNameHelp=prop;
    if(prop==="Name"){
      if(this.sortName===false){
        this.sortRefresh();
        this.sortName=true;
        this.asc=true;
      }
      else{
        this.sortName=false;
        this.asc=false;
      }
  }
    else if(prop==="Calories"){
      if(this.sortCalories===false){
        this.sortRefresh();
        this.sortCalories=true;
        this.asc=true;
      }
      else{
        this.sortCalories=false;
        this.asc=false;
      }
  }
  
    this.refreshExercisesList();

  }

  searchExercise(){
    this.page=1;
    this.refreshExercisesList();
  }

  clearSearch(){
    this.page=1;
    this.exerciseSearch="";
    this.searchExercise()
  }

  onPageChange(event){
    this.page=event;
    this.refreshExercisesList();
  }

  onPageChange2(event){
    this.pageInDay=event;
    this.refreshExercisesInDayList();
  }

  addClick(item){
    this.exercise=item;
    this.time=0;
    this.ModalTitle="Add Exercise to Day";
    this.ActivateAddEditExerciseComp=true;
  }

  detailsInDayClick(item){
    this.exercise=item.Exercise;
    this.time=item.Time;
    this.ModalTitle="Exercise on day Details";
    this.ActivateDetailsExerciseOnPlanComp=true;
  }

  editInDayClick(item){
    this.exercise=item;
    this.time=item.Time/100;
    this.userId=item.UserId;
    this.userExerciseId=item.UserExerciseId;
    this.ModalTitle="Edit Exercise on Day";
    this.ActivateAddEditExerciseComp=true;
  }

  deleteInDayClick(item){
    this.exercise=item.Exercise;
    this.ModalTitle="Edit Exercise on Day";
    this.ActivateDeleteExerciseComp=true;
  }

  refreshDaySummary(){
    this.service.getDaySummary(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
      this.daySummary=data;
    });
    }

  refreshExercisesList(){
    this.service.getExercisesList(this.datePipe.transform(this.date, 'yyyy-MM-dd'), this.exerciseSearch.toString(), this.sortNameHelp, this.asc, this.page).subscribe(data=>{
      this.ExercisesList=data.Items;
      this.page=data.PageIndex;
      this.count=data.Count;
      this.pageSize=data.PageSize;
    });
    }

    refreshExercisesInDayList(){
    this.service.getExercisesInDay(this.datePipe.transform(this.date, 'yyyy-MM-dd'), this.pageInDay).subscribe(data=>{
      this.ExercisesInDayList=data.Items;
      this.pageInDay=data.PageIndex;
      this.countInDay=data.Count;
      this.pageSizeInDay=data.PageSize;
    })
    }
}
