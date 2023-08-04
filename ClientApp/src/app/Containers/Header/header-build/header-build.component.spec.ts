import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaderBuildComponent } from './header-build.component';

describe('HeaderBuildComponent', () => {
  let component: HeaderBuildComponent;
  let fixture: ComponentFixture<HeaderBuildComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HeaderBuildComponent]
    });
    fixture = TestBed.createComponent(HeaderBuildComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
