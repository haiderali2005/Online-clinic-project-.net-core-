﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using clinic.Models;

#nullable disable

namespace clinic.Migrations
{
    [DbContext(typeof(mycontext))]
    partial class mycontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("clinic.Models.admin", b =>
                {
                    b.Property<int>("admin_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("admin_id"), 1L, 1);

                    b.Property<string>("admin_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("admin_id");

                    b.ToTable("tbl_admin");
                });

            modelBuilder.Entity("clinic.Models.bussinesstransaction", b =>
                {
                    b.Property<int>("bussiness_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bussiness_id"), 1L, 1);

                    b.Property<string>("Amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("bussiness_id");

                    b.ToTable("tbl_bussinesstransaction");
                });

            modelBuilder.Entity("clinic.Models.cart", b =>
                {
                    b.Property<int>("cart_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cart_id"), 1L, 1);

                    b.Property<int?>("cart_bill")
                        .HasColumnType("int");

                    b.Property<string>("cart_img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cart_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("cart_price")
                        .HasColumnType("int");

                    b.Property<int>("cart_qty")
                        .HasColumnType("int");

                    b.HasKey("cart_id");

                    b.ToTable("tbl_cart");
                });

            modelBuilder.Entity("clinic.Models.client", b =>
                {
                    b.Property<int>("client_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("client_id"), 1L, 1);

                    b.Property<string>("client_city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_eventdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_eventname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("client_id");

                    b.ToTable("tbl_client");
                });

            modelBuilder.Entity("clinic.Models.clinicgallery", b =>
                {
                    b.Property<int>("gallery_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("gallery_id"), 1L, 1);

                    b.Property<string>("gallery_img")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("gallery_id");

                    b.ToTable("tbl_gallery");
                });

            modelBuilder.Entity("clinic.Models.contact", b =>
                {
                    b.Property<int>("contact_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("contact_id"), 1L, 1);

                    b.Property<string>("contact_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contact_id");

                    b.ToTable("tbl_contact");
                });

            modelBuilder.Entity("clinic.Models.educationevents", b =>
                {
                    b.Property<int>("event_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("event_id"), 1L, 1);

                    b.Property<string>("event_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("event_doctorimg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("event_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("event_location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("event_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("event_teacher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("event_time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("event_id");

                    b.ToTable("tbl_educationevents");
                });

            modelBuilder.Entity("clinic.Models.feedback", b =>
                {
                    b.Property<int>("feedback_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("feedback_id"), 1L, 1);

                    b.Property<string>("feedback_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("feedback_message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("feedback_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("feedback_id");

                    b.ToTable("tbl_feedback");
                });

            modelBuilder.Entity("clinic.Models.medicinecategory", b =>
                {
                    b.Property<int>("medicinecat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("medicinecat_id"), 1L, 1);

                    b.Property<string>("medicinecat_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicinecat_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("medicinecat_id");

                    b.ToTable("tbl_medicinecateogry");
                });

            modelBuilder.Entity("clinic.Models.medicines", b =>
                {
                    b.Property<int>("med_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("med_id"), 1L, 1);

                    b.Property<string>("med_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("med_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("med_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("med_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("med_price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("med_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("medicinecat_id")
                        .HasColumnType("int");

                    b.HasKey("med_id");

                    b.HasIndex("medicinecat_id");

                    b.ToTable("tbl_medicines");
                });

            modelBuilder.Entity("clinic.Models.scientifictools", b =>
                {
                    b.Property<int>("sci_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sci_id"), 1L, 1);

                    b.Property<string>("sci_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sci_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sci_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sci_price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sci_id");

                    b.ToTable("tbl_scitools");
                });

            modelBuilder.Entity("clinic.Models.scitwo", b =>
                {
                    b.Property<int>("two_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("two_id"), 1L, 1);

                    b.Property<string>("two_des")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("two_img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("two_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("two_price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("two_id");

                    b.ToTable("tbl_scitwo");
                });

            modelBuilder.Entity("clinic.Models.teachers", b =>
                {
                    b.Property<int>("teacher_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("teacher_id"), 1L, 1);

                    b.Property<string>("teacher_img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teacher_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("teacher_id");

                    b.ToTable("tbl_teacher");
                });

            modelBuilder.Entity("clinic.Models.medicines", b =>
                {
                    b.HasOne("clinic.Models.medicinecategory", "medicinecat")
                        .WithMany("medicines")
                        .HasForeignKey("medicinecat_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("medicinecat");
                });

            modelBuilder.Entity("clinic.Models.medicinecategory", b =>
                {
                    b.Navigation("medicines");
                });
#pragma warning restore 612, 618
        }
    }
}
