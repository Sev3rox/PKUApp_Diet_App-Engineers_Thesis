import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OwnAddEditProductComponent } from './own-add-edit-product.component';

describe('OwnAddEditProductComponent', () => {
  let component: OwnAddEditProductComponent;
  let fixture: ComponentFixture<OwnAddEditProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OwnAddEditProductComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OwnAddEditProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
