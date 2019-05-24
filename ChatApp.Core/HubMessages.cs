﻿namespace ChatApp.Core
{
    public class HubMessages
    {
        public class Notifications
        {
            private const string UserJoinedMessage = "{0} connected";
            private const string UserLeftMessage = "{0} disconnected";

            public static string UserJoined(string name) => string.Format(UserJoinedMessage, name);
            public static string UserLeft(string name) => string.Format(UserLeftMessage, name);
        }

        public class Methods
        {
            public const string Connected = "Connected";
            public const string Disconnected = "Disconnected";
            public const string SendMessage = "SendMessage";
            public const string ReceiveMessage = "ReceiveMessage";
        }
    }
}