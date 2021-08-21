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
      TotalFat:null,
      TotalCarb:null

    }
    this.ModalTitle="Add Product";
    this.ActivateAddEditProductComp=true;
  }

  editClick(item){
    this.product=item;
    this.ModalTitle="Edit Product";
    this.ActivateAddEditProductComp=true;
  }

  deleteClick(item){
    if(confirm('Are you sure?')){
      this.service.deleteProduct(item.ProductId).subscribe(data=>{
        this.refreshProductsList();
        this.toastr.success("Deleted successfully", "Product Management");
      })
    }
  }

  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;

  closeClick2(){
    this.ActivateAddEditProductComp=false;
    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();
    this.refreshProductsList();
  }

  closeClick(){
    this.ActivateAddEditProductComp=false;
    this.refreshProductsList();
  }

  refreshProductsList(){
    this.service.getProductsList().subscribe(data=>{
      this.ProductsList=data;
    });
  }

}