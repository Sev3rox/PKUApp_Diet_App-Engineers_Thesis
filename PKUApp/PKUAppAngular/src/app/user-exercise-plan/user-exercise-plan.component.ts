
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

  ExercisesList:any=[];
  ModalTitle:string;
  ActivateDetailsExerciseComp:boolean=false;
  exercise:any;
  exerciseSearch:string="";
  sortNameHelp:string="Name";
  asc:boolean=true;
  page:number=1;
  count:number=1;
  pageSize:number=1;

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
 
  }
 
  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;
 
  closeClickFromOutside(){
    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();
  }
 
  closeClick(){
 
  }

  detailsClick(item){
    this.exercise=item;
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

  addClick(item){

  }

  refreshExercisesList(){
    this.service.getExercisesList(this.datePipe.transform(this.date, 'yyyy-MM-dd'), this.exerciseSearch.toString(), this.sortNameHelp, this.asc, this.page).subscribe(data=>{
      this.ExercisesList=data.Items;
      this.page=data.PageIndex;
      this.count=data.Count;
      this.pageSize=data.PageSize;
    });
    }
}
