import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDishSummaryDetailsComponent } from './user-dish-summary-details.component';

describe('UserDishSummaryDetailsComponent', () => {
  let component: UserDishSummaryDetailsComponent;
  let fixture: ComponentFixture<UserDishSummaryDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDishSummaryDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDishSummaryDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
