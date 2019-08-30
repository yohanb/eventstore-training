using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;

namespace Registration.ExternalSharing.Events
{
    public class ExternalLinkRevokedIn0365 : IEvent
    {
        public readonly Guid ExternalLinkId;
        public readonly Guid FileId;

        public ExternalLinkRevokedIn0365(
            Guid externalLinkId,
            Guid fileId
        )
        {
            ExternalLinkId = externalLinkId;
            FileId = fileId;
        }
    }
}
