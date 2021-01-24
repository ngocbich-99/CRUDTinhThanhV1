import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditTinhthanhComponent } from './edit-tinhthanh.component';

describe('EditTinhthanhComponent', () => {
  let component: EditTinhthanhComponent;
  let fixture: ComponentFixture<EditTinhthanhComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditTinhthanhComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditTinhthanhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
