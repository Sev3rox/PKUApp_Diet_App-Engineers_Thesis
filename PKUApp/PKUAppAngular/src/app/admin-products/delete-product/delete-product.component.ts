import { Component, Input, OnInit } from '@angular/core';
import { ShowProductsComponent } from 'src/app/admin-products/show-products/show-products.component'
import { ToastrService } from 'ngx-toastr';
import { AdminProductsService } from 'src/app/shared/services/admin-products.service';

@Component({
  selector: 'app-delete-product',
  templateUrl: './delete-product.component.html',
  styleUrls: ['./delete-product.component.css']
})
export class DeleteProductComponent implements OnInit {

  constructor(private closing:ShowProductsComponent, private toastr: ToastrService, private service:AdminProductsService) { }

  @Input() 
      product:any;

  ngOnInit(): void {
  }

  Delete(){
    this.service.deleteProduct(this.product.ProductId).subscribe(_=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Deleted successfully", "Product Management")});
  }

  Close(){
    this.closing.closeClickFromOutside();
  }
}
