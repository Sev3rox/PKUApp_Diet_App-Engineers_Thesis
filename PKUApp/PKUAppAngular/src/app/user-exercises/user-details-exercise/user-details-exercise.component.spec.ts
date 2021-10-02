import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDetailsExerciseComponent } from './user-details-exercise.component';

describe('UserDetailsExerciseComponent', () => {
  let component: UserDetailsExerciseComponent;
  let fixture: ComponentFixture<UserDetailsExerciseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDetailsExerciseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDetailsExerciseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
