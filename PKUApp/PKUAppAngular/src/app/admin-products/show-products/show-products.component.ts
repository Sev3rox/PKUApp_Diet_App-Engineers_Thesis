import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { AdminProductsService } from 'src/app/shared/services/admin-products.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-show-products',
  templateUrl: './show-products.component.html',
  styleUrls: ['./show-products.component.css']
})
export class ShowProductsComponent implements OnInit {

  constructor(private service:AdminProductsService,
    private toastr: ToastrService) { }
  ProductsList:any=[];
  ModalTitle:string;
  ActivateAddEditProductComp:boolean=false;
  ActivateDetailsProductComp:boolean=false;
  ActivateDeleteProductComp:boolean=false;
  product:any;

  ngOnInit(): void {
    this.refreshProductsList();
  }

  addClick(){
    this.product={
      ProductId:0,
      Name:"",
      Phe:null,
      Calories:null,
      Protein:null,
      Fat:null,
      Carb:null

    }
    this.ModalTitle="Add Product";
    this.ActivateAddEditProductComp=true;
  }

  editClick(item){
    this.product=item;
    this.ModalTitle="Edit Product";
    this.ActivateAddEditProductComp=true;
  }

  detailsClick(item){
    this.product=item;
    this.ModalTitle="Product Details";
    this.ActivateDetailsProductComp=true;
  }

  deleteClick(item){
    this.product=item;
    this.ModalTitle="Delete Product";
    this.ActivateDeleteProductComp=true;
  }

  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;

  closeClickFromOutside(){
    this.ActivateAddEditProductComp=false;
    this.ActivateAddEditProductComp=false;
    this.ActivateDetailsProductComp=false;
    this.ActivateDeleteProductComp=false;
    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();
    this.refreshProductsList();
  }

  closeClick(){
    this.ActivateAddEditProductComp=false;
    this.ActivateDetailsProductComp=false;
    this.ActivateDeleteProductComp=false;
    this.refreshProductsList();
  }

  refreshProductsList(){
    this.service.getProductsList().subscribe(data=>{
      this.ProductsList=data;
    });
  }

}