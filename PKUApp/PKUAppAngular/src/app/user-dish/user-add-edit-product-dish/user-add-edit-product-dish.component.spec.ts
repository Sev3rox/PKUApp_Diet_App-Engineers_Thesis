import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserAddEditProductDishComponent } from './user-add-edit-product-dish.component';

describe('UserAddEditProductDishComponent', () => {
  let component: UserAddEditProductDishComponent;
  let fixture: ComponentFixture<UserAddEditProductDishComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserAddEditProductDishComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserAddEditProductDishComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
