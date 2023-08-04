import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FooterBuildComponent } from './footer-build.component';

describe('FooterBuildComponent', () => {
  let component: FooterBuildComponent;
  let fixture: ComponentFixture<FooterBuildComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FooterBuildComponent]
    });
    fixture = TestBed.createComponent(FooterBuildComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
