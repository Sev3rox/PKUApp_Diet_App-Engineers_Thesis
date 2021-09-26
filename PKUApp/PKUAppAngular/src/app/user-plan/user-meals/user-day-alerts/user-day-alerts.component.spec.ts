import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDayAlertsComponent } from './user-day-alerts.component';

describe('UserDayAlertsComponent', () => {
  let component: UserDayAlertsComponent;
  let fixture: ComponentFixture<UserDayAlertsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDayAlertsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDayAlertsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
