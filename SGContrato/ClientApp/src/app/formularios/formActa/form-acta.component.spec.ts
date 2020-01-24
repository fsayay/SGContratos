import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormActaComponent } from './form-acta.component';


describe('FormActaComponent', () => {
  let component: FormActaComponent;
  let fixture: ComponentFixture<FormActaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormActaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormActaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
