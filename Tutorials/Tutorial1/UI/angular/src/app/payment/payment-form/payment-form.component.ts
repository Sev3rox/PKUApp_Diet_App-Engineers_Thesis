import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';
import {NgForm} from '@angular/forms'
import { Payment } from 'src/payment.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-payment-form',
  templateUrl: './payment-form.component.html',
  styleUrls: ['./payment-form.component.css']
})
export class PaymentFormComponent implements OnInit {

  constructor(public service:SharedService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm){
    if(this.service.formData.PaymentId==0){
      this.insertRecord(form)
    }
    else{
      this.updateRecord(form)
    }
  }

  insertRecord(form: NgForm){
    this.service.postPayment().subscribe(res=>{
      this.resetForm(form);
      this.service.refreshlist();
      this.toastr.success("Submitted successfully", "Payment Register");
    })
  }

  updateRecord(form: NgForm){
    this.service.putPayment().subscribe(res=>{
      this.resetForm(form);
      this.service.refreshlist();
      this.toastr.success("Updated successfully", "Payment Update");
    })
  }
  resetForm(form: NgForm){
    form.form.reset();
    this.service.formData=new Payment();
  }
}
