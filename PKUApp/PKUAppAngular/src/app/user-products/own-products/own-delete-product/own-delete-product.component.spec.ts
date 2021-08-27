import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OwnDeleteProductComponent } from './own-delete-product.component';

describe('OwnDeleteProductComponent', () => {
  let component: OwnDeleteProductComponent;
  let fixture: ComponentFixture<OwnDeleteProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OwnDeleteProductComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OwnDeleteProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
