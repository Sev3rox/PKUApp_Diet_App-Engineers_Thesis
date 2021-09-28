import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { AdminProductsService } from 'src/app/shared/services/admin-products.service';


@Component({
  selector: 'app-notloged-show-products',
  templateUrl: './notloged-show-products.component.html',
  styleUrls: ['./notloged-show-products.component.css']
})
export class NotlogedShowProductsComponent implements OnInit {
  
      constructor(private service:AdminProductsService) { }
      ProductsList:any=[];
      ModalTitle:string;
      ActivateDetailsProductComp:boolean=false;
      product:any;
      productSearch:string="";
      catName:string="";
      sortNameHelp:string="Name";
      asc:boolean=true;
      page:number=1;
      count:number=1;
      pageSize:number=1;
  
      sortName:boolean=true;
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
        this.refreshProductsList();
      }
    
  
    
      detailsClick(item){
        this.product=item;
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
        this.refreshProductsList();
      }
    
      sortRefresh(){
        this.sortName=false;
        this.sortCategory=false;
        this.sortPhe=false;
        this.sortCalories=false;
        this.sortProtein=false;
        this.sortFat=false;
        this.sortCarb=false;
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
            else if(prop==="Protein"){
          if(this.sortProtein===false){
            this.sortRefresh();
            this.sortProtein=true;
            this.asc=true;
          }
          else{
            this.sortProtein=false;
            this.asc=false;
          }
      }
            else if(prop==="Fat"){
          if(this.sortFat===false){
            this.sortRefresh();
            this.sortFat=true;
            this.asc=true;
          }
          else{
            this.sortFat=false;
            this.asc=false;
          }
      }
            else if(prop==="Carb"){
          if(this.sortCarb===false){
            this.sortRefresh();
            this.sortCarb=true;
            this.asc=true;
          }
          else{
            this.sortCarb=false;
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
    
        this.refreshProductsList();
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
    
      refreshProductsList(){
        this.service.getProductsList(this.productSearch.toString(), this.sortNameHelp, this.asc, this.catName, this.page).subscribe(data=>{
          this.ProductsList=data.Items;
          this.page=data.PageIndex;
          this.count=data.Count;
          this.pageSize=data.PageSize;
        });
        }

    }
  