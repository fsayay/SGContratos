import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormGarantiaComponent } from './form-garantia.component';


describe('FormGarantiaComponent', () => {
  let component: FormGarantiaComponent;
  let fixture: ComponentFixture<FormGarantiaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormGarantiaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormGarantiaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
