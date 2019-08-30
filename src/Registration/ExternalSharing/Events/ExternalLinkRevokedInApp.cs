using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;

namespace Registration.ExternalSharing.Events
{
    public class ExternalLinkRevokedInApp : IEvent
    {
        public readonly Guid ExternalLinkId;
        public readonly string Initiator;

        public ExternalLinkRevokedInApp(
            Guid externalLinkId,
            string initiator
        )
        {
            ExternalLinkId = externalLinkId;
            Initiator = initiator;
        }
    }
}