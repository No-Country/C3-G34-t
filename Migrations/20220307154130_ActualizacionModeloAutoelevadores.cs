using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuditApp.Migrations
{
    public partial class ActualizacionModeloAutoelevadores : Migration
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
                    ElevadorID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EtiquetaCargaMaxima = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EtiquetasCurvas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Etiquetastringerna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IRAM8412 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstructuraContraCaidas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProteccionLLuvia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeguridadMandos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SillaConductor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CinturonSeguridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LucesGiroFreno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LucesTrabajo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bocina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvisoRetroceso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EspejosRetrovisores = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Arrestallamas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DispositivoAislante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrenoEstacionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuñasRuedas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extintor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediosAsensoDesenso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AntideslizantesManoPisos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManualOperario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleraVelocidades = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleraViasCirculacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleraProhibicionCarga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeñalizacionAltura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleraCinturon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleraAtrapamiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleraAplicarFreno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleraInfladoNeumaticos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleraVelocidadCirculacionAut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleraProhibicionPersonas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleraProhibicionCircPersonas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleraRiesgosBateriasYGas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperacionPersonalAut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListadoControlRuedas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListadoFijacionBrazos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListadoFugasFluidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListadoNivelAceite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckMandosServicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckBocina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckLuces = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckAvisoRetroceso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckFrenoPieMano = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckEspejos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckExtintor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckCinturonSeguridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckSistemaTransmision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckEstadoAsiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformeReparaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeñalizacionFueraServicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RevisionGeneralTriMestral = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramaMantenimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElementosProteccionGLP = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    TableroYSector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleriaSeñalizada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleriaBuenEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarteleriaEPP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MPCProcEscritos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MPCCandadosTarjetas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MPCTableroProtegido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPPCalzadoDielectrico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPPGuantesDielectrico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPPLentes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TableroLibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cerradura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdenLimpieza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matafuegos = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
