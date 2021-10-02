import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NotlogedDetailsExerciseComponent } from './notloged-details-exercise.component';

describe('NotlogedDetailsExerciseComponent', () => {
  let component: NotlogedDetailsExerciseComponent;
  let fixture: ComponentFixture<NotlogedDetailsExerciseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NotlogedDetailsExerciseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NotlogedDetailsExerciseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
