import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { UserProductsService } from 'src/app/shared/services/user-products.service';
import { UserDishService } from 'src/app/shared/services/user-dish.service';

@Component({
  selector: 'app-user-dish',
  templateUrl: './user-dish.component.html',
  styleUrls: ['./user-dish.component.css']
})
export class UserDishComponent implements OnInit {

  constructor(private prodservice:UserProductsService, private service:UserDishService) { }
  onlyFav:boolean=false;
  ProductsList:any=[];
  DishProductsList:any=[];
  DishProductsSummary:any;
  ModalTitle:string;
  ActivateDetailsProductComp:boolean=false;
  ActivateAddEditProductDishComp:boolean=false;
  ActivateDeleteProductDishComp:boolean=false;
  ActivateDishSummaryDetailsComp:boolean=false;
  ActivateProductInDishDetailsComp:boolean=false;
  ActivateDeleteAllProductsDishComp:boolean=false;
  ActivateAddDishComp:boolean=false;
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
  pagepd:number=1;
  countpd:number=1;
  pageSizepd:number=1;
  weight:number=0;
  lastAdded:boolean=false;
  dish:any;

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
    this.refreshProductsList();
    this.refreshDishProductsList();
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
    this.ActivateDeleteProductDishComp=false;
    this.ActivateAddEditProductDishComp=false;
    this.ActivateDishSummaryDetailsComp=false;
    this.ActivateProductInDishDetailsComp=false;
    this.ActivateDeleteAllProductsDishComp=false;
    this.ActivateAddDishComp=false;
    this.refreshProductsList();
    this.refreshDishProductsList()
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
    else if(name=="ProteinFoods"){
      if(this.categoryProteinFoods==false){
        this.categoryRefresh();
        this.categoryProteinFoods=true;
        this.catName='ProteinFoods';
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
    this.pagepd=event;
    this.refreshDishProductsList();
  }
  
  addClick(item:any){
    this.product=item;
    this.weight=0;
    this.ModalTitle="Add Product to Dish";
    this.ActivateAddEditProductDishComp=true;
  }

  editClick(item:any){
    this.product=item;
    this.weight=item.Weight/100;
    this.ModalTitle="Edit Product in Dish";
    this.ActivateAddEditProductDishComp=true;
  }

  delClick(item:any){
    this.product=item;
    this.ModalTitle="Delete Product in Dish";
    this.ActivateDeleteProductDishComp=true;
  }

  detailsSummaryClick(){
    this.ModalTitle="Dish Summary Details";
    this.ActivateDishSummaryDetailsComp=true;
  }

  detailsDishProductClick(item){
    this.product=item;
    this.ModalTitle="Product in Dish Details";
    this.ActivateProductInDishDetailsComp=true;
  }

  createDishClick(){
    this.ModalTitle="Create Dish";
    this.ActivateAddDishComp=true;
  }

  clearDishClick(){
    this.ModalTitle="Clear All Product in Dish";
    this.ActivateDeleteAllProductsDishComp=true;
  }

  refreshProductsList(){
    this.prodservice.getDishProductsList(this.productSearch.toString(), this.sortNameHelp, this.asc, this.catName, this.page, this.lastAdded).subscribe(data=>{
      this.ProductsList=data.Items;
      this.page=data.PageIndex;
      this.count=data.Count;
      this.pageSize=data.PageSize;
    });
    }

    refreshDishProductsList(){
      this.service.getDishProductsList(this.pagepd).subscribe(data=>{
        this.DishProductsList=data.Items;
        this.pagepd=data.PageIndex;
        this.countpd=data.Count;
        this.pageSizepd=data.PageSize;
        this.refreshDishSummary();
      });
      }

      refreshDishSummary(){
        this.service.getDishSummary().subscribe(data=>{
          this.DishProductsSummary=data;
        });
        }
}

