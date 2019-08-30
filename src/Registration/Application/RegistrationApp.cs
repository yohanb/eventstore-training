using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Registration.ExternalSharing.Events;

namespace Registration.Application
{
    public class RegistrationApp
    {
        public void GenerateData(EventDispatcher dispatcher)
        {
            var rnd = new Random();

            for (var fileNo = 1; fileNo <= 10 + rnd.Next((10)); fileNo++)
            {
                var fileId = Guid.NewGuid();
                foreach (var i in Enumerable.Range(0, rnd.Next(2)))
                {
                    var @event = new ExternalLinkGenerated(Guid.NewGuid(), "File #" + fileNo, fileId);
                    dispatcher.AddEvent(@event);
                }
            }
        }
    }
}
