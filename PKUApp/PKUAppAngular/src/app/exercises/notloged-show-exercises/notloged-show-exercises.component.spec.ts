import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NotlogedShowExercisesComponent } from './notloged-show-exercises.component';

describe('NotlogedShowExercisesComponent', () => {
  let component: NotlogedShowExercisesComponent;
  let fixture: ComponentFixture<NotlogedShowExercisesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NotlogedShowExercisesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NotlogedShowExercisesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
