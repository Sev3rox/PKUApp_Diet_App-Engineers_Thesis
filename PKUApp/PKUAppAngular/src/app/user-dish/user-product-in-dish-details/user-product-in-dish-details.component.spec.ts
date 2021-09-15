import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserProductInDishDetailsComponent } from './user-product-in-dish-details.component';

describe('UserProductInDishDetailsComponent', () => {
  let component: UserProductInDishDetailsComponent;
  let fixture: ComponentFixture<UserProductInDishDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserProductInDishDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserProductInDishDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
