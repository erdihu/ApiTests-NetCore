﻿// <auto-generated />
using ApiDotNetCore.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ApiDotNetCore.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20180221163748_AddModels")]
    partial class AddModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("ApiDotNetCore.Models.Pocos.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("End");

                    b.Property<string>("Name");

                    b.Property<int>("OrganizerUserId");

                    b.Property<DateTime>("Start");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ApiDotNetCore.Models.Pocos.EventAttendees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<string>("SelectedFood");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("EventAttendees");
                });

            modelBuilder.Entity("ApiDotNetCore.Models.Pocos.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventId");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("UserId");

                    b.HasIndex("EventId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApiDotNetCore.Models.Pocos.User", b =>
                {
                    b.HasOne("ApiDotNetCore.Models.Pocos.Event")
                        .WithMany("Attendees")
                        .HasForeignKey("EventId");
                });
#pragma warning restore 612, 618
        }
    }
}
