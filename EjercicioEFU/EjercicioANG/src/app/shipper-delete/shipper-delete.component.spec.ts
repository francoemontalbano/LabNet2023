import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipperDeleteComponent } from './shipper-delete.component';

describe('ShipperDeleteComponent', () => {
  let component: ShipperDeleteComponent;
  let fixture: ComponentFixture<ShipperDeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShipperDeleteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShipperDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
