import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserEditMealComponent } from './user-edit-meal.component';

describe('UserEditMealComponent', () => {
  let component: UserEditMealComponent;
  let fixture: ComponentFixture<UserEditMealComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserEditMealComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserEditMealComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
