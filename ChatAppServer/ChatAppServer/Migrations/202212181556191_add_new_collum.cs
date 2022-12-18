namespace ChatAppServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_new_collum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatGroup", "isRead", c => c.Boolean(nullable: false));
            AddColumn("dbo.ChatMessage", "SendBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChatMessage", "SendBy");
            DropColumn("dbo.ChatGroup", "isRead");
        }
    }
}
