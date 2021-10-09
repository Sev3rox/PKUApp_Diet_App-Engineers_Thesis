import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserExerciseChartComponent } from './user-exercise-chart.component';

describe('UserExerciseChartComponent', () => {
  let component: UserExerciseChartComponent;
  let fixture: ComponentFixture<UserExerciseChartComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserExerciseChartComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserExerciseChartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
