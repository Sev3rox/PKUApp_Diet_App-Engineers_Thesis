import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { AdminExercisesService } from 'src/app/shared/services/admin-exercises.service';

@Component({
  selector: 'app-show-exercises',
  templateUrl: './show-exercises.component.html',
  styleUrls: ['./show-exercises.component.css']
})
export class ShowExercisesComponent implements OnInit {

  constructor(private service:AdminExercisesService) { }
  ExercisesList:any=[];
  ModalTitle:string;
  ActivateAddEditExerciseComp:boolean=false;
  ActivateDetailsExerciseComp:boolean=false;
  ActivateDeleteExerciseComp:boolean=false;
  exercise:any;
  exerciseSearch:string="";
  sortNameHelp:string="Name";
  asc:boolean=true;
  page:number=1;
  count:number=1;
  pageSize:number=1;

  sortId:boolean=false;
  sortName:boolean=true;
  sortCalories:boolean=false;

  ngOnInit(): void {
    this.refreshExercisesList();
  }

  addClick(){
    this.exercise={
      ExerciseId:0,
      Name:"",
      Calories:null,
    }
    this.ModalTitle="Add Exercise";
    this.ActivateAddEditExerciseComp=true;
  }

  editClick(item){
    this.exercise=item;
    this.ModalTitle="Edit Exercise";
    this.ActivateAddEditExerciseComp=true;
  }

  detailsClick(item){
    this.exercise=item;
    this.ModalTitle="Exercise Details";
    this.ActivateDetailsExerciseComp=true;
  }

  deleteClick(item){
    this.exercise=item;
    this.ModalTitle="Delete Exercise";
    this.ActivateDeleteExerciseComp=true;
  }

  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;
  
  closeClickFromOutside(){
    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();
  }

  closeClick(){
    this.ActivateDetailsExerciseComp=false;
    this.ActivateAddEditExerciseComp=false;
    this.ActivateDeleteExerciseComp=false;
    this.refreshExercisesList();
  }

  sortRefresh(){
    this.sortId=false;
    this.sortName=false;
    this.sortCalories=false;
  }

  sortResult(prop){
    this.page=1;
    this.sortNameHelp=prop;
    if(prop==="ExerciseId"){
        if(this.sortId===false){
          this.sortRefresh();
          this.sortId=true;
          this.asc=true;
        }
        else{
          this.sortId=false;
          this.asc=false;
        }
  }
    else if(prop==="Name"){
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