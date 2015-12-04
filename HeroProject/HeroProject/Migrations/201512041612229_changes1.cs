namespace HeroProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "MessageID", "dbo.Messages");
            DropForeignKey("dbo.Members", "ProfileID", "dbo.Profiles");
            DropIndex("dbo.Members", new[] { "ProfileID" });
            DropIndex("dbo.Members", new[] { "MessageID" });
            RenameColumn(table: "dbo.Members", name: "MessageID", newName: "Message_MessageID");
            RenameColumn(table: "dbo.Members", name: "ProfileID", newName: "Profile_ID");
            AlterColumn("dbo.Members", "Profile_ID", c => c.Int());
            AlterColumn("dbo.Members", "Message_MessageID", c => c.Int());
            CreateIndex("dbo.Members", "Message_MessageID");
            CreateIndex("dbo.Members", "Profile_ID");
            AddForeignKey("dbo.Members", "Message_MessageID", "dbo.Messages", "MessageID");
            AddForeignKey("dbo.Members", "Profile_ID", "dbo.Profiles", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Profile_ID", "dbo.Profiles");
            DropForeignKey("dbo.Members", "Message_MessageID", "dbo.Messages");
            DropIndex("dbo.Members", new[] { "Profile_ID" });
            DropIndex("dbo.Members", new[] { "Message_MessageID" });
            AlterColumn("dbo.Members", "Message_MessageID", c => c.Int(nullable: false));
            AlterColumn("dbo.Members", "Profile_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Members", name: "Profile_ID", newName: "ProfileID");
            RenameColumn(table: "dbo.Members", name: "Message_MessageID", newName: "MessageID");
            CreateIndex("dbo.Members", "MessageID");
            CreateIndex("dbo.Members", "ProfileID");
            AddForeignKey("dbo.Members", "ProfileID", "dbo.Profiles", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Members", "MessageID", "dbo.Messages", "MessageID", cascadeDelete: true);
        }
    }
}
