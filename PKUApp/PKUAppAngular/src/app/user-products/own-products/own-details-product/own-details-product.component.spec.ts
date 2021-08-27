import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OwnDetailsProductComponent } from './own-details-product.component';

describe('OwnDetailsProductComponent', () => {
  let component: OwnDetailsProductComponent;
  let fixture: ComponentFixture<OwnDetailsProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OwnDetailsProductComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OwnDetailsProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
