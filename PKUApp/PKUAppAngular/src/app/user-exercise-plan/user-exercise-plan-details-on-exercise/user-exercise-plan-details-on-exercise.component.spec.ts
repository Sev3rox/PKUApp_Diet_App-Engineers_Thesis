import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserExercisePlanDetailsOnExerciseComponent } from './user-exercise-plan-details-on-exercise.component';

describe('UserExercisePlanDetailsOnExerciseComponent', () => {
  let component: UserExercisePlanDetailsOnExerciseComponent;
  let fixture: ComponentFixture<UserExercisePlanDetailsOnExerciseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserExercisePlanDetailsOnExerciseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserExercisePlanDetailsOnExerciseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
