﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using SGContrato.Models;

namespace SGContrato.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20200123010642_modificandoHistorial")]
    partial class modificandoHistorial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("SGContrato.Models.Acta_Entrega_Recepcion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("contratoID");

                    b.Property<DateTime>("dt_fechaActa");

                    b.Property<DateTime>("dt_fechaUltimoCambio");

                    b.Property<int>("qn_tipoActa");

                    b.Property<string>("txt_archivoActa");

                    b.Property<string>("txt_codigoActa");

                    b.HasKey("ID");

                    b.HasIndex("contratoID");

                    b.ToTable("acta");
                });

            modelBuilder.Entity("SGContrato.Models.Contrato", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("bol_recurrencia");

                    b.Property<DateTime>("dt_fechaFin");

                    b.Property<DateTime>("dt_fechaInicio");

                    b.Property<DateTime>("dt_fechaSuscripcion");

                    b.Property<DateTime>("dt_fechaUltimoCambio");

                    b.Property<int>("qn_estadoContrato");

                    b.Property<int>("qn_proveedor");

                    b.Property<int>("qn_tipoContrato");

                    b.Property<int>("qn_tipoProceso");

                    b.Property<int>("qn_unidadConsolidadora");

                    b.Property<int>("qn_vigenciaContrato");

                    b.Property<string>("txt_archivoContrato");

                    b.Property<string>("txt_codigoContrato");

                    b.Property<string>("txt_detalleFormaPago");

                    b.Property<string>("txt_detalleGarantias");

                    b.Property<string>("txt_nombreAdministrador");

                    b.Property<string>("txt_nombreDelegado");

                    b.Property<string>("txt_nombreTecnicoExterno");

                    b.Property<string>("txt_numProceso");

                    b.Property<string>("txt_objetoContratacion");

                    b.Property<double>("vm_montoAdjudicado");

                    b.HasKey("ID");

                    b.ToTable("contrato");
                });

            modelBuilder.Entity("SGContrato.Models.Entregable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("contratoID");

                    b.Property<DateTime>("dt_fechaEntregable");

                    b.Property<DateTime>("dt_fechaUltimoCambio");

                    b.Property<int>("qn_cantidadEntregable");

                    b.Property<int>("qn_tipoEntregable");

                    b.Property<string>("txt_archivoEntregable");

                    b.Property<string>("txt_descripcionEntregable");

                    b.HasKey("ID");

                    b.HasIndex("contratoID");

                    b.ToTable("entregable");
                });

            modelBuilder.Entity("SGContrato.Models.FechaModificado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dt_fechaActual");

                    b.Property<DateTime>("dt_fechaAnterior");

                    b.Property<int>("modificacionID");

                    b.HasKey("ID");

                    b.HasIndex("modificacionID")
                        .IsUnique();

                    b.ToTable("fechaModificado");
                });

            modelBuilder.Entity("SGContrato.Models.FormaPago", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("contratoID");

                    b.Property<DateTime>("dt_fechaUltimoCambio");

                    b.Property<int>("qn_tipoPago");

                    b.Property<string>("txt_archivoPago");

                    b.HasKey("ID");

                    b.HasIndex("contratoID")
                        .IsUnique();

                    b.ToTable("formaPago");
                });

            modelBuilder.Entity("SGContrato.Models.Garantia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("contratoID");

                    b.Property<DateTime>("dt_fechaUltimoCambio");

                    b.Property<DateTime>("dt_finGarantia");

                    b.Property<DateTime>("dt_inicioGarantia");

                    b.Property<int>("qn_tipoGarantia");

                    b.Property<string>("txt_archivoGarantia");

                    b.Property<string>("txt_codigoGarantia");

                    b.Property<string>("txt_proveedorGarantia");

                    b.Property<double>("vm_valorGarantia");

                    b.HasKey("ID");

                    b.HasIndex("contratoID");

                    b.ToTable("garantia");
                });

            modelBuilder.Entity("SGContrato.Models.Historial", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("contratoID");

                    b.Property<DateTime>("dt_fechaAccion");

                    b.Property<string>("txt_accionHistorial");

                    b.HasKey("ID");

                    b.HasIndex("contratoID");

                    b.ToTable("historial");
                });

            modelBuilder.Entity("SGContrato.Models.Informe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("contratoID");

                    b.Property<DateTime>("dt_fechaInforme");

                    b.Property<DateTime>("dt_fechaUltimoCambio");

                    b.Property<int>("qn_tipoInforme");

                    b.Property<string>("txt_archivoInforme");

                    b.Property<string>("txt_codigoInforme");

                    b.HasKey("ID");

                    b.HasIndex("contratoID");

                    b.ToTable("informe");
                });

            modelBuilder.Entity("SGContrato.Models.Modificacion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("contratoID");

                    b.Property<DateTime>("dt_fechaUltimoCambio");

                    b.Property<int>("qn_tipoModificacion");

                    b.Property<string>("txt_motivoModificacion");

                    b.HasKey("ID");

                    b.HasIndex("contratoID");

                    b.ToTable("modificacion");
                });

            modelBuilder.Entity("SGContrato.Models.Multa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("contratoID");

                    b.Property<DateTime>("dt_fechaMulta");

                    b.Property<DateTime>("dt_fechaUltimoCambio");

                    b.Property<int>("qn_tipoMulta");

                    b.Property<string>("txt_codigoInforme");

                    b.Property<string>("txt_motivoMulta");

                    b.Property<double>("vm_montoMulta");

                    b.HasKey("ID");

                    b.HasIndex("contratoID");

                    b.ToTable("multa");
                });

            modelBuilder.Entity("SGContrato.Models.Pago", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dt_fechaUltimoCambio");

                    b.Property<DateTime>("dt_realPago");

                    b.Property<DateTime>("dt_tentativaPago");

                    b.Property<int>("formaPagoID");

                    b.Property<float>("qn_porcentajePago");

                    b.Property<string>("txt_comprobantePago");

                    b.Property<double>("vm_montoPago");

                    b.HasKey("ID");

                    b.HasIndex("formaPagoID");

                    b.ToTable("pago");
                });

            modelBuilder.Entity("SGContrato.Models.Rol", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("txt_rolDetaile");

                    b.Property<string>("txt_rolName");

                    b.HasKey("ID");

                    b.ToTable("rol");
                });

            modelBuilder.Entity("SGContrato.Models.Seccion", b =>
                {
                    b.Property<int>("seccionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("txt_detalleSeccion");

                    b.Property<string>("txt_nombreSeccion");

                    b.HasKey("seccionID");

                    b.ToTable("Seccion");
                });

            modelBuilder.Entity("SGContrato.Models.Tipo", b =>
                {
                    b.Property<int>("tipoID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("seccionId");

                    b.Property<string>("txt_detalleTipo");

                    b.Property<string>("txt_nombreTipo");

                    b.HasKey("tipoID");

                    b.HasIndex("seccionId");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("SGContrato.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("txt_emailAlterno");

                    b.Property<string>("txt_token");

                    b.Property<string>("txt_username");

                    b.HasKey("ID");

                    b.ToTable("user");
                });

            modelBuilder.Entity("SGContrato.Models.UserRol", b =>
                {
                    b.Property<int>("userID");

                    b.Property<int>("rolID");

                    b.HasKey("userID", "rolID");

                    b.HasIndex("rolID");

                    b.ToTable("userRol");
                });

            modelBuilder.Entity("SGContrato.Models.ValorModificado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("modificacionID");

                    b.Property<double>("vm_valorActual");

                    b.Property<double>("vm_valorAnterior");

                    b.HasKey("ID");

                    b.HasIndex("modificacionID")
                        .IsUnique();

                    b.ToTable("valorModificado");
                });

            modelBuilder.Entity("SGContrato.Models.Vencimientos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("contratoID");

                    b.Property<DateTime>("dt_fechaUltimoCambio");

                    b.Property<DateTime>("dt_fechaVencimiento");

                    b.Property<int>("qn_diasAnticipacion");

                    b.Property<int>("qn_frecuenciaAnticipacion");

                    b.Property<string>("txt_nombreSeccion");

                    b.Property<string>("txt_nombreTipo");

                    b.HasKey("ID");

                    b.HasIndex("contratoID");

                    b.ToTable("vencimientos");
                });

            modelBuilder.Entity("SGContrato.Models.Acta_Entrega_Recepcion", b =>
                {
                    b.HasOne("SGContrato.Models.Contrato")
                        .WithMany("actas")
                        .HasForeignKey("contratoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.Entregable", b =>
                {
                    b.HasOne("SGContrato.Models.Contrato")
                        .WithMany("entregables")
                        .HasForeignKey("contratoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.FechaModificado", b =>
                {
                    b.HasOne("SGContrato.Models.Modificacion")
                        .WithOne("fechaModificado")
                        .HasForeignKey("SGContrato.Models.FechaModificado", "modificacionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.FormaPago", b =>
                {
                    b.HasOne("SGContrato.Models.Contrato")
                        .WithOne("formaPago")
                        .HasForeignKey("SGContrato.Models.FormaPago", "contratoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.Garantia", b =>
                {
                    b.HasOne("SGContrato.Models.Contrato")
                        .WithMany("garantias")
                        .HasForeignKey("contratoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.Historial", b =>
                {
                    b.HasOne("SGContrato.Models.Contrato")
                        .WithMany("historial")
                        .HasForeignKey("contratoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.Informe", b =>
                {
                    b.HasOne("SGContrato.Models.Contrato")
                        .WithMany("informes")
                        .HasForeignKey("contratoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.Modificacion", b =>
                {
                    b.HasOne("SGContrato.Models.Contrato")
                        .WithMany("modificaciones")
                        .HasForeignKey("contratoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.Multa", b =>
                {
                    b.HasOne("SGContrato.Models.Contrato")
                        .WithMany("multas")
                        .HasForeignKey("contratoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.Pago", b =>
                {
                    b.HasOne("SGContrato.Models.FormaPago")
                        .WithMany("pagos")
                        .HasForeignKey("formaPagoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.Tipo", b =>
                {
                    b.HasOne("SGContrato.Models.Seccion")
                        .WithMany("tipos")
                        .HasForeignKey("seccionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.UserRol", b =>
                {
                    b.HasOne("SGContrato.Models.Rol", "rol")
                        .WithMany("userRol")
                        .HasForeignKey("rolID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SGContrato.Models.User", "user")
                        .WithMany("userRol")
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.ValorModificado", b =>
                {
                    b.HasOne("SGContrato.Models.Modificacion")
                        .WithOne("valorModificado")
                        .HasForeignKey("SGContrato.Models.ValorModificado", "modificacionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGContrato.Models.Vencimientos", b =>
                {
                    b.HasOne("SGContrato.Models.Contrato")
                        .WithMany("vencimientos")
                        .HasForeignKey("contratoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
