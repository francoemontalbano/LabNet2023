import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipperIdComponent } from './shipper-id.component';

describe('ShipperIdComponent', () => {
  let component: ShipperIdComponent;
  let fixture: ComponentFixture<ShipperIdComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShipperIdComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShipperIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
