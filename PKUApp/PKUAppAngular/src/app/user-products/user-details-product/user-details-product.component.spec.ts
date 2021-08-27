import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDetailsProductComponent } from './user-details-product.component';

describe('UserDetailsProductComponent', () => {
  let component: UserDetailsProductComponent;
  let fixture: ComponentFixture<UserDetailsProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDetailsProductComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDetailsProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
