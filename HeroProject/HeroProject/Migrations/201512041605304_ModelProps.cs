namespace HeroProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelProps : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "MemberID", "dbo.Friends");
            DropForeignKey("dbo.Profiles", "InterestID", "dbo.Interests");
            DropIndex("dbo.Members", new[] { "MemberID" });
            DropIndex("dbo.Profiles", new[] { "InterestID" });
            RenameColumn(table: "dbo.Members", name: "MemberID", newName: "Friend_MemberID");
            RenameColumn(table: "dbo.Profiles", name: "InterestID", newName: "Interests_InterestID");
            CreateTable(
                "dbo.Demographics",
                c => new
                    {
                        DemographicsID = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.DemographicsID);
            
            AddColumn("dbo.Profiles", "Demographics_DemographicsID", c => c.Int());
            AlterColumn("dbo.Members", "Friend_MemberID", c => c.Int());
            AlterColumn("dbo.Profiles", "Interests_InterestID", c => c.Int());
            CreateIndex("dbo.Members", "Friend_MemberID");
            CreateIndex("dbo.Profiles", "Demographics_DemographicsID");
            CreateIndex("dbo.Profiles", "Interests_InterestID");
            AddForeignKey("dbo.Profiles", "Demographics_DemographicsID", "dbo.Demographics", "DemographicsID");
            AddForeignKey("dbo.Members", "Friend_MemberID", "dbo.Friends", "MemberID");
            AddForeignKey("dbo.Profiles", "Interests_InterestID", "dbo.Interests", "InterestID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "Interests_InterestID", "dbo.Interests");
            DropForeignKey("dbo.Members", "Friend_MemberID", "dbo.Friends");
            DropForeignKey("dbo.Profiles", "Demographics_DemographicsID", "dbo.Demographics");
            DropIndex("dbo.Profiles", new[] { "Interests_InterestID" });
            DropIndex("dbo.Profiles", new[] { "Demographics_DemographicsID" });
            DropIndex("dbo.Members", new[] { "Friend_MemberID" });
            AlterColumn("dbo.Profiles", "Interests_InterestID", c => c.Int(nullable: false));
            AlterColumn("dbo.Members", "Friend_MemberID", c => c.Int(nullable: false));
            DropColumn("dbo.Profiles", "Demographics_DemographicsID");
            DropTable("dbo.Demographics");
            RenameColumn(table: "dbo.Profiles", name: "Interests_InterestID", newName: "InterestID");
            RenameColumn(table: "dbo.Members", name: "Friend_MemberID", newName: "MemberID");
            CreateIndex("dbo.Profiles", "InterestID");
            CreateIndex("dbo.Members", "MemberID");
            AddForeignKey("dbo.Profiles", "InterestID", "dbo.Interests", "InterestID", cascadeDelete: true);
            AddForeignKey("dbo.Members", "MemberID", "dbo.Friends", "MemberID", cascadeDelete: true);
        }
    }
}
