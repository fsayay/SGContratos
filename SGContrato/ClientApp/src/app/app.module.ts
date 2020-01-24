import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgxPaginationModule } from 'ngx-pagination';

// Angular Browser
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

// Angular Material
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatMomentDateModule } from '@angular/material-moment-adapter';
import { MatNativeDateModule } from '@angular/material/core';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatTableModule } from '@angular/material/table';
import { MatCheckboxModule, MatSortModule, MatPaginatorModule } from '@angular/material';
import { MatDialogModule } from '@angular/material/dialog';

// Componentes
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { HomeComponent } from './home/home.component';
import { ContratosComponent } from './views/contratos/contratos.component';
import { SideNavComponent } from './views/sidenav/sidenav.component';
import { DatosGeneralesComponent } from './views/datosGenerales/datosGenerales.component';
import { ActasComponent } from './views/actas/actas.component';
import { EntregablesComponent } from './views/entregables/entregables.component';
import { GarantiasComponent } from './views/garantias/garantias.component';
import { InformesComponent } from './views/informes/informes.component';
import { ModificacionesComponent } from './views/modificaciones/modificaciones.component';
import { MultasComponent } from './views/multas/multas.component';
import { PagosComponent } from './views/pagos/pagos.component';
import { SolicitudComponent } from './views/solicitud/solicitud.component';
import { VencimientosComponent } from './views/vencimientos/vencimientos.component';
import { ConsultaComponent } from './views/consultaGenerica/consulta.component';
import { ReporteComponent } from './views/reportes/reporte.component';
import { HistorialComponent } from './views/historial/historial.component';
import { NuevoContratoComponent } from './views/nuevo-contrato/nuevo-contrato.component';



import { ContratosService } from './views/contratos/contratos.service';
import { NgbModal, NgbModule, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

//Forms
import { FormGarantiaComponent } from './formularios/formGarantia/form-garantia.component';
import { FormEntregableComponent } from './formularios/formEntregable/form-entregable.component';
import { FormInformeComponent } from './formularios/formInforme/form-informe.component';
import { FormActaComponent } from './formularios/formActa/form-acta.component';
import { FormMultaComponent } from './formularios/formMulta/form-multa.component';

//Pipes
import { FiltroContratoPipe } from './pipes/filtro-contrato.pipe';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    HomeComponent,
    ContratosComponent,
    SideNavComponent,
    DatosGeneralesComponent,
    ActasComponent,
    EntregablesComponent,
    GarantiasComponent,
    InformesComponent,
    ModificacionesComponent,
    MultasComponent,
    PagosComponent,
    SolicitudComponent,
    VencimientosComponent,
    ConsultaComponent,
    ReporteComponent,
    HistorialComponent,
    NuevoContratoComponent,
    FormGarantiaComponent,
    FormEntregableComponent,
    FormInformeComponent,
    FormActaComponent,
    FormMultaComponent,
    FiltroContratoPipe
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgxPaginationModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatDatepickerModule,
    MatMomentDateModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressSpinnerModule,
    MatTableModule,
    MatSortModule,
    MatCheckboxModule,
    MatDialogModule,
    BrowserAnimationsModule,
    NgbModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'contratos', component: ContratosComponent },
      //{ path: 'datosGenerales/:i', component: DatosGeneralesComponent },
      { path: 'datosGenerales', component: DatosGeneralesComponent },
      { path: 'garantias', component: GarantiasComponent },
      { path: 'actas', component: ActasComponent },
      { path: 'entregables', component: EntregablesComponent },
      { path: 'informes', component: InformesComponent },
      { path: 'modificaciones', component: ModificacionesComponent },
      { path: 'multas', component: MultasComponent },
      { path: 'pagos', component: PagosComponent },
      { path: 'solicitud', component: SolicitudComponent },
      { path: 'vencimientos', component: VencimientosComponent },
      { path: 'consulta', component: ConsultaComponent },
      { path: 'reportes', component: ReporteComponent },
      { path: 'historial', component: HistorialComponent },
      { path: 'registrar-contrato', component: NuevoContratoComponent },
    ])
  ],
  providers: [ContratosService, NgbActiveModal, MatNativeDateModule, MatDatepickerModule
    ],
  bootstrap: [AppComponent],
  entryComponents: [
    FormGarantiaComponent,
    FormEntregableComponent,
    FormInformeComponent,
    FormActaComponent,
    FormMultaComponent
  ],
  exports: [
    FiltroContratoPipe
  ]
})
export class AppModule { }
