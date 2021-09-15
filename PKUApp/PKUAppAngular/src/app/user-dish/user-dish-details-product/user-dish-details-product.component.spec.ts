import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDishDetailsProductComponent } from './user-dish-details-product.component';

describe('UserDishDetailsProductComponent', () => {
  let component: UserDishDetailsProductComponent;
  let fixture: ComponentFixture<UserDishDetailsProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDishDetailsProductComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDishDetailsProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
