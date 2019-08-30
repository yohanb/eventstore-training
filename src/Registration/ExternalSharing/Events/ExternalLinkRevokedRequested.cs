using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;

namespace Registration.ExternalSharing.Events
{
    public class ExternalLinkRevokedRequested : IEvent
    {
        public readonly Guid ExternalLinkId;
        public readonly string DisplayName;
        public readonly string Initiator;

        public ExternalLinkRevokedRequested(
            Guid externalLinkId,
            string displayName,
            string initiator
        )
        {
            ExternalLinkId = externalLinkId;
            DisplayName = displayName;
            Initiator = initiator;
        }
    }
}
