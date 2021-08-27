import { Component, Input, OnInit } from '@angular/core';
import { OwnShowProductsComponent } from 'src/app/user-products/own-products/own-show-products/own-show-products.component'
import { ToastrService } from 'ngx-toastr';
import { UserProductsService } from 'src/app/shared/services/user-products.service';

@Component({
  selector: 'app-own-delete-product',
  templateUrl: './own-delete-product.component.html',
  styleUrls: ['./own-delete-product.component.css']
})
export class OwnDeleteProductComponent implements OnInit {

  constructor(private closing:OwnShowProductsComponent, private toastr: ToastrService, private service:UserProductsService) { }

  @Input() 
      product:any;

  ngOnInit(): void {
  }

  Delete(){
    this.service.deleteProduct(this.product.ProductId).subscribe(_=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Deleted successfully", "Own Product Management")});
  }

  Close(){
    this.closing.closeClickFromOutside();
  }
}

