import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserCreateDishComponent } from './user-create-dish.component';

describe('UserCreateDishComponent', () => {
  let component: UserCreateDishComponent;
  let fixture: ComponentFixture<UserCreateDishComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserCreateDishComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserCreateDishComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
