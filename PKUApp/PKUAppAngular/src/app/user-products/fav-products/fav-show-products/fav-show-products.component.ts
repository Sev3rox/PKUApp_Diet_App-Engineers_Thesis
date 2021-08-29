import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { UserProductsService } from 'src/app/shared/services/user-products.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-fav-show-products',
  templateUrl: './fav-show-products.component.html',
  styleUrls: ['./fav-show-products.component.css']
})
export class FavShowProductsComponent implements OnInit {

    constructor(private service:UserProductsService,private toastr: ToastrService) { }
    ProductsList:any=[];
    ProductsListWithoutSearch:any=[];
    ModalTitle:string;
    ActivateDetailsProductComp:boolean=false;
    product:any;
    productSearch:string="";
    catName:string="";
    sortNameHelp="";
    

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
      this.refreshProductsListClose(undefined);
    }
  
    closeClick(){
      this.ActivateDetailsProductComp=false;
      this.refreshProductsListClose(undefined);
    }

    sortRefresh(){
      this.sortId=false;
      this.sortName=false;
      this.sortCategory=false;
      this.sortPhe=false;
      this.sortCalories=false;
      this.sortProtein=false;
      this.sortFat=false;
      this.sortCarb=false;
    }
  
    sortResult(prop){
      var asc=false;
      this.sortNameHelp=prop;
      if(prop==="ProductId"){
          if(this.sortId===false){
            this.sortRefresh();
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
          this.sortRefresh();
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
          this.sortRefresh();
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
          this.sortRefresh();
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
          this.sortRefresh();
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
          this.sortRefresh();
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
          this.sortRefresh();
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
          this.sortRefresh();
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
  
      this.ProductsListWithoutSearch  = this.ProductsListWithoutSearch.sort(function(a,b){
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
          this.catName='Fruits';
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryFruits=false;
          this.catName='';
        }
      }
      else if(name=="Vegetables"){
        if(this.categoryVegetables==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryVegetables=true;
          this.catName='Vegetables';
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryVegetables=false;
          this.catName='';
        }
      }
      else if(name=="Dairy"){
        if(this.categoryDairy==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryDairy=true;
          this.catName='Dairy';
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryDairy=false;
          this.catName='';
        }
      }
      else if(name=="Grains"){
        if(this.categoryGrains==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryGrains=true;
          this.catName='Grains';
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryGrains=false;
          this.catName='';
        }
      }
      else if(name=="ProteinFoods"){
        if(this.categoryProteinFoods==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryProteinFoods=true;
          this.catName='ProteinFoods';
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryProteinFoods=false;
          this.catName='';
        }
      }
      else if(name=="Drinks"){
        if(this.categoryDrinks==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryDrinks=true;
          this.catName='Drinks';
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryDrinks=false;
          this.catName='';
        }
      }
      else if(name=="Snacks"){
        if(this.categorySnacks==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categorySnacks=true;
          this.catName='Snacks';
        }
        else{
          this.refreshProductsList(undefined);
          this.categorySnacks=false;
          this.catName='';
        }
      }
      else if(name=="Dishes"){
        if(this.categoryDishes==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryDishes=true;
          this.catName='Dishes';
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryDishes=false;
          this.catName='';
        }
      }
      else if(name=="Other"){
        if(this.categoryOther==false){
          this.refreshProductsList(name);
          this.categoryRefresh();
          this.categoryOther=true;
          this.catName='Other';
        }
        else{
          this.refreshProductsList(undefined);
          this.categoryOther=false;
          this.catName='';
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

    unFavClick(product){
    this.service.deleteFavProduct(product.ProductId).subscribe(res=>{
      this.toastr.success("Deleted from Fav successfully","Product Management");
      this.refreshProductsListClose(undefined);
    });
    }

    refreshProductsList(name){
      if(name==undefined){
      this.service.getFavProductsList().subscribe(data=>{
        this.ProductsList=data;
        this.ProductsListWithoutSearch=data;
        this.searchProduct()
        this.sortResult(this.sortNameHelp);
        this.sortResult(this.sortNameHelp);
      });}
      else{
        this.service.getFavProductsListByCategory(name).subscribe(data=>{
          this.ProductsList=data;
          this.ProductsListWithoutSearch=data;
          this.searchProduct()
          this.sortResult(this.sortNameHelp);
          this.sortResult(this.sortNameHelp);
        });}
      }
    
      refreshProductsListClose(name){
        if(name==undefined){
        this.service.getFavProductsList().subscribe(data=>{
          this.ProductsList=data;
          this.ProductsListWithoutSearch=data;
          this.searchProduct()
          this.refreshProductsList(this.catName);
          this.sortResult(this.sortNameHelp);
          this.sortResult(this.sortNameHelp);
          
        });}
        else{
          this.service.getFavProductsListByCategory(name).subscribe(data=>{
            this.ProductsList=data;
            this.ProductsListWithoutSearch=data;
            this.refreshProductsList(this.catName);
            this.sortResult(this.sortNameHelp);
            this.sortResult(this.sortNameHelp);
          });}
        }

  }
