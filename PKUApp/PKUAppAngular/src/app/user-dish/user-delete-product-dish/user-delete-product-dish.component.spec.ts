import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDeleteProductDishComponent } from './user-delete-product-dish.component';

describe('UserDeleteProductDishComponent', () => {
  let component: UserDeleteProductDishComponent;
  let fixture: ComponentFixture<UserDeleteProductDishComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDeleteProductDishComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDeleteProductDishComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
