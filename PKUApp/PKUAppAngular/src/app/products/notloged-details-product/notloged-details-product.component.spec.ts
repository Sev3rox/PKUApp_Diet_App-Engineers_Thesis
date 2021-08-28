import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NotlogedDetailsProductComponent } from './notloged-details-product.component';

describe('NotlogedDetailsProductComponent', () => {
  let component: NotlogedDetailsProductComponent;
  let fixture: ComponentFixture<NotlogedDetailsProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NotlogedDetailsProductComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NotlogedDetailsProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
