using System;
using System.Text;
using Infrastructure;

namespace Registration.ExternalSharing.Events
{
    public class FileDeleted : IEvent
    {
        public readonly Guid FileId;
        public readonly string DisplayName;
        public readonly string Initiator;

        public FileDeleted(
            Guid fileId,
            string displayName,
            string initiator
        )
        {
            FileId = fileId;
            DisplayName = displayName;
            Initiator = initiator;
        }
    }
}
