using Bulky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers {get; set;}
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Romance", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Id = 4, Name = "SciFi", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Computer Programming", DisplayOrder = 5}

                );

            modelBuilder.Entity<Company>().HasData(
               new Company 
               { 
                   Id = 1, 
                   Name = "Amazon", 
                   StreetAddress = "Online", 
                   City = "Amazon City", 
                   State = "CA", 
                   PostalCode="1244", 
                   PhoneNumber="897-516-7895" },
               new Company 
               { 
                   Id = 2, 
                   Name = "Tech Solution", 
                   StreetAddress = "124 Tech Street", 
                   City = "Tech City", 
                   State = "IL", 
                   PostalCode = "5484", 
                   PhoneNumber = "727-916-8713" 
               }
   

               );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "C# & C++",
                    Author = "Mark Reed",
                    Description = "C# & C++: 5 Books in 1 aims to make it simple for you to begin your journey, " +
                    "regardless of your skills or expertise. With step-by-step instructions, this guide will have you " +
                    "writing code in 2 programming languages, in no time.\r\n\r\n1. You will discover a gradual, " +
                    "beginner-friendly progress and learn the basics of C# and C++ in no time.\r\n\r\n2. You will study " +
                    "theory and how to put it into practice RIGHT NOW.\r\n\r\n3. You will not only find a boring instruction manual" +
                    " but also a dynamic and interactive guide that offers solid PRACTICAL experience.\r\n\r\n4. All the " +
                    "ESSENTIAL TOOLS and best strategies to learn coding for complete beginners + advanced knowledge for " +
                    "those with more experience.\r\n\r\n5. You will learn the RIGHT SKILLS for REAL APPLICATIONS with " +
                    "easy-to-understand exercises and examples.\r\n",
                    ISBN = "979-8390090077",
                    ListPrice = 30,
                    Price = 25,
                    Price50 = 20,
                    Price100 = 30,
                    CategoryId = 1,
                   
                },
                new Product
                {
                    Id = 2,
                    Title = "Python Programming",
                    Author = "Philip Robbins",
                    Description = "An overview of Python, its history, and its key uses to demonstrate its potential and" +
                    " how understanding it may help you.\r\n    How to install Python and pick the best distribution on " +
                    "Windows or Mac, including the best IDE, to get started.\r\n    Object-Oriented Programming (OOP) and " +
                    "why you must know it, including objects, methods, and inheritance, taught logically and progressively" +
                    " to enable you utilize this user-friendly language and its basic syntax rapidly.\r\n    Chapters include actual " +
                    "codes and activities to test your abilities.\r\n    The greatest Python programming strategies to optimize script " +
                    "performance, including a whole section\r\n    For a 360-degree perspective of complex programming and easy entry, use " +
                    "Github, pip, Virtual Environment, and Unit Testing.\r\n    The exercise solutions (but only after you've tried them yourself)\r\n   " +
                    " Scan the QR code within the book for a bonus Python Interview Questions and Answers.lot more!",
                    ISBN = "979-8376161821",
                    ListPrice = 33,
                    Price = 15,
                    Price50 = 10,
                    Price100 = 30,
                    CategoryId = 2,
                   
                },
                new Product
                {
                    Id = 3,
                    Title = "JavaScript All-in-One For Dummies 1st Edition",
                    Author = "Chris Minnick",
                    Description = "JavaScript in One For Dummies saves shelf space by providing a full introduction to " +
                    "JavaScript and its real-world applications. This book covers JavaScript foundations before covering" +
                    " libraries, frameworks, and runtime environments for beginners and experts. Anyone can learn " +
                    "JavaScript basics, even if they've never coded. Then discuss React.js, Vue.js, Svelte, and Node.js, " +
                    "today's top frameworks. Get comfy and learn JavaScript!",
                    ISBN = "978-1119906834",
                    ListPrice = 10,
                    Price = 1,
                    Price50 = 7,
                    Price100 = 10,
                    CategoryId = 3,
                   
                },
                new Product
                {
                    Id = 4,
                    Title = "Critical Thinking, Logic & Problem Solving",
                    Author = "Neuronwaves",
                    Description = "In this fast-paced environment, we must develop crucial skills for success. In an age of fake news," +
                    " social media, and information overload, critical thinking, reasoning, and problem-solving are essential." +
                    "\r\nIn our daily lives, critical thinking, logic, and problem-solving help us think clearly and make good " +
                    "judgments. These talents help us understand why things are the way they are, the forces and circumstances at play," +
                    " and how to change them.",
                    ISBN = " 979-8866530397 ",
                    ListPrice = 28,
                    Price = 20,
                    Price50 = 15,
                    Price100 = 20,
                    CategoryId = 2,
                   
                },
                new Product
                {
                    Id = 5,
                    Title = "Game Programming with Unity and C#: A Complete Beginner’s Guide",
                    Author = "Casey Hardman",
                    Description = "This guide teaches novices in game creation and programming the basics of Unity, C#, " +
                    "and object-oriented programming. New ideas are explained and shown.\r\nFrom an introduction to Unity," +
                    " you'll learn about scenes, GameObjects, prefabs, components, and engine windows. After examining syntax rules," +
                    " formatting, methods, variables, objects and types, classes, and inheritance, you'll write and test" +
                    " code. The book later covers Unity's serialization system and Inspector script data exposure. ",
                    ISBN = " 978-1484256558",
                    ListPrice = 59,
                    Price = 40,
                    Price50 = 30,
                    Price100 = 20,
                    CategoryId = 4,
                   
                },
                new Product
                {
                    Id = 6,
                    Title = "SQL QuickStart Guide",
                    Author = "Walter Shields",
                    Description = "Any database administration specialist would tell you that SQL is the most popular and trustworthy " +
                    "data management language, with no indications of slowing. Walter Shields, a mentor and SQL specialist, simplifies " +
                    "relational database management in this thorough tutorial.\r\n\r\nSQL QuickStart Guide is perfect for people wishing " +
                    "to further their careers, developers looking to improve their skills, or anybody who wants to participate in our " +
                    "data-driven future—even without coding expertise!",
                    ISBN = " 978-1945051234",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 3,
                   
                },
                new Product
                {
                    Id = 7,
                    Title = "C++ Primer",
                    Author = "Stanley  Lippman",
                    Description = "C++ Primer, Fifth Edition, introduces the C++ standard library from the outset, " +
                    "drawing on its common functions and facilities to help you write useful programs without first " +
                    "having to master every language detail. The book’s many examples have been revised to use the " +
                    "new language features and demonstrate how to make the best use of them. This book is a proven " +
                    "tutorial for those new to C++, an authoritative discussion of core C++ concepts and techniques, " +
                    "and a valuable resource for experienced programmers, especially those eager to see C++11 enhancements illuminated.",
                    ISBN = "978-0321714114",
                    ListPrice = 34.99,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 5,
                    
                },
                new Product
                {
                    Id = 8,
                    Title = "HTML and CSS: Design and Build Websites",
                    Author = "Jon Duckett",
                    Description = "Creates HTML and CSS accessible for amateurs, students, and professionals, using " +
                    "full-color content.\r\n    Uses infographics and lifestyle photos to simplify and engage.\r\n    " +
                    "Has a unique format that lets you read chapters from start to finish or delve into areas of " +
                    "interest.\r\n\r\nThis instructional book is fun to read and refer to. It will make you wish other " +
                    "technical topics were that easy, appealing, and fascinating!",
                    ISBN = "978-1118008188",
                    ListPrice = 7.87,
                    Price = 6,
                    Price50 = 4,
                    Price100 = 2,
                    CategoryId = 5,
                   
                },
                 new Product
                 {
                     Id = 9,
                     Title = "Python for Everybody: Exploring Data in Python 3",
                     Author = "Dr. Charles Russell",
                     Description = "Python for Everybody teaches programming and software development through data " +
                     "exploration. Python solves data challenges that spreadsheets can't.\r\n\r\n\r\n\r\nPython, a free " +
                     "programming language for Macintosh, Windows, and Linux, is simple and quick to learn. Once you " +
                     "understand Python, you can use it throughout your career without buying software.",
                     ISBN = "978-1530051120",
                     ListPrice = 12.18,
                     Price = 5,
                     Price50 = 2,
                     Price100 = 1,
                     CategoryId = 5,
                   
                 },
                 new Product
                 {
                     Id = 10,
                     Title = "Introduction to Algorithms, fourth edition 4th Edition",
                     Author = "Thomas H. Cormen",
                     Description = "Algorithm books might be rigorous yet incomplete or superficial but comprehensive. " +
                     "Introduction to Algorithms is uncommonly rigorous and detailed. It covers a wide range of " +
                     "algorithms in depth yet makes their construction and analysis easy for all readers with " +
                     "self-contained chapters and pseudocode algorithms. Introduction to Algorithms has been the top " +
                     "algorithms text in colleges and the standard reference for professionals since its initial edition. " +
                     "Updated throughout, this fourth edition.",
                     ISBN = "978-0262046305",
                     ListPrice = 93.58,
                     Price = 80,
                     Price50 = 65,
                     Price100 = 50,
                     CategoryId = 5,
                     
                 },
                 new Product
                 {
                     Id = 11,
                     Title = "Effective Java 3rd Edition",
                     Author = "Joshua Bloch",
                     Description = "The last version of Effective Java was published immediately after Java 6. Java has " +
                     "evolved substantially. This Jolt award-winning classic has been fully updated to use the newest " +
                     "language and library capabilities. Modern Java supports numerous paradigms, necessitating best " +
                     "practices guidance, which this book provides.\r\n\r\n\r\nAgain, each chapter of Effective Java, " +
                     "Third Edition has multiple “items,” each a brief, stand-alone article that offers guidance, Java " +
                     "platform insights, and updated code examples. What to do, what not to do, and why are explained in " +
                     "detail for each item.",
                     ISBN = "978-0134685991",
                     ListPrice = 38.08,
                     Price = 25,
                     Price50 = 20,
                     Price100 = 10,
                     CategoryId = 5,
                     
                 },
                 new Product
                 {
                     Id = 12,
                     Title = "SQL in 10 Minutes a Day, Sams Teach Yourself 5th Edition",
                     Author = "Ben Forta",
                     Description = "SQL skills are essential for application developers, database administrators, " +
                     "online application designers, mobile app developers, and Microsoft Office users. Sams Teach " +
                     "Yourself SQL in 10 Minutes provides simple, practical solutions to help you accomplish your job." +
                     "\r\n\r\nBen Forta, a famous trainer and author, starts with simple data retrieval and soon moves on" +
                     " to joins, subqueries, stored procedures, cursors, triggers, and table constraints. \r\n",
                     ISBN = "978-0135182796",
                     ListPrice = 20,
                     Price = 18,
                     Price50 = 15,
                     Price100 = 9,
                     CategoryId = 5,
                    
                 },
                 new Product
                 {
                     Id = 13,
                     Title = "JavaScript and jQuery: Interactive Front-End Web Development 1st Edition",
                     Author = "Jon Duckett",
                     Description = "In JavaScript & jQuery, famous author Jon Duckett breaks the programming book mold " +
                     "and makes coding more engaging. His full-color books with educational visuals and images have won " +
                     "over readers by explaining programming in a way that's easy for beginners and useful for experts." +
                     "\r\n\r\nDuckett combines JavaScript and jQuery in one book to help you write functioning programs " +
                     "rapidly. But the book doesn't presume you know JavaScript or jQuery. Duckett uses popular jQuery " +
                     "plugins to demonstrate concepts that would take pages of comprehensive explanation if you were " +
                     "asked to design them. This robust and elegant hardback version will be a desk reference for years.",
                     ISBN = "978-1118531648",
                     ListPrice = 45,
                     Price = 30,
                     Price50 = 20,
                     Price100 = 15,
                     CategoryId = 5,
                    
                 },
                 new Product
                 {
                     Id = 14,
                     Title = "ChatGPT",
                     Author = "Wouter de Bot",
                     Description = "\"ChatGPT: Transforming Your Life One Conversation at a Time\" is your complete guide " +
                     "to using AI for personal and professional advancement. This AI Empowerment Series book is a toolset " +
                     "for forward-thinking people eager to prosper in an AI-driven future.\r\nDon't miss \"AI Wealth Revolution: " +
                     "Unlocking the Earning Secrets\"—the second AI Empowerment Series book. Discover how AI can alter wealth production.\r\nStart " +
                     "your life-changing adventure with \"ChatGPT: Transforming Your Life One Conversation at a Time\"." +
                     " Get your copy today to improve your future.",
                     ISBN = "978-1118531648",
                     ListPrice = 12,
                     Price = 10,
                     Price50 = 6,
                     Price100 = 2,
                     CategoryId = 5,
                    
                 },
                 new Product
                 {
                     Id = 15,
                     Title = "Practical .NET for Financial Markets (Expert's Voice in .NET) 1st ed. Edition",
                     Author = "Vivek Shetty",
                     Description = "* Hardcore .NET solutions for advanced, distributed financial applications.\r\n\r\n* " +
                     "Fascinating insight into operation of Equity markets and the challenges this poses for technology " +
                     "solutions – you do not have to be an equity market insider to use this book.\r\n\r\n* Examines next " +
                     "generation trading challenges, and potential solutions using .NET 2.0 and emerging technology, such " +
                     "as Avalon, Indigo and Longhorn. ",
                     ISBN = "978-1118531648",
                     ListPrice = 79.99,
                     Price = 50,
                     Price50 = 41,
                     Price100 = 32,
                     CategoryId = 5,
                     
                 },
                  new Product
                 {
                     Id = 16,
                     Title = "Software Engineering at Google",
                     Author = "Titus Winter & Tom Manshreck & Hyrum Wirght",
                     Description = "Software developers nowadays must know how to program well and build good engineering " +
                     "practices to keep their codebase healthy. This book focuses what distinguishes programming from software " +
                     "engineering.\r\nHow can software developers manage a live codebase that adapts to new needs? Software engineers " +
                     "Titus Winters and Hyrum Wright, along with technical writer Tom Manshreck, offer an honest and enlightening look at " +
                     "how some of the world's top software engineers build and maintain software based on their Google experience. Google's " +
                     "engineering culture, procedures, and tools and how they improve engineering organizations are covered in this book.",
                     ISBN = "979-8861298315 ",
                     ListPrice = 21,
                     Price = 18,
                     Price50 = 15,
                     Price100 = 9,
                     CategoryId = 5,
                     
                 }

                );


        }
    }
}
