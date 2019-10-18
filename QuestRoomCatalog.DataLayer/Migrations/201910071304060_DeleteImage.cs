namespace QuestRoomCatalog.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteImage : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.QuestsLogos", "Image");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.QuestsLogos", "Image", c => c.Binary(nullable: false, maxLength: 1, fixedLength: true));
        }
    }
}
