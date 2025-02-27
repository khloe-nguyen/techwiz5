﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechWizWebApp.Data;

#nullable disable

namespace TechWizWebApp.Migrations
{
    [DbContext(typeof(DecorVistaDbContext))]
    partial class DecorVistaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechWizWebApp.Domain.Blog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("images")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("interior_designer_id")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("interior_designer_id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("quanity")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<int>("variant_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("product_id");

                    b.HasIndex("user_id");

                    b.HasIndex("variant_id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Consultation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("designer_id")
                        .HasColumnType("int");

                    b.Property<string>("notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("scheduled_datetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("designer_id");

                    b.HasIndex("user_id");

                    b.ToTable("Consultations");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Functionality", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Functionalities");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Gallery", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("color_tone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gallery_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("interior_designer_id")
                        .HasColumnType("int");

                    b.Property<int>("room_type_id")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("view_count")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("interior_designer_id");

                    b.HasIndex("room_type_id");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.GalleryDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("gallery_id")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("gallery_id");

                    b.HasIndex("product_id");

                    b.ToTable("GalleryDetails");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.InteriorDesigner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("approved_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("certificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("daywork")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("portfolio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<int>("yearsofexperience")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("InteriorDesigners");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Notification", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_read")
                        .HasColumnType("bit");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Order", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("total")
                        .HasColumnType("real");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.OrderDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("order_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("quanity")
                        .HasColumnType("int");

                    b.Property<bool>("review_status")
                        .HasColumnType("bit");

                    b.Property<int>("variant_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("order_id");

                    b.HasIndex("variant_id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("functionality_id")
                        .HasColumnType("int");

                    b.Property<string>("imageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("functionality_id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.ProductImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("imagename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Review", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("InteriorDesignerid")
                        .HasColumnType("int");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("create_at")
                        .HasColumnType("datetime2");

                    b.Property<int?>("id_booking")
                        .HasColumnType("int");

                    b.Property<int?>("product_id")
                        .HasColumnType("int");

                    b.Property<float?>("score")
                        .HasColumnType("real");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("InteriorDesignerid");

                    b.HasIndex("id_booking")
                        .IsUnique()
                        .HasFilter("[id_booking] IS NOT NULL");

                    b.HasIndex("product_id");

                    b.HasIndex("user_id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.RoomType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Story", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("interior_designer_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("interior_designer_id");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Subcribe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("gallery_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("gallery_id");

                    b.HasIndex("user_id");

                    b.ToTable("Subcribes");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.UserDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Variant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<int>("productid")
                        .HasColumnType("int");

                    b.Property<float>("saleprice")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("Variants");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.VariantAttribute", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("attributetype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("attributevalue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("priority")
                        .HasColumnType("int");

                    b.Property<int>("variantid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("variantid");

                    b.ToTable("VariantAttributes");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Blog", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.InteriorDesigner", "interior_designer")
                        .WithMany("blogs")
                        .HasForeignKey("interior_designer_id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("interior_designer");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Cart", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.Product", "product")
                        .WithMany("carts")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TechWizWebApp.Domain.User", "user")
                        .WithMany("carts")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TechWizWebApp.Domain.Variant", "variant")
                        .WithMany("carts")
                        .HasForeignKey("variant_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("user");

                    b.Navigation("variant");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Consultation", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.InteriorDesigner", "interior_designer")
                        .WithMany("consultations")
                        .HasForeignKey("designer_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TechWizWebApp.Domain.User", "user")
                        .WithMany("consultations")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("interior_designer");

                    b.Navigation("user");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Gallery", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.InteriorDesigner", "interior_designer")
                        .WithMany("galleries")
                        .HasForeignKey("interior_designer_id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("TechWizWebApp.Domain.RoomType", "room_type")
                        .WithMany("galleries")
                        .HasForeignKey("room_type_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("interior_designer");

                    b.Navigation("room_type");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.GalleryDetails", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.Gallery", "gallery")
                        .WithMany("galleryDetails")
                        .HasForeignKey("gallery_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechWizWebApp.Domain.Product", "product")
                        .WithMany("galleryDetails")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("gallery");

                    b.Navigation("product");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.InteriorDesigner", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.User", "user")
                        .WithOne("interiordesigner")
                        .HasForeignKey("TechWizWebApp.Domain.InteriorDesigner", "user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Notification", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.User", "user")
                        .WithMany("notifications")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Order", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.OrderDetails", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.Order", "order")
                        .WithMany("order_details")
                        .HasForeignKey("order_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TechWizWebApp.Domain.Variant", "variant")
                        .WithMany("order_details")
                        .HasForeignKey("variant_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("variant");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Product", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.Functionality", "functionality")
                        .WithMany("products")
                        .HasForeignKey("functionality_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("functionality");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.ProductImage", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.Product", "product")
                        .WithMany("images")
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Review", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.InteriorDesigner", null)
                        .WithMany("reviews")
                        .HasForeignKey("InteriorDesignerid");

                    b.HasOne("TechWizWebApp.Domain.Consultation", "Consultation")
                        .WithOne("review")
                        .HasForeignKey("TechWizWebApp.Domain.Review", "id_booking")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("TechWizWebApp.Domain.Product", "product")
                        .WithMany("reviews")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("TechWizWebApp.Domain.User", "user")
                        .WithMany("reviews")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Consultation");

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Story", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.InteriorDesigner", "interior_designer")
                        .WithMany("stories")
                        .HasForeignKey("interior_designer_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("interior_designer");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Subcribe", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.Gallery", "gallery")
                        .WithMany("subcribes")
                        .HasForeignKey("gallery_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TechWizWebApp.Domain.User", "user")
                        .WithMany("subcribes")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("gallery");

                    b.Navigation("user");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.UserDetails", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.User", "User")
                        .WithOne("userdetails")
                        .HasForeignKey("TechWizWebApp.Domain.UserDetails", "user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Variant", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.Product", "product")
                        .WithMany("variants")
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.VariantAttribute", b =>
                {
                    b.HasOne("TechWizWebApp.Domain.Variant", "variant")
                        .WithMany("variantattributes")
                        .HasForeignKey("variantid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("variant");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Consultation", b =>
                {
                    b.Navigation("review");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Functionality", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Gallery", b =>
                {
                    b.Navigation("galleryDetails");

                    b.Navigation("subcribes");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.InteriorDesigner", b =>
                {
                    b.Navigation("blogs");

                    b.Navigation("consultations");

                    b.Navigation("galleries");

                    b.Navigation("reviews");

                    b.Navigation("stories");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Order", b =>
                {
                    b.Navigation("order_details");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Product", b =>
                {
                    b.Navigation("carts");

                    b.Navigation("galleryDetails");

                    b.Navigation("images");

                    b.Navigation("reviews");

                    b.Navigation("variants");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.RoomType", b =>
                {
                    b.Navigation("galleries");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.User", b =>
                {
                    b.Navigation("carts");

                    b.Navigation("consultations");

                    b.Navigation("interiordesigner");

                    b.Navigation("notifications");

                    b.Navigation("orders");

                    b.Navigation("reviews");

                    b.Navigation("subcribes");

                    b.Navigation("userdetails");
                });

            modelBuilder.Entity("TechWizWebApp.Domain.Variant", b =>
                {
                    b.Navigation("carts");

                    b.Navigation("order_details");

                    b.Navigation("variantattributes");
                });
#pragma warning restore 612, 618
        }
    }
}
