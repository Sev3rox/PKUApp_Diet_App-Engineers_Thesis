import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDailySummaryComponent } from './user-daily-summary.component';

describe('UserDailySummaryComponent', () => {
  let component: UserDailySummaryComponent;
  let fixture: ComponentFixture<UserDailySummaryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDailySummaryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDailySummaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
