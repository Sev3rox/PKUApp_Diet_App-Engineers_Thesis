import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { UserProductsService } from 'src/app/shared/services/user-products.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-user-show-products',
  templateUrl: './user-show-products.component.html',
  styleUrls: ['./user-show-products.component.css']
})

export class UserShowProductsComponent implements OnInit {

    constructor(private service:UserProductsService,
      private toastr: ToastrService) { }
    ProductsList:any=[];
    ModalTitle:string;
    ActivateDetailsProductComp:boolean=false;
    product:any;

    sortId:boolean=false;
    sortName:boolean=false;
    sortCategory:boolean=false;
    sortPhe:boolean=false;
    sortCalories:boolean=false;
    sortProtein:boolean=false;
    sortFat:boolean=false;
    sortCarb:boolean=false;
  
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
      this.ActivateDetailsProductComp=false;
      let el: HTMLElement = this.mybutton.nativeElement;
      el.click();
      this.refreshProductsList();
    }
  
    closeClick(){
      this.ActivateDetailsProductComp=false;
      this.refreshProductsList();
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
  
    refreshProductsList(){
      this.service.getProductsList().subscribe(data=>{
        this.ProductsList=data;
      });
    }
  
  }
