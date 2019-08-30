using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;

namespace Registration.ExternalSharing.ReadModel
{
    public class SharedLink
    {
        public readonly Guid ExternalLinkId;
        public readonly string DisplayName;
        public readonly Guid FiledId;

        public SharedLink(
            Guid externalLinkId,
            string displayName,
            Guid fileId
        )
        {
            ExternalLinkId = externalLinkId;
            DisplayName = displayName;
            FiledId = fileId;            
        }
    }
}
