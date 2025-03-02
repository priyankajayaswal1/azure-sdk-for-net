// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base class for inputs to a Job.
    /// Please note <see cref="MediaTransformJobInputBasicProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MediaTransformJobInputAsset"/>, <see cref="MediaTransformJobInputClip"/>, <see cref="MediaTransformJobInputHttp"/>, <see cref="MediaTransformJobInputSequence"/> and <see cref="MediaTransformJobInputs"/>.
    /// </summary>
    public abstract partial class MediaTransformJobInputBasicProperties
    {
        /// <summary> Initializes a new instance of MediaTransformJobInputBasicProperties. </summary>
        protected MediaTransformJobInputBasicProperties()
        {
        }

        /// <summary> Initializes a new instance of MediaTransformJobInputBasicProperties. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal MediaTransformJobInputBasicProperties(string odataType)
        {
            OdataType = odataType;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
    }
}
