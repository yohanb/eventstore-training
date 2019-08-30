using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.ExternalSharing.ReadModel
{
    public class DataBase
    {
        public DataBase()
        {
            this.SharedLinksDataBase = new Dictionary<Guid, SharedLink>();
            this.HistoryDataBase = new Dictionary<Guid, string>();
        }
        public Dictionary<Guid, SharedLink> SharedLinksDataBase;
        public Dictionary<Guid, string> HistoryDataBase;
    }
}