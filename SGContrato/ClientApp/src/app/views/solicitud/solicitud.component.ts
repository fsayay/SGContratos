import { Component, OnInit, ViewChild, Inject } from '@angular/core';
import { ContratosService } from '../contratos/contratos.service';
import { Router } from '@angular/router';
import { Contrato, Garantia, FormaPago, Multa, Informe, Acta, Entregable, Modificacion, Historial, Vencimiento } from '../../model.component';
import { MatTableDataSource, MatPaginatorModule, MatSort, MatPaginator } from '@angular/material';
import { SelectionModel } from '@angular/cdk/collections';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';


/**
 * @title Table with selection
 */
@Component({
  selector: 'app-solicitud',
  templateUrl: './solicitud.component.html',
  styleUrls: ['./solicitud.component.css']
})

export class SolicitudComponent {

  @ViewChild(MatSort, { static: false }) sort: MatSort;
  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;

  contratos: Contrato[];
  displayedColumns = ['select', 'id', 'txt_codigoContrato', 'txt_objetoContratacion', 'qn_proveedor', "txt_nombreAdministrador"];
  dataSource: any;

 // displayedColumns: string[] = ['select', 'ID', 'txt_codigoContrato', 'qn_proveedor', 'dt_fechaSuscripcion'];
 // dataSource = new MatTableDataSource<PeriodicElement>(this.contratos);
  selection = new SelectionModel<Contrato>(true, []);

  constructor(private contratosService: ContratosService, private router: Router, public dialog: MatDialog) { }

  ngOnInit() {
    this.renderDataTable();
    //this.cargarDatos();
  }

  renderDataTable() {
    this.contratosService.getContratos()
      .subscribe(
        x => {
          this.dataSource = new MatTableDataSource();
          this.dataSource.data = x;
          console.log(this.dataSource.data);
          this.dataSource.sort = this.sort;
          this.dataSource.paginator = this.paginator;
        },
        error => {
          console.log('Se produjo un error en el servidor!' + error);
        });
  } 

  //Metodo para filtrar
  applyFilter(filterValue: string) {
    filterValue = filterValue.trim(); // Remove whitespace
    filterValue = filterValue.toLowerCase(); // Datasource defaults to lowercase matches
    this.dataSource.filter = filterValue;
  }


  /** Whether the number of selected elements matches the total number of rows. */
  
  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  
  masterToggle() {
    this.isAllSelected() ?
      this.selection.clear() :
      this.dataSource.data.forEach(row => this.selection.select(row));
  }

  /** The label for the checkbox on the passed row */
  
  checkboxLabel(row?: Contrato): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.ID}`;
  }

  solicitarTransferencia() {
    console.log(this.selection.selected);
    this.dialog.open(DialogSolicitud, {
      data: this.selection.selected
    });
  }
  
}


@Component({
  selector: 'dialog-solicitud',
  template: 'dialog-solicitud.html',
})
export class DialogSolicitud {
  constructor(@Inject(MAT_DIALOG_DATA) public data: Contrato) { }
}
