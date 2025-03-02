// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// Definition of which data will be collected from a separate VM extension that integrates with the Azure Monitor Agent.
    /// Collected from either Windows and Linux machines, depending on which extension is defined.
    /// </summary>
    public partial class ExtensionDataSource
    {
        /// <summary> Initializes a new instance of ExtensionDataSource. </summary>
        /// <param name="extensionName"> The name of the VM extension. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public ExtensionDataSource(string extensionName)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            Streams = new ChangeTrackingList<ExtensionDataSourceStream>();
            ExtensionName = extensionName;
            InputDataSources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ExtensionDataSource. </summary>
        /// <param name="streams">
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </param>
        /// <param name="extensionName"> The name of the VM extension. </param>
        /// <param name="extensionSettings"> The extension settings. The format is specific for particular extension. </param>
        /// <param name="inputDataSources"> The list of data sources this extension needs data from. </param>
        /// <param name="name">
        /// A friendly name for the data source. 
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </param>
        internal ExtensionDataSource(IList<ExtensionDataSourceStream> streams, string extensionName, BinaryData extensionSettings, IList<string> inputDataSources, string name)
        {
            Streams = streams;
            ExtensionName = extensionName;
            ExtensionSettings = extensionSettings;
            InputDataSources = inputDataSources;
            Name = name;
        }

        /// <summary>
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </summary>
        public IList<ExtensionDataSourceStream> Streams { get; }
        /// <summary> The name of the VM extension. </summary>
        public string ExtensionName { get; set; }
        /// <summary>
        /// The extension settings. The format is specific for particular extension.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData ExtensionSettings { get; set; }
        /// <summary> The list of data sources this extension needs data from. </summary>
        public IList<string> InputDataSources { get; }
        /// <summary>
        /// A friendly name for the data source. 
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
