import { Component, OnInit, Input } from '@angular/core';
import { AdminProductsService } from 'src/app/shared/services/admin-products.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ShowProductsComponent } from 'src/app/admin-products/show-products/show-products.component'

@Component({
  selector: 'app-add-edit-product',
  templateUrl: './add-edit-product.component.html',
  styleUrls: ['./add-edit-product.component.css']
})
export class AddEditProductComponent implements OnInit {

  public productForm: FormGroup;
  public errorMessage: string = '';
  public showError: boolean;
  
  constructor(private service:AdminProductsService,
    private toastr: ToastrService, private closing:ShowProductsComponent) { }

  @Input() 
      product:any;
      ProductId:number;
      Name:string;
      Phe:number;
      Calories:number;
      Protein:number;
      TotalFat:number;
      TotalCarb:number;

  ngOnInit(): void {

      this.ProductId=this.product.ProductId;
      this.Name=this.product.Name;
      this.Phe=this.product.Phe;
      this.Calories=this.product.Calories;
      this.Protein=this.product.Protein;
      this.TotalFat=this.product.TotalFat;
      this.TotalCarb=this.product.TotalCarb;

      this.productForm = new FormGroup({
        Name: new FormControl(this.Name, [Validators.required]),
        Phe: new FormControl(this.Phe, [Validators.required, Validators.min(0), Validators.max(2147483647)]),
        Calories: new FormControl(this.Calories, [Validators.required, Validators.min(0),Validators.max(2147483647)]),
        Protein: new FormControl(this.Protein, [Validators.required, Validators.min(0), Validators.max(2147483647)]),
        TotalFat: new FormControl(this.TotalFat, [Validators.required, Validators.min(0), Validators.max(2147483647)]),
        TotalCarb: new FormControl(this.TotalCarb, [Validators.required, Validators.min(0), Validators.max(2147483647)]),
      })
    }

    addUpdateProduct(productFormValue){
      if(this.ProductId==0)
      this.addProduct(productFormValue);
      else
      this.updateProduct(productFormValue);
    }

  addProduct(productFormValue){
    this.showError = false;
    const product = {... productFormValue };
    console.log(product)
    var val = { ProductId:this.ProductId,
                Name:product.Name,
                Phe:product.Phe,
                Calories:product.Calories,
                Protein:product.Protein,
                TotalFat:product.TotalFat,
                TotalCarb:product.TotalCarb}

    this.service.addProduct(val).subscribe(res=>{
      this.closing.closeClick2();
      this.toastr.success("Added successfully", "Product Management");
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  updateProduct(productFormValue){
    this.showError = false;
    const product = {... productFormValue };
    var val = { ProductId:this.ProductId,
                Name:product.Name,
                Phe:product.Phe,
                Calories:product.Calories,
                Protein:product.Protein,
                TotalFat:product.TotalFat,
                TotalCarb:product.TotalCarb};

    this.service.updateProduct(val).subscribe(res=>{
      this.closing.closeClick2();
      this.toastr.success("Updated successfully", "Product Management");
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.productForm.controls[controlName].hasError(errorName)
  }

  public validateControl = (controlName: string) => {
    return this.productForm.controls[controlName].invalid && this.productForm.controls[controlName].touched
  }

}
