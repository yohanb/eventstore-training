using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.ExternalSharing.ReadModel
{
    public class DataBase
    {
        public Dictionary<Guid, SharedLink> SharedLinksDataBase;
        public Dictionary<Guid, string> HistoryDataBase;
    }
}