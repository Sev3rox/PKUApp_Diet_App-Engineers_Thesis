import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserExercisePlanComponent } from './user-exercise-plan.component';

describe('UserExercisePlanComponent', () => {
  let component: UserExercisePlanComponent;
  let fixture: ComponentFixture<UserExercisePlanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserExercisePlanComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserExercisePlanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
