import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { AdminExercisesService } from 'src/app/shared/services/admin-exercises.service';

@Component({
  selector: 'app-user-show-exercises',
  templateUrl: './user-show-exercises.component.html',
  styleUrls: ['./user-show-exercises.component.css']
})
export class UserShowExercisesComponent implements OnInit {

  constructor(private service:AdminExercisesService) { }
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
    this.refreshExercisesList();
  }

  detailsClick(item){
    this.exercise=item;
    this.ModalTitle="Exercise Details";
    this.ActivateDetailsExerciseComp=true;
  }

  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;
  
  closeClickFromOutside(){
    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();
  }

  closeClick(){
    this.ActivateDetailsExerciseComp=false;
    this.refreshExercisesList();
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

  refreshExercisesList(){
    this.service.getExercisesList(this.exerciseSearch.toString(), this.sortNameHelp, this.asc, this.page).subscribe(data=>{
      this.ExercisesList=data.Items;
      this.page=data.PageIndex;
      this.count=data.Count;
      this.pageSize=data.PageSize;
    });
    }
}
