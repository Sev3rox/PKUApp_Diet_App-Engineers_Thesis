import { ActivatedRoute } from '@angular/router';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { UserProductsService } from 'src/app/shared/services/user-products.service';
import { UserPlanService } from 'src/app/shared/services/user-plan.service';
import { Router } from '@angular/router';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-user-edit-meal',
  templateUrl: './user-edit-meal.component.html',
  styleUrls: ['./user-edit-meal.component.css']
})
export class UserEditMealComponent implements OnInit {

  constructor(private route: ActivatedRoute,private prodservice:UserProductsService, private service:UserPlanService, private router:Router, private datePipe: DatePipe) { }
  mealid:number;
  onlyFav:boolean=false;
  ProductsList:any=[];
  MealProductsList:any=[];
  MealProductsSummary:any;
  ModalTitle:string;
  ActivateDetailsProductComp:boolean=false;
  ActivateAddEditProductMealComp:boolean=false;
  ActivateDeleteProductMealComp:boolean=false;
  ActivateMealSummaryDetailsComp:boolean=false;
  ActivateProductInMealDetailsComp:boolean=false;
  ActivateDailySummaryComp:boolean=false;
  product:any;
  productSearch:string="";
  catName:string="";
  sortNameHelp:string="Name";
  sortNameHelpBackup="";
  asc:boolean=true;
  ascBackup:boolean=true;
  page:number=1;
  count:number=1;
  pageSize:number=1;
  pagepm:number=1;
  countpm:number=1;
  pageSizepm:number=1;
  weight:number=0;
  date:Date;
  lastAdded:boolean=false;
  meal:any;
  
  sortName:boolean=true;
  sortCategory:boolean=false;
  sortPhe:boolean=false;
  sortCalories:boolean=false;

  categoryFruits:boolean=false;
  categoryVegetables:boolean=false;
  categoryDairy:boolean=false;
  categoryGrains:boolean=false;
  categoryProteinFoods:boolean=false;
  categoryDrinks:boolean=false;
  categorySnacks:boolean=false;
  categoryDishes:boolean=false;
  categoryOther:boolean=false;
  categoryFav:boolean=false;

  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      this.mealid = params.id;
      this.date=params.date;
  });
  this.service.getMeal(this.mealid).subscribe(data=>{
    this.meal=data
    this.meal.Date=this.datePipe.transform(this.meal.Date, 'yyyy-MM-dd')
  });
    this.refreshProductsList();
    this.refreshMealProductsList();
  }

  detailsClick(item){
    this.product=item.Product;
    this.ModalTitle="Product Details";
    this.ActivateDetailsProductComp=true;
  }

  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;

  closeClickFromOutside(){
    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();
  }

  closeClick(){
    this.ActivateDetailsProductComp=false;
    this.ActivateDeleteProductMealComp=false;
    this.ActivateAddEditProductMealComp=false;
    this.ActivateMealSummaryDetailsComp=false;
    this.ActivateProductInMealDetailsComp=false;
    this.ActivateDailySummaryComp=false;
    this.refreshProductsList();
    this.refreshMealProductsList()
  }

  sortRefresh(){
    this.sortName=false;
    this.sortCategory=false;
    this.sortPhe=false;
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
    else if(prop==="Category"){
      if(this.sortCategory===false){
        this.sortRefresh();
        this.sortCategory=true;
        this.asc=true;
      }
      else{
        this.sortCategory=false;
        this.asc=false;
      }
  }    
        else if(prop==="Phe"){
      if(this.sortPhe===false){
        this.sortRefresh();
        this.sortPhe=true;
        this.asc=true;
      }
      else{
        this.sortPhe=false;
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
  
    this.refreshProductsList();

  }

  categoryRefresh(){
    this.categoryFruits=false;
    this.categoryVegetables=false;
    this.categoryDairy=false;
    this.categoryGrains=false;
    this.categoryProteinFoods=false;
    this.categoryDrinks=false;
    this.categorySnacks=false;
    this.categoryDishes=false;
    this.categoryOther=false;
    this.categoryFav=false;
  }

  categoryResult(name){
    this.page=1;
    if(name=="Fruits"){
      if(this.categoryFruits==false){
        this.categoryRefresh();
        this.categoryFruits=true;
        this.catName='Fruits';
      }
      else{
        this.categoryFruits=false;
        this.catName='';
      }
    }
    else if(name=="Vegetables"){
      if(this.categoryVegetables==false){
        this.categoryRefresh();
        this.categoryVegetables=true;
        this.catName='Vegetables';
      }
      else{
        this.categoryVegetables=false;
        this.catName='';
      }
    }
    else if(name=="Dairy"){
      if(this.categoryDairy==false){
        this.categoryRefresh();
        this.categoryDairy=true;
        this.catName='Dairy';
      }
      else{
        this.categoryDairy=false;
        this.catName='';
      }
    }
    else if(name=="Grains"){
      if(this.categoryGrains==false){
        this.categoryRefresh();
        this.categoryGrains=true;
        this.catName='Grains';
      }
      else{
        this.categoryGrains=false;
        this.catName='';
      }
    }
    else if(name=="Protein Foods"){
      if(this.categoryProteinFoods==false){
        this.categoryRefresh();
        this.categoryProteinFoods=true;
        this.catName='Protein Foods';
      }
      else{
        this.categoryProteinFoods=false;
        this.catName='';
      }
    }
    else if(name=="Drinks"){
      if(this.categoryDrinks==false){
        this.categoryRefresh();
        this.categoryDrinks=true;
        this.catName='Drinks';
      }
      else{
        this.categoryDrinks=false;
        this.catName='';
      }
    }
    else if(name=="Snacks"){
      if(this.categorySnacks==false){
        this.categoryRefresh();
        this.categorySnacks=true;
        this.catName='Snacks';
      }
      else{
        this.categorySnacks=false;
        this.catName='';
      }
    }
    else if(name=="Dishes"){
      if(this.categoryDishes==false){
        this.categoryRefresh();
        this.categoryDishes=true;
        this.catName='Dishes';
      }
      else{
        this.categoryDishes=false;
        this.catName='';
      }
    }
    else if(name=="Other"){
      if(this.categoryOther==false){
        this.categoryRefresh();
        this.categoryOther=true;
        this.catName='Other';
      }
      else{
        this.categoryOther=false;
        this.catName='';
      }
    }
      else if(name=="Fav"){
        if(this.categoryFav==false){
          this.categoryRefresh();
          this.categoryFav=true;
          this.catName='Fav';
        }
      else{
        this.categoryFav=false;
        this.catName='';
      }
    }

    this.refreshProductsList();
  }

  lastAddedChange(bol){
    this.lastAdded=bol;
    if(bol===true){
    this.ascBackup=this.asc;
    this.sortNameHelpBackup=this.sortNameHelp;
    this.sortNameHelp="";
    this.asc=false;
    this.sortRefresh();
    }
    else if(this.sortNameHelp==""){
      this.sortBackup(this.sortNameHelpBackup);
      this.sortResult(this.sortNameHelpBackup);
    }
    this.refreshProductsList()
  }

  sortBackup(prop){
    if(prop==="Name"){
      this.sortName=!this.ascBackup;
  }
    else if(prop==="Category"){
      this.sortCategory=!this.ascBackup;
  }    
        else if(prop==="Phe"){
      this.sortPhe=!this.ascBackup;
  }
        else if(prop==="Calories"){
      this.sortCalories=!this.ascBackup;
  }
  }
  
  searchProduct(){
    this.page=1;
    this.refreshProductsList();
  }

  clearSearch(){
    this.page=1;
    this.productSearch="";
    this.searchProduct()
  }

  onPageChange(event){
    this.page=event;
    this.refreshProductsList();
  }

  onPageChange2(event){
    this.pagepm=event;
    this.refreshMealProductsList();
  }
  
  addClick(item:any){
    this.product=item;
    this.weight=0;
    this.ModalTitle="Add Product to Meal";
    this.ActivateAddEditProductMealComp=true;
  }

  editClick(item:any){
    this.product=item;
    this.weight=item.Weight/100;
    this.ModalTitle="Edit Product in Meal";
    this.ActivateAddEditProductMealComp=true;
  }

  delClick(item:any){
    this.product=item;
    this.ModalTitle="Delete Product in Meal";
    this.ActivateDeleteProductMealComp=true;
  }

  detailsSummaryClick(){
    this.ModalTitle="Meal Summary Details";
    this.ActivateMealSummaryDetailsComp=true;
  }

  detailsMealProductClick(item){
    this.product=item;
    this.ModalTitle="Product in Meal Details";
    this.ActivateProductInMealDetailsComp=true;
  }

  backClick(){
    this.router.navigate(['/user-plan'],{queryParams:{date: this.date}});
  }

  dailySummaryClick(){
    this.ModalTitle="Daily Summary";
    this.ActivateDailySummaryComp=true;
  }

  refreshProductsList(){
    this.prodservice.getMealProductsList(this.productSearch.toString(), this.sortNameHelp, this.asc, this.catName, this.page, this.mealid, this.lastAdded).subscribe(data=>{
      this.ProductsList=data.Items;
      this.page=data.PageIndex;
      this.count=data.Count;
      this.pageSize=data.PageSize;
    });
    }

    refreshMealProductsList(){
      this.service.getMealProductsList(this.mealid,this.pagepm).subscribe(data=>{
        this.MealProductsList=data.Items;
        this.pagepm=data.PageIndex;
        this.countpm=data.Count;
        this.pageSizepm=data.PageSize;
        this.refreshMealSummary();
      });
      }

      refreshMealSummary(){
        this.service.getMealSummary(this.mealid).subscribe(data=>{
          this.MealProductsSummary=data;
        });
        }
}
