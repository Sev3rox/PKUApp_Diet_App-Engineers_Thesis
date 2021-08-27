import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserShowProductsComponent } from './user-show-products.component';

describe('UserShowProductsComponent', () => {
  let component: UserShowProductsComponent;
  let fixture: ComponentFixture<UserShowProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserShowProductsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserShowProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
