import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDetailsMedComponent } from './user-details-med.component';

describe('UserDetailsMedComponent', () => {
  let component: UserDetailsMedComponent;
  let fixture: ComponentFixture<UserDetailsMedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDetailsMedComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDetailsMedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
