﻿using System;
using System.Net;
using Upnp.Collections;

namespace Upnp.Ssdp
{
    public interface ISsdpAnnouncer : IDisposable
    {
        /// <summary>
        /// Starts this instance.
        /// </summary>
        void Start();

        /// <summary>
        /// Shutdowns this instance.
        /// </summary>
        void Shutdown();

        /// <summary>
        /// Sends the alive message.
        /// </summary>
        void SendAliveMessage();

        /// <summary>
        /// Gets a value indicating whether this instance is running.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is running; otherwise, <c>false</c>.
        /// </value>
        bool IsRunning { get; }

        /// <summary>
        /// Gets the remote end points.
        /// </summary>
        SyncCollection<IPEndPoint> RemoteEndPoints { get; }

        /// <summary>
        /// Gets or sets the type of the notification.
        /// </summary>
        /// <value>
        /// The type of the notification.
        /// </value>
        string NotificationType { get; set; }

        /// <summary>
        /// Gets or sets the USN.
        /// </summary>
        /// <value>
        /// The USN.
        /// </value>
        string USN { get; set; }

        /// <summary>
        /// Gets or sets the max age.
        /// </summary>
        /// <value>
        /// The max age.
        /// </value>
        ushort MaxAge { get; set; }

        /// <summary>
        /// Gets or sets the user agent.
        /// </summary>
        /// <value>
        /// The user agent.
        /// </value>
        string UserAgent { get; set; }
    }
}