import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserMealDetailsProductComponent } from './user-meal-details-product.component';

describe('UserMealDetailsProductComponent', () => {
  let component: UserMealDetailsProductComponent;
  let fixture: ComponentFixture<UserMealDetailsProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserMealDetailsProductComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserMealDetailsProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
