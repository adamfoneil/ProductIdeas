﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using ProductIdeas.Data;

#nullable disable

namespace EmailLeadCapture.API.Migrations
{
	[DbContext(typeof(LeadCaptureDbContext))]
    [Migration("20240101200401_LeadFK")]
    partial class LeadFK
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EmailLeadCapture.Database.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.ToTable("application");
                });

            modelBuilder.Entity("EmailLeadCapture.Database.EmailLead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreatedUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("OptStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("OptStatusChangedUtc")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasAlternateKey("ApplicationId", "Email");

                    b.ToTable("email_lead");
                });

            modelBuilder.Entity("EmailLeadCapture.Database.EmailLead", b =>
                {
                    b.HasOne("EmailLeadCapture.Database.Application", null)
                        .WithMany("EmailLeads")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmailLeadCapture.Database.Application", b =>
                {
                    b.Navigation("EmailLeads");
                });
#pragma warning restore 612, 618
        }
    }
}
