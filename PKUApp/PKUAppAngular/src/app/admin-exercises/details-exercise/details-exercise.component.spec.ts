import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsExerciseComponent } from './details-exercise.component';

describe('DetailsExerciseComponent', () => {
  let component: DetailsExerciseComponent;
  let fixture: ComponentFixture<DetailsExerciseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailsExerciseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailsExerciseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
