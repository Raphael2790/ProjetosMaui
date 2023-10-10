﻿using CommunityToolkit.Mvvm.Messaging.Messages;

namespace AppMVVMCommunityToolkit.Libraries.Messages;

public class TextMessage : ValueChangedMessage<string>
{
    public TextMessage(string value) : base(value)
    {
    }
}
