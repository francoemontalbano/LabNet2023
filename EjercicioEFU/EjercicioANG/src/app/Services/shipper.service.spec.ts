import { TestBed } from '@angular/core/testing';
import { ShippersService } from './shipper.service';

describe('ShipperService', () => {
  let service: ShippersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ShippersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
