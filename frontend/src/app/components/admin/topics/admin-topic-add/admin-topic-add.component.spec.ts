import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminTopicAddComponent } from './admin-topic-add.component';

describe('AdminTopicAddComponent', () => {
  let component: AdminTopicAddComponent;
  let fixture: ComponentFixture<AdminTopicAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminTopicAddComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdminTopicAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
