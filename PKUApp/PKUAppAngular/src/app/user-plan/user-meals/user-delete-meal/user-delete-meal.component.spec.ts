import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDeleteMealComponent } from './user-delete-meal.component';

describe('UserDeleteMealComponent', () => {
  let component: UserDeleteMealComponent;
  let fixture: ComponentFixture<UserDeleteMealComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDeleteMealComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDeleteMealComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
