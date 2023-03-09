import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SecondaryRegionComponent } from './secondary-region.component';

describe('SecondaryRegionComponent', () => {
  let component: SecondaryRegionComponent;
  let fixture: ComponentFixture<SecondaryRegionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SecondaryRegionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SecondaryRegionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
