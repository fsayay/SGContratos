import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Contrato, Tipo } from '../../model.component';
import { ContratosService } from '../contratos/contratos.service';
import { Router } from '@angular/router';
import { ActasService } from '../actas/actas.service';

@Component({
  selector: 'app-consulta',
  templateUrl: './consulta.component.html',
  styleUrls: ['./consulta.component.css']
})
export class ConsultaComponent implements OnInit {

  public contratos: Contrato[];
  public contratosFiltrados: Contrato[];
  public formGroup: FormGroup;
  public tipoContrato: Tipo;
  public estado: Tipo;

  constructor(private formBuilder: FormBuilder,private actasService: ActasService, private contratosService: ContratosService, private router: Router) { }

  ngOnInit() {

    this.createForm();
    this.actasService.getTipoActa('1').subscribe(tiposDesdeWS => this.tipoContrato = tiposDesdeWS, error => console.error(error));
    this.actasService.getTipoActa('21').subscribe(tiposDesdeWS => this.estado = tiposDesdeWS, error => console.error(error));
    this.contratosService.getContratos().subscribe(contratosDesdeWS => this.contratos = contratosDesdeWS, error => console.error(error));
  }

  private createForm() {
    this.formGroup = this.formBuilder.group({
      codigoContrato: [''],
      adminContrato: [''],
      estadoContrato: ['', Validators.required],
      codigoProceso: [''],
      proveedor: [''],
      tipoContrato: [''],
      fechaSubs1: ['', Validators.required],
      fechaSubs2: ['', Validators.required],
      fechaInicio1: ['', Validators.required],
      fechaInicio2: ['', Validators.required],
      fechaFin1: ['', Validators.required],
      fechaFin2: ['', Validators.required]
    });
  }

  private submitForm() {
    console.log(this.formGroup.value)
  }

  mostrarDetalle(contratoId: string) {
    this.contratosService.setContratoId(contratoId);
    this.router.navigate(["/datosGenerales"]);
  }

}
