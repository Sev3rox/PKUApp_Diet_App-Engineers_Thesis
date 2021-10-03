import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserExercisePlanAddEditExerciseComponent } from './user-exercise-plan-add-edit-exercise.component';

describe('UserExercisePlanAddEditExerciseComponent', () => {
  let component: UserExercisePlanAddEditExerciseComponent;
  let fixture: ComponentFixture<UserExercisePlanAddEditExerciseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserExercisePlanAddEditExerciseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserExercisePlanAddEditExerciseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
