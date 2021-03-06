﻿using System;

using Orleankka;

namespace Example
{
    public interface IChatUser : IActorGrain
    {}

    [Serializable]
    public class Join : ActorMessage<IChatUser>
    {
        public string Room;
    }

    [Serializable]
    public class Leave : ActorMessage<IChatUser>
    {
        public string Room;
    }

    [Serializable]
    public class Say : ActorMessage<IChatUser>
    {
        public string Room;
        public string Message;
    }

    [Serializable]
    public class ChatRoomMessage
    {
        public string User;
        public string Text;
    }
}