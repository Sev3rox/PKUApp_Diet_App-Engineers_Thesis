import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserExercisePlanDeleteExerciseComponent } from './user-exercise-plan-delete-exercise.component';

describe('UserExercisePlanDeleteExerciseComponent', () => {
  let component: UserExercisePlanDeleteExerciseComponent;
  let fixture: ComponentFixture<UserExercisePlanDeleteExerciseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserExercisePlanDeleteExerciseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserExercisePlanDeleteExerciseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
