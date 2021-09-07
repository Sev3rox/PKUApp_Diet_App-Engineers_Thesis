import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDeleteProductMealComponent } from './user-delete-product-meal.component';

describe('UserDeleteProductMealComponent', () => {
  let component: UserDeleteProductMealComponent;
  let fixture: ComponentFixture<UserDeleteProductMealComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDeleteProductMealComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDeleteProductMealComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
