import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DataImportExportComponent } from './data-import-export.component';

describe('DataImportExportComponent', () => {
  let component: DataImportExportComponent;
  let fixture: ComponentFixture<DataImportExportComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DataImportExportComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DataImportExportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
