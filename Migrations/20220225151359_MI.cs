using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuditApp.Migrations
{
    public partial class MI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoElevadores",
                schema: "Identity",
                columns: table => new
                {
                    FormID = table.Column<int>(type: "int", nullable: false)
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
                    AuditorGuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsableDesvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoElevadores", x => x.FormID);
                });

            migrationBuilder.CreateTable(
                name: "HsyMs",
                schema: "Identity",
                columns: table => new
                {
                    FormID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHyM = table.Column<int>(type: "int", nullable: false),
                    Puesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LimpiezaYorganizacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Protecciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoblesPulsadores = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParadaDeEmergencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarreraOpticaEnclavamientoElectrico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HerramientasManuales = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerdidasAireAguaAceite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iluminacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CondicionesInseguras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarrosEmbalajes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PuertasTablerosElectricos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuinchesBalanceadores = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entrenamiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuditorGuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsableDesvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HsyMs", x => x.FormID);
                });

            migrationBuilder.CreateTable(
                name: "Plantas",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablerosElectricos",
                schema: "Identity",
                columns: table => new
                {
                    FormID = table.Column<int>(type: "int", nullable: false)
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
                    AuditorGuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsableDesvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablerosElectricos", x => x.FormID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "Identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Identity",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Identity",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Identity",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "Identity",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                schema: "Identity",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                schema: "Identity",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Identity",
                table: "UserRoles",
                column: "RoleId");
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
                name: "RoleClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "TablerosElectricos",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "Identity");
        }
    }
}
