import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserShowMealsComponent } from './user-show-meals.component';

describe('UserShowMealsComponent', () => {
  let component: UserShowMealsComponent;
  let fixture: ComponentFixture<UserShowMealsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserShowMealsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserShowMealsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
