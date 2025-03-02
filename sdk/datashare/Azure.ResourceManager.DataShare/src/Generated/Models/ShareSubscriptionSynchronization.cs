// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A ShareSubscriptionSynchronization data transfer object. </summary>
    public partial class ShareSubscriptionSynchronization
    {
        /// <summary> Initializes a new instance of ShareSubscriptionSynchronization. </summary>
        /// <param name="synchronizationId"> Synchronization id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationId"/> is null. </exception>
        public ShareSubscriptionSynchronization(string synchronizationId)
        {
            if (synchronizationId == null)
            {
                throw new ArgumentNullException(nameof(synchronizationId));
            }

            SynchronizationId = synchronizationId;
        }

        /// <summary> Initializes a new instance of ShareSubscriptionSynchronization. </summary>
        /// <param name="durationMs"> Synchronization duration. </param>
        /// <param name="endOn"> End time of synchronization. </param>
        /// <param name="message"> message of Synchronization. </param>
        /// <param name="startOn"> start time of synchronization. </param>
        /// <param name="status"> Raw Status. </param>
        /// <param name="synchronizationId"> Synchronization id. </param>
        /// <param name="synchronizationMode"> Synchronization Mode. </param>
        internal ShareSubscriptionSynchronization(int? durationMs, DateTimeOffset? endOn, string message, DateTimeOffset? startOn, string status, string synchronizationId, SynchronizationMode? synchronizationMode)
        {
            DurationMs = durationMs;
            EndOn = endOn;
            Message = message;
            StartOn = startOn;
            Status = status;
            SynchronizationId = synchronizationId;
            SynchronizationMode = synchronizationMode;
        }

        /// <summary> Synchronization duration. </summary>
        public int? DurationMs { get; }
        /// <summary> End time of synchronization. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> message of Synchronization. </summary>
        public string Message { get; }
        /// <summary> start time of synchronization. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Raw Status. </summary>
        public string Status { get; }
        /// <summary> Synchronization id. </summary>
        public string SynchronizationId { get; set; }
        /// <summary> Synchronization Mode. </summary>
        public SynchronizationMode? SynchronizationMode { get; }
    }
}
