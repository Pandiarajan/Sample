﻿using System.Collections.Generic;

namespace TransportAnnouncementTracker.Tracker
{
    public interface IInformationReader
    {
        List<ArrivalEvent> GetArrivalEvents();
    }
}
