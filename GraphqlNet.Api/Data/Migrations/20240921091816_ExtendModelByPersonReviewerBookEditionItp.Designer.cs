﻿// <auto-generated />
using System;
using GraphQLDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphqlNet.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240921091816_ExtendModelByPersonReviewerBookEditionItp")]
    partial class ExtendModelByPersonReviewerBookEditionItp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("GraphqlNet.Api.Models.Author", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PersonID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("PersonID")
                        .IsUnique();

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.Book", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BookReviewId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Genre")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.BookEdition", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BookID")
                        .HasColumnType("TEXT");

                    b.Property<int>("EditionNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Format")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PublisherID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("PublisherID");

                    b.ToTable("BookEditions");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.BookReview", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BookID")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ReviewerID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("BookID")
                        .IsUnique();

                    b.HasIndex("ReviewerID");

                    b.ToTable("BookReviews");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.Person", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.PublishingHouse", b =>
                {
                    b.Property<Guid>("PublishingHouseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PublishingHouseID");

                    b.ToTable("PublishingHouses");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.Reviewer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PersonID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("PersonID")
                        .IsUnique();

                    b.ToTable("Reviewers");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.Author", b =>
                {
                    b.HasOne("GraphqlNet.Api.Models.Person", "Person")
                        .WithOne("Author")
                        .HasForeignKey("GraphqlNet.Api.Models.Author", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.Book", b =>
                {
                    b.HasOne("GraphqlNet.Api.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.BookEdition", b =>
                {
                    b.HasOne("GraphqlNet.Api.Models.Book", "Book")
                        .WithMany("BookEditions")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraphqlNet.Api.Models.PublishingHouse", "Publisher")
                        .WithMany("BookEditions")
                        .HasForeignKey("PublisherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.BookReview", b =>
                {
                    b.HasOne("GraphqlNet.Api.Models.Book", "Book")
                        .WithOne("BookReview")
                        .HasForeignKey("GraphqlNet.Api.Models.BookReview", "BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraphqlNet.Api.Models.Reviewer", "Reviewer")
                        .WithMany("BookReviews")
                        .HasForeignKey("ReviewerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.Reviewer", b =>
                {
                    b.HasOne("GraphqlNet.Api.Models.Person", "Person")
                        .WithOne("Reviewer")
                        .HasForeignKey("GraphqlNet.Api.Models.Reviewer", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.Book", b =>
                {
                    b.Navigation("BookEditions");

                    b.Navigation("BookReview");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.Person", b =>
                {
                    b.Navigation("Author");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.PublishingHouse", b =>
                {
                    b.Navigation("BookEditions");
                });

            modelBuilder.Entity("GraphqlNet.Api.Models.Reviewer", b =>
                {
                    b.Navigation("BookReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
