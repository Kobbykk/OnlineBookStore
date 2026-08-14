using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "Romance" },
                    { 3, 3, "History" },
                    { 4, 4, "SciFi" },
                    { 5, 5, "Computer Programming" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Amazon City", "Amazon", "897-516-7895", "1244", "CA", "Online" },
                    { 2, "Tech City", "Tech Solution", "727-916-8713", "5484", "IL", "124 Tech Street" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Mark Reed", 1, "C# & C++: 5 Books in 1 aims to make it simple for you to begin your journey, regardless of your skills or expertise. With step-by-step instructions, this guide will have you writing code in 2 programming languages, in no time.\r\n\r\n1. You will discover a gradual, beginner-friendly progress and learn the basics of C# and C++ in no time.\r\n\r\n2. You will study theory and how to put it into practice RIGHT NOW.\r\n\r\n3. You will not only find a boring instruction manual but also a dynamic and interactive guide that offers solid PRACTICAL experience.\r\n\r\n4. All the ESSENTIAL TOOLS and best strategies to learn coding for complete beginners + advanced knowledge for those with more experience.\r\n\r\n5. You will learn the RIGHT SKILLS for REAL APPLICATIONS with easy-to-understand exercises and examples.\r\n", "979-8390090077", 30.0, 25.0, 30.0, 20.0, "C# & C++" },
                    { 2, "Philip Robbins", 2, "An overview of Python, its history, and its key uses to demonstrate its potential and how understanding it may help you.\r\n    How to install Python and pick the best distribution on Windows or Mac, including the best IDE, to get started.\r\n    Object-Oriented Programming (OOP) and why you must know it, including objects, methods, and inheritance, taught logically and progressively to enable you utilize this user-friendly language and its basic syntax rapidly.\r\n    Chapters include actual codes and activities to test your abilities.\r\n    The greatest Python programming strategies to optimize script performance, including a whole section\r\n    For a 360-degree perspective of complex programming and easy entry, use Github, pip, Virtual Environment, and Unit Testing.\r\n    The exercise solutions (but only after you've tried them yourself)\r\n    Scan the QR code within the book for a bonus Python Interview Questions and Answers.lot more!", "979-8376161821", 33.0, 15.0, 30.0, 10.0, "Python Programming" },
                    { 3, "Chris Minnick", 3, "JavaScript in One For Dummies saves shelf space by providing a full introduction to JavaScript and its real-world applications. This book covers JavaScript foundations before covering libraries, frameworks, and runtime environments for beginners and experts. Anyone can learn JavaScript basics, even if they've never coded. Then discuss React.js, Vue.js, Svelte, and Node.js, today's top frameworks. Get comfy and learn JavaScript!", "978-1119906834", 10.0, 1.0, 10.0, 7.0, "JavaScript All-in-One For Dummies 1st Edition" },
                    { 4, "Neuronwaves", 2, "In this fast-paced environment, we must develop crucial skills for success. In an age of fake news, social media, and information overload, critical thinking, reasoning, and problem-solving are essential.\r\nIn our daily lives, critical thinking, logic, and problem-solving help us think clearly and make good judgments. These talents help us understand why things are the way they are, the forces and circumstances at play, and how to change them.", " 979-8866530397 ", 28.0, 20.0, 20.0, 15.0, "Critical Thinking, Logic & Problem Solving" },
                    { 5, "Casey Hardman", 4, "This guide teaches novices in game creation and programming the basics of Unity, C#, and object-oriented programming. New ideas are explained and shown.\r\nFrom an introduction to Unity, you'll learn about scenes, GameObjects, prefabs, components, and engine windows. After examining syntax rules, formatting, methods, variables, objects and types, classes, and inheritance, you'll write and test code. The book later covers Unity's serialization system and Inspector script data exposure. ", " 978-1484256558", 59.0, 40.0, 20.0, 30.0, "Game Programming with Unity and C#: A Complete Beginner’s Guide" },
                    { 6, "Walter Shields", 3, "Any database administration specialist would tell you that SQL is the most popular and trustworthy data management language, with no indications of slowing. Walter Shields, a mentor and SQL specialist, simplifies relational database management in this thorough tutorial.\r\n\r\nSQL QuickStart Guide is perfect for people wishing to further their careers, developers looking to improve their skills, or anybody who wants to participate in our data-driven future—even without coding expertise!", " 978-1945051234", 25.0, 23.0, 20.0, 22.0, "SQL QuickStart Guide" },
                    { 7, "Stanley  Lippman", 5, "C++ Primer, Fifth Edition, introduces the C++ standard library from the outset, drawing on its common functions and facilities to help you write useful programs without first having to master every language detail. The book’s many examples have been revised to use the new language features and demonstrate how to make the best use of them. This book is a proven tutorial for those new to C++, an authoritative discussion of core C++ concepts and techniques, and a valuable resource for experienced programmers, especially those eager to see C++11 enhancements illuminated.", "978-0321714114", 34.990000000000002, 23.0, 20.0, 22.0, "C++ Primer" },
                    { 8, "Jon Duckett", 5, "Creates HTML and CSS accessible for amateurs, students, and professionals, using full-color content.\r\n    Uses infographics and lifestyle photos to simplify and engage.\r\n    Has a unique format that lets you read chapters from start to finish or delve into areas of interest.\r\n\r\nThis instructional book is fun to read and refer to. It will make you wish other technical topics were that easy, appealing, and fascinating!", "978-1118008188", 7.8700000000000001, 6.0, 2.0, 4.0, "HTML and CSS: Design and Build Websites" },
                    { 9, "Dr. Charles Russell", 5, "Python for Everybody teaches programming and software development through data exploration. Python solves data challenges that spreadsheets can't.\r\n\r\n\r\n\r\nPython, a free programming language for Macintosh, Windows, and Linux, is simple and quick to learn. Once you understand Python, you can use it throughout your career without buying software.", "978-1530051120", 12.18, 5.0, 1.0, 2.0, "Python for Everybody: Exploring Data in Python 3" },
                    { 10, "Thomas H. Cormen", 5, "Algorithm books might be rigorous yet incomplete or superficial but comprehensive. Introduction to Algorithms is uncommonly rigorous and detailed. It covers a wide range of algorithms in depth yet makes their construction and analysis easy for all readers with self-contained chapters and pseudocode algorithms. Introduction to Algorithms has been the top algorithms text in colleges and the standard reference for professionals since its initial edition. Updated throughout, this fourth edition.", "978-0262046305", 93.579999999999998, 80.0, 50.0, 65.0, "Introduction to Algorithms, fourth edition 4th Edition" },
                    { 11, "Joshua Bloch", 5, "The last version of Effective Java was published immediately after Java 6. Java has evolved substantially. This Jolt award-winning classic has been fully updated to use the newest language and library capabilities. Modern Java supports numerous paradigms, necessitating best practices guidance, which this book provides.\r\n\r\n\r\nAgain, each chapter of Effective Java, Third Edition has multiple “items,” each a brief, stand-alone article that offers guidance, Java platform insights, and updated code examples. What to do, what not to do, and why are explained in detail for each item.", "978-0134685991", 38.079999999999998, 25.0, 10.0, 20.0, "Effective Java 3rd Edition" },
                    { 12, "Ben Forta", 5, "SQL skills are essential for application developers, database administrators, online application designers, mobile app developers, and Microsoft Office users. Sams Teach Yourself SQL in 10 Minutes provides simple, practical solutions to help you accomplish your job.\r\n\r\nBen Forta, a famous trainer and author, starts with simple data retrieval and soon moves on to joins, subqueries, stored procedures, cursors, triggers, and table constraints. \r\n", "978-0135182796", 20.0, 18.0, 9.0, 15.0, "SQL in 10 Minutes a Day, Sams Teach Yourself 5th Edition" },
                    { 13, "Jon Duckett", 5, "In JavaScript & jQuery, famous author Jon Duckett breaks the programming book mold and makes coding more engaging. His full-color books with educational visuals and images have won over readers by explaining programming in a way that's easy for beginners and useful for experts.\r\n\r\nDuckett combines JavaScript and jQuery in one book to help you write functioning programs rapidly. But the book doesn't presume you know JavaScript or jQuery. Duckett uses popular jQuery plugins to demonstrate concepts that would take pages of comprehensive explanation if you were asked to design them. This robust and elegant hardback version will be a desk reference for years.", "978-1118531648", 45.0, 30.0, 15.0, 20.0, "JavaScript and jQuery: Interactive Front-End Web Development 1st Edition" },
                    { 14, "Wouter de Bot", 5, "\"ChatGPT: Transforming Your Life One Conversation at a Time\" is your complete guide to using AI for personal and professional advancement. This AI Empowerment Series book is a toolset for forward-thinking people eager to prosper in an AI-driven future.\r\nDon't miss \"AI Wealth Revolution: Unlocking the Earning Secrets\"—the second AI Empowerment Series book. Discover how AI can alter wealth production.\r\nStart your life-changing adventure with \"ChatGPT: Transforming Your Life One Conversation at a Time\". Get your copy today to improve your future.", "978-1118531648", 12.0, 10.0, 2.0, 6.0, "ChatGPT" },
                    { 15, "Vivek Shetty", 5, "* Hardcore .NET solutions for advanced, distributed financial applications.\r\n\r\n* Fascinating insight into operation of Equity markets and the challenges this poses for technology solutions – you do not have to be an equity market insider to use this book.\r\n\r\n* Examines next generation trading challenges, and potential solutions using .NET 2.0 and emerging technology, such as Avalon, Indigo and Longhorn. ", "978-1118531648", 79.989999999999995, 50.0, 32.0, 41.0, "Practical .NET for Financial Markets (Expert's Voice in .NET) 1st ed. Edition" },
                    { 16, "Titus Winter & Tom Manshreck & Hyrum Wirght", 5, "Software developers nowadays must know how to program well and build good engineering practices to keep their codebase healthy. This book focuses what distinguishes programming from software engineering.\r\nHow can software developers manage a live codebase that adapts to new needs? Software engineers Titus Winters and Hyrum Wright, along with technical writer Tom Manshreck, offer an honest and enlightening look at how some of the world's top software engineers build and maintain software based on their Google experience. Google's engineering culture, procedures, and tools and how they improve engineering organizations are covered in this book.", "979-8861298315 ", 21.0, 18.0, 9.0, 15.0, "Software Engineering at Google" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
