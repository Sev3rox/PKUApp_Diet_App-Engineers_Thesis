import { Component, OnInit, Input } from '@angular/core';
import { UserProductsService } from 'src/app/shared/services/user-products.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { OwnShowProductsComponent } from 'src/app/user-products/own-products/own-show-products/own-show-products.component'

@Component({
  selector: 'app-own-add-edit-product',
  templateUrl: './own-add-edit-product.component.html',
  styleUrls: ['./own-add-edit-product.component.css']
})
export class OwnAddEditProductComponent implements OnInit {

  public productForm: FormGroup;
  public errorMessage: string = '';
  public showError: boolean;
  
  constructor(private service:UserProductsService,
    private toastr: ToastrService, private closing:OwnShowProductsComponent) { }

  @Input() 
      product:any;
      ProductId:number;
      Name:string;
      Category:string;
      Phe:number;
      Calories:number;
      Protein:number;
      Fat:number;
      Carb:number;
      UserId:string;

      CategoriesList:any=[];

  ngOnInit(): void {

      this.ProductId=this.product.ProductId;
      this.Name=this.product.Name;
      this.Category=this.product.Category;
      this.Phe=this.product.Phe/100;
      this.Calories=this.product.Calories/100;
      this.Protein=this.product.Protein/100;
      this.Fat=this.product.Fat/100;
      this.Carb=this.product.Carb/100;
      this.UserId=this.product.UserId;

      this.productForm = new FormGroup({
        Name: new FormControl(this.Name, [Validators.required]),
        Category: new FormControl(this.Category, [Validators.required]),
        Phe: new FormControl(this.Phe, [Validators.required, Validators.min(0), Validators.max(1000)]),
        Calories: new FormControl(this.Calories, [Validators.required, Validators.min(0),Validators.max(1000)]),
        Protein: new FormControl(this.Protein, [Validators.required, Validators.min(0), Validators.max(100)]),
        Fat: new FormControl(this.Fat, [Validators.required, Validators.min(0), Validators.max(100)]),
        Carb: new FormControl(this.Carb, [Validators.required, Validators.min(0), Validators.max(100)]),
      })
      this.loadCategoriesList();

    }

    loadCategoriesList(){
      this.service.getAllCategoriesNames().subscribe((data:any)=>{
        this.CategoriesList=data;
        this.CategoriesList.splice(this.CategoriesList.indexOf(this.Category), 1);
      });
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
    var val = { ProductId:this.ProductId,
                Name:product.Name,
                Category:product.Category,
                Phe:(Math.round((Math.round(product.Phe * 100) / 100)*100)),
                Calories:(Math.round((Math.round(product.Calories * 100) / 100)*100)),
                Protein:(Math.round((Math.round(product.Protein * 100) / 100)*100)),
                Fat:(Math.round((Math.round(product.Fat * 100) / 100)*100)),
                Carb:(Math.round((Math.round(product.Carb * 100) / 100)*100))}

    this.service.addProduct(val).subscribe(res=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Added successfully", "oWN Product Management");
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
                Category:product.Category,
                Phe:(Math.round((Math.round(product.Phe * 100) / 100)*100)),
                Calories:(Math.round((Math.round(product.Calories * 100) / 100)*100)),
                Protein:(Math.round((Math.round(product.Protein * 100) / 100)*100)),
                Fat:(Math.round((Math.round(product.Fat * 100) / 100)*100)),
                Carb:(Math.round((Math.round(product.Carb * 100) / 100)*100)),
                UserId:this.UserId}

    this.service.updateProduct(val).subscribe(res=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Updated successfully", "Own Product Management");
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

  Close(){
    this.closing.closeClickFromOutside();
  }

}
