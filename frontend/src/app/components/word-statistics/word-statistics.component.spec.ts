import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WordStatisticsComponent } from './word-statistics.component';

describe('WordStatisticsComponent', () => {
  let component: WordStatisticsComponent;
  let fixture: ComponentFixture<WordStatisticsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WordStatisticsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WordStatisticsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
