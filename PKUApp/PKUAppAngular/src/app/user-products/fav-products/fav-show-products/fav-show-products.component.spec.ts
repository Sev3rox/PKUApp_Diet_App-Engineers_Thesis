import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FavShowProductsComponent } from './fav-show-products.component';

describe('FavShowProductsComponent', () => {
  let component: FavShowProductsComponent;
  let fixture: ComponentFixture<FavShowProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FavShowProductsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FavShowProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
