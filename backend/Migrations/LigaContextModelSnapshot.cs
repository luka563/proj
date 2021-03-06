// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Models;

namespace backend.Migrations
{
    [DbContext(typeof(LigaContext))]
    partial class LigaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("backend.Models.Igrac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Dres")
                        .HasColumnType("int")
                        .HasColumnName("Dres");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ime");

                    b.Property<string>("Klub")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Klub");

                    b.Property<int?>("KlubrefID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KlubrefID");

                    b.ToTable("Igrac");
                });

            modelBuilder.Entity("backend.Models.Klub", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ime")
                        .HasColumnType("int")
                        .HasColumnName("Ime");

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int")
                        .HasColumnName("Kapacitet");

                    b.Property<int?>("LigaID")
                        .HasColumnType("int");

                    b.Property<int>("MaxKapacitet")
                        .HasColumnType("int")
                        .HasColumnName("MaxKapacitet");

                    b.Property<int>("X")
                        .HasColumnType("int")
                        .HasColumnName("X");

                    b.Property<int>("Y")
                        .HasColumnType("int")
                        .HasColumnName("Y");

                    b.HasKey("ID");

                    b.HasIndex("LigaID");

                    b.ToTable("Klub");
                });

            modelBuilder.Entity("backend.Models.Liga", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KapacitetKluba")
                        .HasColumnType("int")
                        .HasColumnName("KapacitetKluba");

                    b.Property<int>("M")
                        .HasColumnType("int")
                        .HasColumnName("M");

                    b.Property<int>("N")
                        .HasColumnType("int")
                        .HasColumnName("N");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Naziv");

                    b.HasKey("ID");

                    b.ToTable("Liga");
                });

            modelBuilder.Entity("backend.Models.Igrac", b =>
                {
                    b.HasOne("backend.Models.Klub", "Klubref")
                        .WithMany("Igraci")
                        .HasForeignKey("KlubrefID");

                    b.Navigation("Klubref");
                });

            modelBuilder.Entity("backend.Models.Klub", b =>
                {
                    b.HasOne("backend.Models.Liga", "Liga")
                        .WithMany("Klubovi")
                        .HasForeignKey("LigaID");

                    b.Navigation("Liga");
                });

            modelBuilder.Entity("backend.Models.Klub", b =>
                {
                    b.Navigation("Igraci");
                });

            modelBuilder.Entity("backend.Models.Liga", b =>
                {
                    b.Navigation("Klubovi");
                });
#pragma warning restore 612, 618
        }
    }
}
