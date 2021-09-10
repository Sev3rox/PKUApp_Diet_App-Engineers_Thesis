import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserAddEditProductMealComponent } from './user-add-edit-product-meal.component';

describe('UserAddEditProductMealComponent', () => {
  let component: UserAddEditProductMealComponent;
  let fixture: ComponentFixture<UserAddEditProductMealComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserAddEditProductMealComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserAddEditProductMealComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
