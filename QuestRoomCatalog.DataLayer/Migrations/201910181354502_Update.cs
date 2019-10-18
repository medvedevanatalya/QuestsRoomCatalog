namespace QuestRoomCatalog.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.QuestsLogos", "Image", c => c.Binary(maxLength: 128, fixedLength: true));
            //AddColumn("dbo.QuestsRooms", "Description", c => c.String(nullable: false));
            //DropColumn("dbo.QuestsRooms", "Decription");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.QuestsRooms", "Decription", c => c.String(nullable: false));
            //DropColumn("dbo.QuestsRooms", "Description");
            //DropColumn("dbo.QuestsLogos", "Image");
        }
    }
}
