import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserExercisePlanDetailsExerciseComponent } from './user-exercise-plan-details-exercise.component';

describe('UserExercisePlanDetailsExerciseComponent', () => {
  let component: UserExercisePlanDetailsExerciseComponent;
  let fixture: ComponentFixture<UserExercisePlanDetailsExerciseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserExercisePlanDetailsExerciseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserExercisePlanDetailsExerciseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
