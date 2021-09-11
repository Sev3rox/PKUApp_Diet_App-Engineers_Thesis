import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDetailsMealComponent } from './user-details-meal.component';

describe('UserDetailsMealComponent', () => {
  let component: UserDetailsMealComponent;
  let fixture: ComponentFixture<UserDetailsMealComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDetailsMealComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDetailsMealComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
