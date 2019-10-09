namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    using System;
    using System.Collections.Generic;  

    public class QuestsRoomsBO
    {   
        public int Id { get; set; }
        public string NameQuestsRooms { get; set; }  
        public string DecriptionQuestsRooms { get; set; }  
        public int TimeForQuest { get; set; }      
        public int MaxGamer { get; set; }     
        public int MinGamer { get; set; }    
        public int FearsLevel { get; set; }   
        public int ComplexitysLevel { get; set; }     
    }
}
