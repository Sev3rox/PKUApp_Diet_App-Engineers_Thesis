import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserAddProductMealComponent } from './user-add-product-meal.component';

describe('UserAddProductMealComponent', () => {
  let component: UserAddProductMealComponent;
  let fixture: ComponentFixture<UserAddProductMealComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserAddProductMealComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserAddProductMealComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
