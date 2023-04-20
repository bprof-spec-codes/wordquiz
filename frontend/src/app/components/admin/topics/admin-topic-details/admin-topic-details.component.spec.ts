import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminTopicDetailsComponent } from './admin-topic-details.component';

describe('AdminTopicDetailsComponent', () => {
  let component: AdminTopicDetailsComponent;
  let fixture: ComponentFixture<AdminTopicDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminTopicDetailsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdminTopicDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
