﻿using Client.Common.Models;

namespace Client.Common.EventAggregatorMessages
{
    public class StartPlaybackMessage : PlaybackMessageBase
    {
        public object Options { get; set; }

        public StartPlaybackMessage(PlaylistItem item)
            : base(item)
        {
        }
    }
}