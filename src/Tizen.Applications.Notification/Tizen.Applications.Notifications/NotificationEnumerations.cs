/*
 * Copyright (c) 2017 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Tizen.Applications.Notifications
{
    using System;

    /// <summary>
    /// Enumeration for Progress category
    /// </summary>
    public enum ProgressCategory
    {
        /// <summary>
        /// Value for percent type
        /// </summary>
        Percent,

        /// <summary>
        /// Value for time type
        /// </summary>
        Time,

        /// <summary>
        /// Value for pending type which is not updated progress current value
        /// </summary>
        PendingBar
    }

    /// <summary>
    /// Enumeration for Accessory option
    /// </summary>
    public enum AccessoryOption
    {
        /// <summary>
        /// Value for off accessory option
        /// </summary>
        Off = -1,

        /// <summary>
        /// Value for on accessory option
        /// </summary>
        On,

        /// <summary>
        /// Value for custom accessory option
        /// </summary>
        Custom
    }

    /// <summary>
    /// Enumeration for Button Index
    /// </summary>
    public enum ButtonIndex
    {
        /// <summary>
        /// Value for default button index
        /// </summary>
        None = -1,

        /// <summary>
        /// Value for first button index
        /// </summary>
        First,

        /// <summary>
        /// Value for second button index
        /// </summary>
        Second,

        /// <summary>
        /// Value for third button index
        /// </summary>
        Third
    }

    /// <summary>
    /// Enumeration for notification particular property
    /// </summary>
    [Flags]
    public enum NotificationProperty
    {
        /// <summary>
        /// Value for adjust nothing
        /// </summary>
        None = 0x00,

        /// <summary>
        /// Value for display only SIM card inserted
        /// </summary>
        DisplayOnlySimMode = 0x01,

        /// <summary>
        /// Value for disable application launch when it selected
        /// </summary>
        DisableAppLaunch = 0x02,

        /// <summary>
        /// Value for disable auto delete when it selected
        /// </summary>
        DisableAutoDelete = 0x04,

        /// <summary>
        /// Value for deleted when device is rebooted even though notification is not set Ongoing
        /// </summary>
        VolatileDisplay = 0x100
    }

    /// <summary>
    /// Enumeration for block state
    /// </summary>
    public enum NotificationBlockState
    {
        /// <summary>
        /// Value to check the app is allowed to post notification
        /// </summary>
        Allowed = 0,

        /// <summary>
        /// Value to check the app is not allowed to post any notification
        /// </summary>
        Blocked,

        /// <summary>
        /// Value to check do not disturb mode which is user set
        /// </summary>
        DoNotDisturb
    }

    internal enum NotificationType
    {
        None = -1,
        Basic = 0,
        Ongoing,
    }

    internal enum NotificationEventType
    {
        FirstButton = 0,
        SecondButton,
        ThirdButton,
        ClickOnIcon = 6,
        ClockOnThumbnail = 7,
        ClickOnTextInputButton = 8,
        HiddenByUser = 100,
        HiddenByTimeout = 101,
        HiddenByExternal = 102,
    }

    internal enum NotificationLayout
    {
        None = 0,
        SingleEvent = 1,
        Thumbnail = 3,
        Ongoing = 4,
        Progress = 5,
        Extension = 6
    }

    internal enum NotificationText
    {
        Title = 0,
        Content,
        EventCount = 3,
        FirstMainText,
        FirstSubText,
        SecondMainText,
        SecondSubText,
        FirstButton = 13,
        SeceondButton = 14,
        ThirdButton = 15,
        PlaceHolder = 19,
        InputButton = 20,
    }

    internal enum NotificationImage
    {
        Icon = 0,
        IconForIndicator,
        IconForLock,
        Thumbnail,
        ThumbnailForLock,
        SubIcon,
        Background,
        FirstButton = 12,
        SecondButton,
        ThirdButton,
        TextInputButton = 18,
    }

    internal enum LaunchOption
    {
        AppControl = 1
    }

    [Flags]
    internal enum NotificationDisplayApplist
    {
        Tray = 0x00000001,
        Ticker = 0x00000002,
        Lock = 0x00000004,
        Indicator = 0x00000008,
        Active = 0x00000010,
        All = 0x0000000f,
    }
}
