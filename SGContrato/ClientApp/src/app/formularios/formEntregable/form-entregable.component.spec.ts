import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormEntregableComponent } from './form-entregable.component';


describe('FormEntregableComponent', () => {
  let component: FormEntregableComponent;
  let fixture: ComponentFixture<FormEntregableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormEntregableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormEntregableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
