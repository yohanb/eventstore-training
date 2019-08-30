using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;

using Registration.ExternalSharing.ReadModel;

namespace Registration.ExternalSharing.Events
{
    public class EventDispatcher
    {
        private DataBase DataBase;

        public EventDispatcher(DataBase dataBase)
        {
            this.DataBase = dataBase;
        }
        
        public void AddEvent(IEvent eve)
        {
            switch (eve)
            {
                case ExternalLinkGenerated gen:
                    this.DataBase.SharedLinksDataBase.Add(gen.ExternalLinkId, new SharedLink(gen.ExternalLinkId, gen.DisplayName, gen.FileId));
                    break;
                
            }
        }
    }
}