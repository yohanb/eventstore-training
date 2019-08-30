using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;

namespace Registration.ExternalSharing.Events
{
    public class ExternalLinkGenerated : IEvent
    {
        public readonly Guid ExternalLinkId;
        public readonly string DisplayName;
        public readonly Guid FileId;

        public ExternalLinkGenerated(
            Guid externalLinkId,
            string displayName,
            Guid fileId
        )
        {
            ExternalLinkId = externalLinkId;
            DisplayName = displayName;
            FileId = fileId;
        }
    }
}
