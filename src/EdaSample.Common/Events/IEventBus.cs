﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EdaSample.Common.Events
{
    public interface IEventBus : IEventPublisher, IEventSubscriber
    {
        
    }
}
