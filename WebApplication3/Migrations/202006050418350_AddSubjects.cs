﻿namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubjects : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Room = c.Int(nullable: false),
                        Title = c.String(),
                        CourseName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "Subject_Id", c => c.Int());
            CreateIndex("dbo.Students", "Subject_Id");
            AddForeignKey("dbo.Students", "Subject_Id", "dbo.Subjects", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Subject_Id", "dbo.Subjects");
            DropIndex("dbo.Students", new[] { "Subject_Id" });
            DropColumn("dbo.Students", "Subject_Id");
            DropTable("dbo.Subjects");
        }
    }
}
