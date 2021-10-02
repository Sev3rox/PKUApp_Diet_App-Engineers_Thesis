import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserShowExercisesComponent } from './user-show-exercises.component';

describe('UserShowExercisesComponent', () => {
  let component: UserShowExercisesComponent;
  let fixture: ComponentFixture<UserShowExercisesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserShowExercisesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserShowExercisesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
