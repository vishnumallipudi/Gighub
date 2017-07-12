using System;

namespace GigHub.Dtos
{
    public class NotificationDto
    {
        public DateTime DateTime { get;  set; }
        public Models.NotificationType Type { get;  set; }
        public DateTime? OriginalDateTime { get;  set; }
        public string OriginalVenue { get;  set; }

        public GigDto Gig { get;  set; }
    }
}