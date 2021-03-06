﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using SchedulerWebApi.Models;
using System;

namespace SchedulerWebApi.Migrations.CourseAppointment
{
    [DbContext(typeof(CourseAppointmentContext))]
    [Migration("20180523024426_CreateCourseAppointmentModel")]
    partial class CreateCourseAppointmentModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("SchedulerWebApi.Models.CourseAppointment", b =>
                {
                    b.Property<int>("CourseId");

                    b.Property<int>("AppointmentId");

                    b.HasKey("CourseId", "AppointmentId");

                    b.ToTable("CourseAppointments");
                });
#pragma warning restore 612, 618
        }
    }
}
