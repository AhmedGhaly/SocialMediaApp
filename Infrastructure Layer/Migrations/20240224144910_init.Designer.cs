﻿// <auto-generated />
using Infrastructure_Layer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure_Layer.Migrations
{
    [DbContext(typeof(SocialMediaContext))]
    [Migration("20240224144910_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain_Layer.Models.Address", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Domain_Layer.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("commenContentId")
                        .HasColumnType("int");

                    b.Property<int>("postId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("commenContentId");

                    b.HasIndex("postId");

                    b.HasIndex("userId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Domain_Layer.Models.CommentContent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("iamge")
                        .HasColumnType("smallint");

                    b.HasKey("id");

                    b.ToTable("CommentContents");
                });

            modelBuilder.Entity("Domain_Layer.Models.Like", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("commentId")
                        .HasColumnType("int");

                    b.Property<int>("name")
                        .HasColumnType("int");

                    b.Property<int>("postId")
                        .HasColumnType("int");

                    b.Property<int>("subCommentId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("commentId");

                    b.HasIndex("postId");

                    b.HasIndex("subCommentId");

                    b.HasIndex("userId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("Domain_Layer.Models.Post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("postContentId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("postContentId");

                    b.HasIndex("userId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Domain_Layer.Models.PostContnet", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("PostContnets");
                });

            modelBuilder.Entity("Domain_Layer.Models.SubComment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("commentContentId")
                        .HasColumnType("int");

                    b.Property<int>("commentId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("commentContentId");

                    b.HasIndex("commentId");

                    b.HasIndex("userId");

                    b.ToTable("SubComments");
                });

            modelBuilder.Entity("Domain_Layer.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("addressId")
                        .HasColumnType("int");

                    b.Property<string>("coverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("addressId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain_Layer.Models.Comment", b =>
                {
                    b.HasOne("Domain_Layer.Models.CommentContent", "CommentContent")
                        .WithMany()
                        .HasForeignKey("commenContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain_Layer.Models.Post", "Post")
                        .WithMany("comments")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain_Layer.Models.User", "User")
                        .WithMany("comments")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommentContent");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain_Layer.Models.Like", b =>
                {
                    b.HasOne("Domain_Layer.Models.Comment", "Comment")
                        .WithMany("likes")
                        .HasForeignKey("commentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain_Layer.Models.Post", "Post")
                        .WithMany("likes")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain_Layer.Models.SubComment", "SubComment")
                        .WithMany("likes")
                        .HasForeignKey("subCommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain_Layer.Models.User", "User")
                        .WithMany("likes")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("Post");

                    b.Navigation("SubComment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain_Layer.Models.Post", b =>
                {
                    b.HasOne("Domain_Layer.Models.PostContnet", "PostContnet")
                        .WithMany()
                        .HasForeignKey("postContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain_Layer.Models.User", "User")
                        .WithMany("posts")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PostContnet");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain_Layer.Models.SubComment", b =>
                {
                    b.HasOne("Domain_Layer.Models.CommentContent", "CommentContent")
                        .WithMany()
                        .HasForeignKey("commentContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain_Layer.Models.Comment", "Comment")
                        .WithMany("subComments")
                        .HasForeignKey("commentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain_Layer.Models.User", "User")
                        .WithMany("subComments")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("CommentContent");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain_Layer.Models.User", b =>
                {
                    b.HasOne("Domain_Layer.Models.Address", "address")
                        .WithMany()
                        .HasForeignKey("addressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("address");
                });

            modelBuilder.Entity("Domain_Layer.Models.Comment", b =>
                {
                    b.Navigation("likes");

                    b.Navigation("subComments");
                });

            modelBuilder.Entity("Domain_Layer.Models.Post", b =>
                {
                    b.Navigation("comments");

                    b.Navigation("likes");
                });

            modelBuilder.Entity("Domain_Layer.Models.SubComment", b =>
                {
                    b.Navigation("likes");
                });

            modelBuilder.Entity("Domain_Layer.Models.User", b =>
                {
                    b.Navigation("comments");

                    b.Navigation("likes");

                    b.Navigation("posts");

                    b.Navigation("subComments");
                });
#pragma warning restore 612, 618
        }
    }
}