﻿using System;

namespace KNFA.Bots.MTB.Events.Mumble
{
    public class UserLeft
    {
        public string Username { get; }

        public UserLeft(string username)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
        }
    }
}
