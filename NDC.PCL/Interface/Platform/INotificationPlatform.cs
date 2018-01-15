﻿namespace MeasurePro.Interface.Platform
{
    public interface INotificationPlatform
    {
        void RegisterForNotifications();
        void SendLocalNotification();   
        bool GetCurrentNotificationSettings();
    }
}
