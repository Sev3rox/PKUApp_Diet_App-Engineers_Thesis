import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NotlogedShowProductsComponent } from './notloged-show-products.component';

describe('NotlogedShowProductsComponent', () => {
  let component: NotlogedShowProductsComponent;
  let fixture: ComponentFixture<NotlogedShowProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NotlogedShowProductsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NotlogedShowProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
