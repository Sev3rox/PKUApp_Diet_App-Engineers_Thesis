import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { UserProductsService } from 'src/app/shared/services/user-products.service';

@Component({
  selector: 'app-user-show-products',
  templateUrl: './user-show-products.component.html',
  styleUrls: ['./user-show-products.component.css']
})

export class UserShowProductsComponent implements OnInit {

    constructor(private service:UserProductsService) { }
    ProductsList:any=[];
    ProductsListWithoutSearch:any=[];
    ModalTitle:string;
    ActivateDetailsProductComp:boolean=false;
    product:any;
    productSearch:string="";

    sortId:boolean=false;
    sortName:boolean=false;
    sortCategory:boolean=false;
    sortPhe:boolean=false;
    sortCalories:boolean=false;
    sortProtein:boolean=false;
    sortFat:boolean=false;
    sortCarb:boolean=false;

    categoryFruits:boolean=false;
    categoryVegetables:boolean=false;
    categoryDairy:boolean=false;
    categoryGrains:boolean=false;
    categoryProteinFoods:boolean=false;
    categoryDrinks:boolean=false;
    categorySnacks:boolean=false;
    categoryDishes:boolean=false;
    categoryOther:boolean=false;
  
    ngOnInit(): void {
      this.refreshProductsList(undefined);
    }
  

  
    detailsClick(item){
      this.product=item;
      this.ModalTitle="Product Details";
      this.ActivateDetailsProductComp=true;
    }
  
    @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;
  
    closeClickFromOutside(){
      this.ActivateDetailsProductComp=false;
      let el: HTMLElement = this.mybutton.nativeElement;
      el.click();
      this.refreshProductsList(undefined);
    }
  
    closeClick(){
      this.ActivateDetailsProductComp=false;
      this.refreshProductsList(undefined);
    }

    sortResult(prop){
      var asc=false;
      if(prop==="ProductId"){
          if(this.sortId===false){
            this.sortId=true;
            asc=true;
          }
          else{
            this.sortId=false;
            asc=false;
          }
      }
      else if(prop==="Name"){
        if(this.sortName===false){
          this.sortName=true;
          asc=true;
        }
        else{
          this.sortName=false;
          asc=false;
        }
    }
      else if(prop==="Category"){
        if(this.sortCategory===false){
          this.sortCategory=true;
          asc=true;
        }
        else{
          this.sortCategory=false;
          asc=false;
        }
    }    
          else if(prop==="Phe"){
        if(this.sortPhe===false){
          this.sortPhe=true;
          asc=true;
        }
        else{
          this.sortPhe=false;
          asc=false;
        }
    }
          else if(prop==="Calories"){
        if(this.sortCalories===false){
          this.sortCalories=true;
          asc=true;
        }
        else{
          this.sortCalories=false;
          asc=false;
        }
    }
          else if(prop==="Protein"){
        if(this.sortProtein===false){
          this.sortProtein=true;
          asc=true;
        }
        else{
          this.sortProtein=false;
          asc=false;
        }
    }
          else if(prop==="Fat"){
        if(this.sortFat===false){
          this.sortFat=true;
          asc=true;
        }
        else{
          this.sortFat=false;
          asc=false;
        }
    }
          else if(prop==="Carb"){
        if(this.sortCarb===false){
          this.sortCarb=true;
          asc=true;
        }
        else{
          this.sortCarb=false;
          asc=false;
        }
    }
    
      this.ProductsList = this.ProductsList.sort(function(a,b){
        if(asc){
            return (a[prop]>b[prop])?1 : ((a[prop]<b[prop]) ?-1 :0);
        }else{
          return (b[prop]>a[prop])?1 : ((b[prop]<a[prop]) ?-1 :0);
        }
      })

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
    }

    categoryResult(name){
      if(name=="Fruits"){
        if(this.categoryFruits==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryFruits=true;
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryFruits=false;
        }
      }
      else if(name=="Vegetables"){
        if(this.categoryVegetables==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryVegetables=true;
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryVegetables=false;
        }
      }
      else if(name=="Dairy"){
        if(this.categoryDairy==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryDairy=true;
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryDairy=false;
        }
      }
      else if(name=="Grains"){
        if(this.categoryGrains==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryGrains=true;
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryGrains=false;
        }
      }
      else if(name=="ProteinFoods"){
        if(this.categoryProteinFoods==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryProteinFoods=true;
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryProteinFoods=false;
        }
      }
      else if(name=="Drinks"){
        if(this.categoryDrinks==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryDrinks=true;
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryDrinks=false;
        }
      }
      else if(name=="Snacks"){
        if(this.categorySnacks==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categorySnacks=true;
        }
        else{
          this.refreshProductsList(undefined);
          this.categorySnacks=false;
        }
      }
      else if(name=="Dishes"){
        if(this.categoryDishes==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryDishes=true;
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryDishes=false;
        }
      }
      else if(name=="Other"){
        if(this.categoryOther==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryOther=true;
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryOther=false;
        }
      }
    }

    searchProduct(){
      var productSearch = this.productSearch;
  
      this.ProductsList = this.ProductsListWithoutSearch.filter(function (el){
          return el.Name.toString().toLowerCase().includes(
            productSearch.toString().trim().toLowerCase()
          )
      });
    }

    clearSearch(){
      this.productSearch="";
      this.searchProduct()
    }

    refreshProductsList(name){
      if(name==undefined){
      this.service.getProductsList().subscribe(data=>{
        this.ProductsList=data;
        this.ProductsListWithoutSearch=data;
        this.searchProduct()
      });}
      else{
        this.service.getProductsListByCategory(name).subscribe(data=>{
          this.ProductsList=data;
          this.ProductsListWithoutSearch=data;
          this.searchProduct()
        });}
      }
  
  }
