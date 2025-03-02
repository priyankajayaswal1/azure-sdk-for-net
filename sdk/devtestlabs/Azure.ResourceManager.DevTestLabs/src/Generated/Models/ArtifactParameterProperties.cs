// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of an artifact parameter. </summary>
    public partial class ArtifactParameterProperties
    {
        /// <summary> Initializes a new instance of ArtifactParameterProperties. </summary>
        public ArtifactParameterProperties()
        {
        }

        /// <summary> Initializes a new instance of ArtifactParameterProperties. </summary>
        /// <param name="name"> The name of the artifact parameter. </param>
        /// <param name="value"> The value of the artifact parameter. </param>
        internal ArtifactParameterProperties(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name of the artifact parameter. </summary>
        public string Name { get; set; }
        /// <summary> The value of the artifact parameter. </summary>
        public string Value { get; set; }
    }
}
