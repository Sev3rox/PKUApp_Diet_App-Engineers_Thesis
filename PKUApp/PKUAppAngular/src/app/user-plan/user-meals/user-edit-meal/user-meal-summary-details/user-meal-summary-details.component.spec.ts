import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserMealSummaryDetailsComponent } from './user-meal-summary-details.component';

describe('UserMealSummaryDetailsComponent', () => {
  let component: UserMealSummaryDetailsComponent;
  let fixture: ComponentFixture<UserMealSummaryDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserMealSummaryDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserMealSummaryDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
