import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ResetLimitsComponent } from './reset-limits.component';

describe('ResetLimitsComponent', () => {
  let component: ResetLimitsComponent;
  let fixture: ComponentFixture<ResetLimitsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ResetLimitsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ResetLimitsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
