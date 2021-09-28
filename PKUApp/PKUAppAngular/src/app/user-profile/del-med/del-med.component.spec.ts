import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DelMedComponent } from './del-med.component';

describe('DelMedComponent', () => {
  let component: DelMedComponent;
  let fixture: ComponentFixture<DelMedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DelMedComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DelMedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
