﻿// <auto-generated />
using System;
using AuditApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuditApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220305232655_nuevaPropEnModeloAutoelevadores")]
    partial class nuevaPropEnModeloAutoelevadores
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Identity")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuditApp.Models.FormAutoElevadores", b =>
                {
                    b.Property<int>("FormID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AntideslizantesManoPisos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Arrestallamas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("AuditorGuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AvisoRetroceso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bocina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleraAplicarFreno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleraAtrapamiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleraCinturon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleraInfladoNeumaticos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleraProhibicionCarga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleraProhibicionCircPersonas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleraProhibicionPersonas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleraRiesgosBateriasYGas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleraVelocidadCirculacionAut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleraVelocidades")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleraViasCirculacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckAvisoRetroceso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckBocina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckCinturonSeguridad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckEspejos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckEstadoAsiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckExtintor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckFrenoPieMano")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckLuces")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckMandosServicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckSistemaTransmision")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CinturonSeguridad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CuñasRuedas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DispositivoAislante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElementosProteccionGLP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElevadorID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EspejosRetrovisores")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstructuraContraCaidas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EtiquetaCargaMaxima")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EtiquetasCurvas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etiquetastringerna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extintor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("FrenoEstacionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IRAM8412")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InformeReparaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListadoControlRuedas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListadoFijacionBrazos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListadoFugasFluidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListadoNivelAceite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesGiroFreno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesTrabajo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManualOperario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediosAsensoDesenso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperacionPersonalAut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantaId")
                        .HasColumnType("int");

                    b.Property<string>("ProgramaMantenimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProteccionLLuvia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponsableDesvio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RevisionGeneralTriMestral")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeguridadMandos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeñalizacionAltura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeñalizacionFueraServicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SillaConductor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormID");

                    b.ToTable("AutoElevadores");
                });

            modelBuilder.Entity("AuditApp.Models.FormHyM", b =>
                {
                    b.Property<int>("FormID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("AuditorGuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BarreraOpticaEnclavamientoElectrico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarrosEmbalajes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CondicionesInseguras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoblesPulsadores")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Entrenamiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuinchesBalanceadores")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HerramientasManuales")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdHyM")
                        .HasColumnType("int");

                    b.Property<string>("Iluminacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LimpiezaYorganizacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParadaDeEmergencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PerdidasAireAguaAceite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantaId")
                        .HasColumnType("int");

                    b.Property<string>("Protecciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PuertasTablerosElectricos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Puesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponsableDesvio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormID");

                    b.ToTable("HsyMs");
                });

            modelBuilder.Entity("AuditApp.Models.FormTableroElectrico", b =>
                {
                    b.Property<int>("FormID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("AuditorGuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CarteleriaBuenEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleriaEPP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarteleriaSeñalizada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cerradura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPPCalzadoDielectrico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPPGuantesDielectrico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPPLentes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("MPCCandadosTarjetas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MPCProcEscritos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MPCTableroProtegido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Matafuegos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrdenLimpieza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantaId")
                        .HasColumnType("int");

                    b.Property<string>("ResponsableDesvio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableroLibre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableroYSector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormID");

                    b.ToTable("TablerosElectricos");
                });

            modelBuilder.Entity("AuditApp.Models.Planta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Plantas");
                });

            modelBuilder.Entity("AuditApp.Models.UsuarioBase", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("UsuarioBase");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("AuditApp.Models.Auditor", b =>
                {
                    b.HasBaseType("AuditApp.Models.UsuarioBase");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Auditor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AuditApp.Models.UsuarioBase", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AuditApp.Models.UsuarioBase", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuditApp.Models.UsuarioBase", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AuditApp.Models.UsuarioBase", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
