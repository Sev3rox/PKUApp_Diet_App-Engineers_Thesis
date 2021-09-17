import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDeleteAllProductsDishComponent } from './user-delete-all-products-dish.component';

describe('UserDeleteAllProductsDishComponent', () => {
  let component: UserDeleteAllProductsDishComponent;
  let fixture: ComponentFixture<UserDeleteAllProductsDishComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDeleteAllProductsDishComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDeleteAllProductsDishComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
