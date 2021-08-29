import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FavDetailsProductsComponent } from './fav-details-products.component';

describe('FavDetailsProductsComponent', () => {
  let component: FavDetailsProductsComponent;
  let fixture: ComponentFixture<FavDetailsProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FavDetailsProductsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FavDetailsProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
