import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OwnProductsComponent } from './own-products.component';

describe('OwnProductsComponent', () => {
  let component: OwnProductsComponent;
  let fixture: ComponentFixture<OwnProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OwnProductsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OwnProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
