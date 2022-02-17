using Microsoft.EntityFrameworkCore.Migrations;

namespace MaxionMontichV2.Migrations
{
    public partial class MI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cumple = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoCumple = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoAplica = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Form_Elevadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    opcionesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_Elevadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Form_Elevadores_Opciones_opcionesId",
                        column: x => x.opcionesId,
                        principalTable: "Opciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Form_Herra_Y_Maq",
                columns: table => new
                {
                    IdForHyM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipoMaquina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puesto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    limpiezaYorganizacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespSolucion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    opcionesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_Herra_Y_Maq", x => x.IdForHyM);
                    table.ForeignKey(
                        name: "FK_Form_Herra_Y_Maq_Opciones_opcionesId",
                        column: x => x.opcionesId,
                        principalTable: "Opciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Form_Tab_Electricos",
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
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespSolucion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    opcionesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_Tab_Electricos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Form_Tab_Electricos_Opciones_opcionesId",
                        column: x => x.opcionesId,
                        principalTable: "Opciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Elevadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantaId = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elevadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elevadores_Planta_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Planta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Herra_Y_Maq",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantaId = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Herra_Y_Maq", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Herra_Y_Maq_Planta_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Planta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tab_Electricos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantaId = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tab_Electricos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tab_Electricos_Planta_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Planta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    rolId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_rolId",
                        column: x => x.rolId,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Elevadores_PlantaId",
                table: "Elevadores",
                column: "PlantaId");

            migrationBuilder.CreateIndex(
                name: "IX_Form_Elevadores_opcionesId",
                table: "Form_Elevadores",
                column: "opcionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Form_Herra_Y_Maq_opcionesId",
                table: "Form_Herra_Y_Maq",
                column: "opcionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Form_Tab_Electricos_opcionesId",
                table: "Form_Tab_Electricos",
                column: "opcionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Herra_Y_Maq_PlantaId",
                table: "Herra_Y_Maq",
                column: "PlantaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tab_Electricos_PlantaId",
                table: "Tab_Electricos",
                column: "PlantaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_rolId",
                table: "Usuario",
                column: "rolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elevadores");

            migrationBuilder.DropTable(
                name: "Form_Elevadores");

            migrationBuilder.DropTable(
                name: "Form_Herra_Y_Maq");

            migrationBuilder.DropTable(
                name: "Form_Tab_Electricos");

            migrationBuilder.DropTable(
                name: "Herra_Y_Maq");

            migrationBuilder.DropTable(
                name: "Tab_Electricos");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Opciones");

            migrationBuilder.DropTable(
                name: "Planta");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
