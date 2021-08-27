import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OwnShowProductsComponent } from './own-show-products.component';

describe('OwnShowProductsComponent', () => {
  let component: OwnShowProductsComponent;
  let fixture: ComponentFixture<OwnShowProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OwnShowProductsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OwnShowProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
