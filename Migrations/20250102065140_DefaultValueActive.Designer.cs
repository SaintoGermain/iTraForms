﻿// <auto-generated />
using System;
using FormsProyect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FormsProyect.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20250102065140_DefaultValueActive")]
    partial class DefaultValueActive
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FormsProyect.Models.Entities.AllowedUsers", b =>
                {
                    b.Property<int>("NoForm")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("NoForm", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("AllowedUsers", (string)null);
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.AnsweredQuestions", b =>
                {
                    b.Property<int>("IDQuest")
                        .HasColumnType("int");

                    b.Property<int>("NoFilledForm")
                        .HasColumnType("int");

                    b.Property<string>("QuestT1")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("QuestT2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("QuestT3")
                        .HasColumnType("int");

                    b.Property<bool?>("QuestT4")
                        .HasColumnType("bit");

                    b.HasKey("IDQuest", "NoFilledForm");

                    b.HasIndex("NoFilledForm");

                    b.ToTable("AnsweredQuestions", (string)null);
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Comments", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("NoForm")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentID");

                    b.HasIndex("NoForm");

                    b.HasIndex("UserId");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.FormFilled", b =>
                {
                    b.Property<int>("NoFilledForm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoFilledForm"));

                    b.Property<int>("NoForm")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("NoFilledForm");

                    b.HasIndex("NoForm");

                    b.HasIndex("UserId");

                    b.ToTable("FormFilled", (string)null);
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.FormTags", b =>
                {
                    b.Property<int>("NoForm")
                        .HasColumnType("int");

                    b.Property<int>("TagID")
                        .HasColumnType("int");

                    b.HasKey("NoForm", "TagID");

                    b.HasIndex("TagID");

                    b.ToTable("FormTags", (string)null);
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Forms", b =>
                {
                    b.Property<int>("NoForm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoForm"));

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TopicID")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("NoForm");

                    b.HasIndex("TopicID");

                    b.HasIndex("UserId");

                    b.ToTable("Forms", (string)null);
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Likes", b =>
                {
                    b.Property<int>("LikeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LikeID"));

                    b.Property<int>("NoForm")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LikeID");

                    b.HasIndex("NoForm");

                    b.HasIndex("UserId");

                    b.ToTable("Likes", (string)null);
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Questions", b =>
                {
                    b.Property<int>("IDQuest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDQuest"));

                    b.Property<string>("DescrQ")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NoForm")
                        .HasColumnType("int");

                    b.Property<string>("TitleQ")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("_Show")
                        .HasColumnType("bit");

                    b.Property<int>("_Type")
                        .HasColumnType("int");

                    b.HasKey("IDQuest");

                    b.HasIndex("NoForm");

                    b.ToTable("Questions", (string)null);
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Tags", b =>
                {
                    b.Property<int>("TagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagID"));

                    b.Property<string>("_TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagID");

                    b.ToTable("Tags", (string)null);
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Topics", b =>
                {
                    b.Property<int>("TopicID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TopicID"));

                    b.Property<string>("_TopicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicID");

                    b.ToTable("Topics", (string)null);
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.AllowedUsers", b =>
                {
                    b.HasOne("FormsProyect.Models.Entities.Forms", "Forms")
                        .WithMany("AllowedUsers")
                        .HasForeignKey("NoForm")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FormsProyect.Models.Entities.Users", "Users")
                        .WithMany("AllowedUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Forms");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.AnsweredQuestions", b =>
                {
                    b.HasOne("FormsProyect.Models.Entities.Questions", "Questions")
                        .WithMany("AnsweredQuestions")
                        .HasForeignKey("IDQuest")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FormsProyect.Models.Entities.FormFilled", "FormFilled")
                        .WithMany("AnsweredQuestions")
                        .HasForeignKey("NoFilledForm")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FormFilled");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Comments", b =>
                {
                    b.HasOne("FormsProyect.Models.Entities.Forms", "Forms")
                        .WithMany("Comments")
                        .HasForeignKey("NoForm")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FormsProyect.Models.Entities.Users", "Users")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Forms");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.FormFilled", b =>
                {
                    b.HasOne("FormsProyect.Models.Entities.Forms", "Forms")
                        .WithMany("FormFilled")
                        .HasForeignKey("NoForm")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FormsProyect.Models.Entities.Users", "Users")
                        .WithMany("FormFilled")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Forms");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.FormTags", b =>
                {
                    b.HasOne("FormsProyect.Models.Entities.Forms", "Forms")
                        .WithMany("FormTags")
                        .HasForeignKey("NoForm")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FormsProyect.Models.Entities.Tags", "Tags")
                        .WithMany("FormTags")
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Forms");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Forms", b =>
                {
                    b.HasOne("FormsProyect.Models.Entities.Topics", "Topics")
                        .WithMany("Forms")
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FormsProyect.Models.Entities.Users", "Users")
                        .WithMany("Forms")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Topics");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Likes", b =>
                {
                    b.HasOne("FormsProyect.Models.Entities.Forms", "Forms")
                        .WithMany("Likes")
                        .HasForeignKey("NoForm")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FormsProyect.Models.Entities.Users", "Users")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Forms");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Questions", b =>
                {
                    b.HasOne("FormsProyect.Models.Entities.Forms", "Forms")
                        .WithMany("Questions")
                        .HasForeignKey("NoForm")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Forms");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.FormFilled", b =>
                {
                    b.Navigation("AnsweredQuestions");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Forms", b =>
                {
                    b.Navigation("AllowedUsers");

                    b.Navigation("Comments");

                    b.Navigation("FormFilled");

                    b.Navigation("FormTags");

                    b.Navigation("Likes");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Questions", b =>
                {
                    b.Navigation("AnsweredQuestions");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Tags", b =>
                {
                    b.Navigation("FormTags");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Topics", b =>
                {
                    b.Navigation("Forms");
                });

            modelBuilder.Entity("FormsProyect.Models.Entities.Users", b =>
                {
                    b.Navigation("AllowedUsers");

                    b.Navigation("Comments");

                    b.Navigation("FormFilled");

                    b.Navigation("Forms");

                    b.Navigation("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}