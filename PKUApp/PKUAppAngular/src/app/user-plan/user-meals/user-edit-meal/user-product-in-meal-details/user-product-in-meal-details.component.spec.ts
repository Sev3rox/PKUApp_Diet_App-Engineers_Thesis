import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserProductInMealDetailsComponent } from './user-product-in-meal-details.component';

describe('UserProductInMealDetailsComponent', () => {
  let component: UserProductInMealDetailsComponent;
  let fixture: ComponentFixture<UserProductInMealDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserProductInMealDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserProductInMealDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
