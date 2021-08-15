import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';
import { ToastrService } from 'ngx-toastr';
import { Payment } from 'src/payment.model';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css']
})
export class PaymentComponent implements OnInit {

  constructor(public service:SharedService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
    this.service.refreshlist();
  }

  populateForm(selectedRecord: Payment){
    this.service.formData=Object.assign({},selectedRecord);
  }

  onDelete(id){
    if(confirm('Are you sure to delete this record?')){
      this.service.deletePayment(id).subscribe(res=>{
        this.toastr.error("Deleted successfully", 'Payment Deletion')
        this.service.refreshlist();
    })
  }
}

}
