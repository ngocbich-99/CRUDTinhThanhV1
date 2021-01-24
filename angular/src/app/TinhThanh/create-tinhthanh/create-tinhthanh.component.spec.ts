import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateTinhthanhComponent } from './create-tinhthanh.component';

describe('CreateTinhthanhComponent', () => {
  let component: CreateTinhthanhComponent;
  let fixture: ComponentFixture<CreateTinhthanhComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateTinhthanhComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateTinhthanhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
