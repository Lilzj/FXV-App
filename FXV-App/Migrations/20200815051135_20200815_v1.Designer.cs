// <auto-generated />
using System;
using FXV.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FXV_App.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200815051135_20200815_v1")]
    partial class _20200815_v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FXV.Models.Activity_Scheduled", b =>
                {
                    b.Property<int>("AS_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("AS_ID");

                    b.ToTable("Activity_Scheduled");
                });

            modelBuilder.Entity("FXV.Models.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("FXV.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address")
                        .IsConcurrencyToken();

                    b.Property<string>("City")
                        .IsConcurrencyToken();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DOB")
                        .IsConcurrencyToken();

                    b.Property<string>("Description")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsConcurrencyToken();

                    b.Property<string>("Gender")
                        .IsConcurrencyToken();

                    b.Property<string>("LastName")
                        .IsConcurrencyToken();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<int>("Nationality_ID");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<int>("P_ID");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Profile_Img_Path")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Salt_1");

                    b.Property<string>("Salt_2");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Nationality_ID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("P_ID");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FXV.Models.AthleteAchievement", b =>
                {
                    b.Property<int>("Achievement_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achievement")
                        .IsConcurrencyToken();

                    b.Property<int>("Id")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Achievement_ID");

                    b.HasIndex("Id");

                    b.ToTable("AthleteAchievement");
                });

            modelBuilder.Entity("FXV.Models.Combine", b =>
                {
                    b.Property<int>("C_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsConcurrencyToken();

                    b.Property<string>("Gender")
                        .IsConcurrencyToken();

                    b.Property<string>("Img_Path")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .IsConcurrencyToken()
                        .IsRequired();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("C_ID");

                    b.ToTable("Combine");
                });

            modelBuilder.Entity("FXV.Models.Combine_Builder", b =>
                {
                    b.Property<int>("CB_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Attempt")
                        .IsConcurrencyToken();

                    b.Property<int>("C_ID")
                        .IsConcurrencyToken();

                    b.Property<bool>("HasSplit")
                        .IsConcurrencyToken();

                    b.Property<bool>("IsWeighted")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Test_ID")
                        .IsConcurrencyToken();

                    b.HasKey("CB_ID");

                    b.HasIndex("C_ID");

                    b.HasIndex("Test_ID");

                    b.ToTable("Combine_Builder");
                });

            modelBuilder.Entity("FXV.Models.Combine_Categories_Weight", b =>
                {
                    b.Property<int>("CC_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("C_ID")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TC_ID")
                        .IsConcurrencyToken();

                    b.Property<double>("Weight")
                        .IsConcurrencyToken();

                    b.HasKey("CC_ID");

                    b.HasIndex("C_ID");

                    b.HasIndex("TC_ID");

                    b.ToTable("Combine_Categories_Weight");
                });

            modelBuilder.Entity("FXV.Models.Combine_Result", b =>
                {
                    b.Property<int>("CR_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("C_ID");

                    b.Property<string>("Dominant_Hand")
                        .IsConcurrencyToken();

                    b.Property<int>("E_ID")
                        .IsConcurrencyToken();

                    b.Property<double>("Handspan")
                        .IsConcurrencyToken();

                    b.Property<double>("Height")
                        .IsConcurrencyToken();

                    b.Property<int>("Id")
                        .IsConcurrencyToken();

                    b.Property<int>("Point")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<double>("Standing_Reach")
                        .IsConcurrencyToken();

                    b.Property<double>("Weight")
                        .IsConcurrencyToken();

                    b.Property<double>("Wingspan")
                        .IsConcurrencyToken();

                    b.HasKey("CR_ID");

                    b.HasIndex("C_ID");

                    b.HasIndex("E_ID");

                    b.HasIndex("Id");

                    b.ToTable("Combine_Result");
                });

            modelBuilder.Entity("FXV.Models.Event", b =>
                {
                    b.Property<int>("E_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date")
                        .IsConcurrencyToken();

                    b.Property<string>("Description")
                        .IsConcurrencyToken();

                    b.Property<int?>("Event_StatusES_ID");

                    b.Property<string>("Img_Path")
                        .IsConcurrencyToken();

                    b.Property<string>("Location")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("Time")
                        .IsConcurrencyToken();

                    b.HasKey("E_ID");

                    b.HasIndex("Event_StatusES_ID");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("FXV.Models.Event_Assigned_Attendee", b =>
                {
                    b.Property<int>("EA_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("E_ID")
                        .IsConcurrencyToken();

                    b.Property<int>("Id")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("EA_ID");

                    b.HasIndex("E_ID");

                    b.HasIndex("Id");

                    b.ToTable("Event_Assigned_Attendee");
                });

            modelBuilder.Entity("FXV.Models.Event_Builder", b =>
                {
                    b.Property<int>("EB_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("C_ID")
                        .IsConcurrencyToken();

                    b.Property<int>("E_ID")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("EB_ID");

                    b.HasIndex("C_ID");

                    b.HasIndex("E_ID");

                    b.ToTable("Event_Builder");
                });

            modelBuilder.Entity("FXV.Models.Event_Result", b =>
                {
                    b.Property<int>("ER_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("E_ID")
                        .IsConcurrencyToken();

                    b.Property<int>("Final_Point")
                        .IsConcurrencyToken();

                    b.Property<int>("Id")
                        .IsConcurrencyToken()
                        .HasColumnName("Id");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ER_ID");

                    b.HasIndex("E_ID");

                    b.HasIndex("Id");

                    b.ToTable("Event_Result");
                });

            modelBuilder.Entity("FXV.Models.Event_Status", b =>
                {
                    b.Property<int>("ES_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Status")
                        .IsConcurrencyToken();

                    b.HasKey("ES_ID");

                    b.ToTable("Event_Statuses");
                });

            modelBuilder.Entity("FXV.Models.Nationality", b =>
                {
                    b.Property<int>("Nationality_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryCode")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Nationality_ID");

                    b.ToTable("Nationality");
                });

            modelBuilder.Entity("FXV.Models.Organization", b =>
                {
                    b.Property<int>("Org_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsConcurrencyToken();

                    b.Property<int>("Id")
                        .IsConcurrencyToken();

                    b.Property<string>("Img_Path")
                        .IsConcurrencyToken();

                    b.Property<string>("Location")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .IsConcurrencyToken();

                    b.Property<int>("Num_Of_Teams")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Org_ID");

                    b.HasIndex("Id");

                    b.ToTable("Organization");
                });

            modelBuilder.Entity("FXV.Models.Organization_Relationship", b =>
                {
                    b.Property<int>("OR_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Id")
                        .IsConcurrencyToken()
                        .HasColumnName("Id");

                    b.Property<int>("Org_ID")
                        .IsConcurrencyToken();

                    b.Property<string>("Role")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("OR_ID");

                    b.HasIndex("Id");

                    b.HasIndex("Org_ID");

                    b.ToTable("Organization_Relationship");
                });

            modelBuilder.Entity("FXV.Models.Sport", b =>
                {
                    b.Property<int>("Sport_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Sport_Name")
                        .IsConcurrencyToken();

                    b.HasKey("Sport_ID");

                    b.ToTable("Sport");
                });

            modelBuilder.Entity("FXV.Models.SubscriptionPermission", b =>
                {
                    b.Property<int>("P_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Permission")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("P_ID");

                    b.ToTable("SubscriptionPermission");
                });

            modelBuilder.Entity("FXV.Models.Team", b =>
                {
                    b.Property<int>("Team_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsConcurrencyToken();

                    b.Property<int>("Id")
                        .IsConcurrencyToken()
                        .HasColumnName("Id");

                    b.Property<string>("Img_Path")
                        .IsConcurrencyToken();

                    b.Property<string>("Location")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .IsConcurrencyToken();

                    b.Property<int>("Num_Of_Members")
                        .IsConcurrencyToken();

                    b.Property<int>("Org_ID")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Sport_ID")
                        .IsConcurrencyToken();

                    b.HasKey("Team_ID");

                    b.HasIndex("Id");

                    b.HasIndex("Org_ID");

                    b.HasIndex("Sport_ID");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("FXV.Models.Team_Membership", b =>
                {
                    b.Property<int>("TM_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Id")
                        .IsConcurrencyToken()
                        .HasColumnName("Id");

                    b.Property<string>("Position")
                        .IsConcurrencyToken();

                    b.Property<string>("Role")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Team_ID")
                        .IsConcurrencyToken();

                    b.HasKey("TM_ID");

                    b.HasIndex("Id");

                    b.HasIndex("Team_ID");

                    b.ToTable("Team_Membership");
                });

            modelBuilder.Entity("FXV.Models.TempEventTable", b =>
                {
                    b.Property<int>("Tem_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Athlete_ID")
                        .IsConcurrencyToken();

                    b.Property<int>("Event_ID")
                        .IsConcurrencyToken();

                    b.Property<bool>("IsFinished")
                        .IsConcurrencyToken();

                    b.Property<int>("Test_ID")
                        .IsConcurrencyToken();

                    b.HasKey("Tem_ID");

                    b.ToTable("TempEventTable");
                });

            modelBuilder.Entity("FXV.Models.Test", b =>
                {
                    b.Property<int>("Test_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsConcurrencyToken();

                    b.Property<string>("Gender")
                        .IsConcurrencyToken();

                    b.Property<double>("HigherCalc")
                        .IsConcurrencyToken();

                    b.Property<double>("HigherResult")
                        .IsConcurrencyToken();

                    b.Property<int>("HigherScore")
                        .IsConcurrencyToken();

                    b.Property<bool>("IsVerified")
                        .IsConcurrencyToken();

                    b.Property<double>("LowerCalc")
                        .IsConcurrencyToken();

                    b.Property<double>("LowerResult")
                        .IsConcurrencyToken();

                    b.Property<int>("LowerScore")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .IsConcurrencyToken()
                        .IsRequired();

                    b.Property<bool>("Public")
                        .IsConcurrencyToken();

                    b.Property<bool>("Reverse")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TC_id")
                        .IsConcurrencyToken();

                    b.Property<string>("Unit")
                        .IsConcurrencyToken();

                    b.HasKey("Test_ID");

                    b.HasIndex("TC_id");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("FXV.Models.Test_Category", b =>
                {
                    b.Property<int>("TC_id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("TC_id");

                    b.ToTable("Test_Category");
                });

            modelBuilder.Entity("FXV.Models.Test_Org_Relationship", b =>
                {
                    b.Property<int>("TOR")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Org_ID")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Test_ID")
                        .IsConcurrencyToken();

                    b.HasKey("TOR");

                    b.HasIndex("Org_ID");

                    b.HasIndex("Test_ID");

                    b.ToTable("Test_Org_Relationship");
                });

            modelBuilder.Entity("FXV.Models.Test_Result", b =>
                {
                    b.Property<int>("TR_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date")
                        .IsConcurrencyToken();

                    b.Property<int>("E_ID")
                        .IsConcurrencyToken();

                    b.Property<int>("Id")
                        .IsConcurrencyToken();

                    b.Property<int>("Point")
                        .IsConcurrencyToken();

                    b.Property<double>("Result")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Test_ID")
                        .IsConcurrencyToken();

                    b.HasKey("TR_ID");

                    b.HasIndex("E_ID");

                    b.HasIndex("Id");

                    b.HasIndex("Test_ID");

                    b.ToTable("Test_Result");
                });

            modelBuilder.Entity("FXV.Models.Test_Team_Relationship", b =>
                {
                    b.Property<int>("TTR")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Team_ID")
                        .IsConcurrencyToken();

                    b.Property<int>("Test_ID")
                        .IsConcurrencyToken();

                    b.HasKey("TTR");

                    b.HasIndex("Team_ID");

                    b.HasIndex("Test_ID");

                    b.ToTable("Test_Team_Relationship");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FXV.Models.AppUser", b =>
                {
                    b.HasOne("FXV.Models.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("Nationality_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.SubscriptionPermission", "SubscriptionPermission")
                        .WithMany()
                        .HasForeignKey("P_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.AthleteAchievement", b =>
                {
                    b.HasOne("FXV.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Combine_Builder", b =>
                {
                    b.HasOne("FXV.Models.Combine", "Combine")
                        .WithMany()
                        .HasForeignKey("C_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.Test", "Test")
                        .WithMany()
                        .HasForeignKey("Test_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Combine_Categories_Weight", b =>
                {
                    b.HasOne("FXV.Models.Combine", "Combine")
                        .WithMany()
                        .HasForeignKey("C_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.Test_Category", "Test_Category")
                        .WithMany()
                        .HasForeignKey("TC_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Combine_Result", b =>
                {
                    b.HasOne("FXV.Models.Combine", "Combine")
                        .WithMany()
                        .HasForeignKey("C_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("E_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Event", b =>
                {
                    b.HasOne("FXV.Models.Event_Status", "Event_Status")
                        .WithMany()
                        .HasForeignKey("Event_StatusES_ID");
                });

            modelBuilder.Entity("FXV.Models.Event_Assigned_Attendee", b =>
                {
                    b.HasOne("FXV.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("E_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Event_Builder", b =>
                {
                    b.HasOne("FXV.Models.Combine", "Combine")
                        .WithMany()
                        .HasForeignKey("C_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("E_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Event_Result", b =>
                {
                    b.HasOne("FXV.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("E_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Organization", b =>
                {
                    b.HasOne("FXV.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Organization_Relationship", b =>
                {
                    b.HasOne("FXV.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("Org_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Team", b =>
                {
                    b.HasOne("FXV.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("Org_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("Sport_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Team_Membership", b =>
                {
                    b.HasOne("FXV.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("Team_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Test", b =>
                {
                    b.HasOne("FXV.Models.Test_Category", "Test_Category")
                        .WithMany()
                        .HasForeignKey("TC_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Test_Org_Relationship", b =>
                {
                    b.HasOne("FXV.Models.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("Org_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.Test", "Test")
                        .WithMany()
                        .HasForeignKey("Test_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Test_Result", b =>
                {
                    b.HasOne("FXV.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("E_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.Test", "Test")
                        .WithMany()
                        .HasForeignKey("Test_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FXV.Models.Test_Team_Relationship", b =>
                {
                    b.HasOne("FXV.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("Team_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.Test", "Test")
                        .WithMany()
                        .HasForeignKey("Test_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("FXV.Models.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("FXV.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("FXV.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("FXV.Models.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FXV.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("FXV.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
