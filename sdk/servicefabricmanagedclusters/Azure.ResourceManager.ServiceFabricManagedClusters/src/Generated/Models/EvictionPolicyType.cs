// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Specifies the eviction policy for virtual machines in a SPOT node type. </summary>
    public readonly partial struct EvictionPolicyType : IEquatable<EvictionPolicyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EvictionPolicyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EvictionPolicyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeleteValue = "Delete";
        private const string DeallocateValue = "Deallocate";

        /// <summary> Eviction policy will be Delete for SPOT vms. </summary>
        public static EvictionPolicyType Delete { get; } = new EvictionPolicyType(DeleteValue);
        /// <summary> Eviction policy will be Deallocate for SPOT vms. </summary>
        public static EvictionPolicyType Deallocate { get; } = new EvictionPolicyType(DeallocateValue);
        /// <summary> Determines if two <see cref="EvictionPolicyType"/> values are the same. </summary>
        public static bool operator ==(EvictionPolicyType left, EvictionPolicyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EvictionPolicyType"/> values are not the same. </summary>
        public static bool operator !=(EvictionPolicyType left, EvictionPolicyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EvictionPolicyType"/>. </summary>
        public static implicit operator EvictionPolicyType(string value) => new EvictionPolicyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EvictionPolicyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EvictionPolicyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
