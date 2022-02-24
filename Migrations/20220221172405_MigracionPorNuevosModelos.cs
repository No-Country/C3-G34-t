using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuditApp.Migrations
{
    public partial class MigracionPorNuevosModelos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoElevadores",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElevadorID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtiquetaCargaMaxima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtiquetasCurvas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etiquetastringerna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IRAM8412 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstructuraContraCaidas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProteccionLLuvia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeguridadMandos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SillaConductor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CinturonSeguridad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LucesGiroFreno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LucesTrabajo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bocina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvisoRetroceso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EspejosRetrovisores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arrestallamas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrenoEstacionario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CuñasRuedas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extintor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediosAsensoDesenso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AntideslizantesManoPisos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManualOperario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleraVelocidades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleraViasCirculacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleraProhibicionCarga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeñalizacionAltura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleraCinturon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleraAtrapamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleraInfladoNeumaticos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleraVelocidadCirculacionAut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleraProhibicionPersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleraVelocidadCirculacionPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleraRiesgosBateriasYGas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperacionPersonalAut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListadoControlRuedas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListadoFijacionBrazos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListadoFugasFluidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListadoNivelAceite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckMandosServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckBocina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckLuces = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckAvisoRetroceso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckFrenoPieMano = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckEspejos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckExtintor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckCinturonSeguridad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckSistemaTransmision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckEstadoAsiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InformeReparaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeñalizacionFueraServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevisionGeneralTriMestral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramaMantenimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElementosProteccionGLP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditorId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsableDesvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoElevadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HsyMs",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHyM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puesto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LimpiezaYorganizacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Protecciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoblesPulsadores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParadaDeEmergencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BarreraOpticaEnclavamientoElectrico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HerramientasManuales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerdidasAireAguaAceite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iluminacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CondicionesInseguras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarrosEmbalajes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PuertasTablerosElectricos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuinchesBalanceadores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entrenamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditorId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsableDesvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HsyMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plantas",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablerosElectricos",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableroYSector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleriaSeñalizada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleriaBuenEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarteleriaEPP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MPCProcEscritos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MPCCandadosTarjetas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MPCTableroProtegido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPPCalzadoDielectrico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPPGuantesDielectrico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPPLentes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableroLibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cerradura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrdenLimpieza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Matafuegos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditorId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsableDesvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablerosElectricos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoElevadores",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "HsyMs",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Plantas",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "TablerosElectricos",
                schema: "Identity");
        }
    }
}
