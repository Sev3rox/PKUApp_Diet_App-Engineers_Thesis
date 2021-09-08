import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserEditProductMealComponent } from './user-edit-product-meal.component';

describe('UserEditProductMealComponent', () => {
  let component: UserEditProductMealComponent;
  let fixture: ComponentFixture<UserEditProductMealComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserEditProductMealComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserEditProductMealComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
