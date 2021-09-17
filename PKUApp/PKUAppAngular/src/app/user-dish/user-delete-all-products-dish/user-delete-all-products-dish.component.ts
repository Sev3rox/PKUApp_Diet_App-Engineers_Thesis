import { Component, OnInit, Input } from '@angular/core';
import { UserDishComponent } from '../user-dish.component'
import { ToastrService } from 'ngx-toastr';
import { UserDishService } from 'src/app/shared/services/user-dish.service';

@Component({
  selector: 'app-user-delete-all-products-dish',
  templateUrl: './user-delete-all-products-dish.component.html',
  styleUrls: ['./user-delete-all-products-dish.component.css']
})
export class UserDeleteAllProductsDishComponent implements OnInit {

  constructor(private closing:UserDishComponent, private toastr: ToastrService, private service:UserDishService) { }

  ngOnInit(): void {
  }

  Delete(){
    this.service.deleteAllDishProducts().subscribe(_=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Cleared successfully", "Dish Management")});
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}