﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using umbraco_course_submission.Context;

#nullable disable

namespace umbraco_course_submission.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("umbraco_course_submission.Entities.SubsEntity", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.HasKey("Email");

                    b.ToTable("Subs");
                });
#pragma warning restore 612, 618
        }
    }
}
