import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserAddEditMealComponent } from './user-add-edit-meal.component';

describe('UserAddEditMealComponent', () => {
  let component: UserAddEditMealComponent;
  let fixture: ComponentFixture<UserAddEditMealComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserAddEditMealComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserAddEditMealComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
