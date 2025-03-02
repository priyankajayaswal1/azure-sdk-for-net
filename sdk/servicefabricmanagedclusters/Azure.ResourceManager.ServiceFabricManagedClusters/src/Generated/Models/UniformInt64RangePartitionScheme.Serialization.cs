// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class UniformInt64RangePartitionScheme : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("count");
            writer.WriteNumberValue(Count);
            writer.WritePropertyName("lowKey");
            writer.WriteNumberValue(LowKey);
            writer.WritePropertyName("highKey");
            writer.WriteNumberValue(HighKey);
            writer.WritePropertyName("partitionScheme");
            writer.WriteStringValue(PartitionScheme.ToString());
            writer.WriteEndObject();
        }

        internal static UniformInt64RangePartitionScheme DeserializeUniformInt64RangePartitionScheme(JsonElement element)
        {
            int count = default;
            long lowKey = default;
            long highKey = default;
            PartitionScheme partitionScheme = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lowKey"))
                {
                    lowKey = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("highKey"))
                {
                    highKey = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("partitionScheme"))
                {
                    partitionScheme = new PartitionScheme(property.Value.GetString());
                    continue;
                }
            }
            return new UniformInt64RangePartitionScheme(partitionScheme, count, lowKey, highKey);
        }
    }
}
