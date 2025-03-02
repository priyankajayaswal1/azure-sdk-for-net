// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlInstanceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation");
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(MaxDop))
            {
                writer.WritePropertyName("maxDop");
                writer.WriteNumberValue(MaxDop.Value);
            }
            if (Optional.IsDefined(IsOptimizeForAdHocWorkloadsEnabled))
            {
                writer.WritePropertyName("isOptimizeForAdHocWorkloadsEnabled");
                writer.WriteBooleanValue(IsOptimizeForAdHocWorkloadsEnabled.Value);
            }
            if (Optional.IsDefined(MinServerMemoryInMB))
            {
                writer.WritePropertyName("minServerMemoryMB");
                writer.WriteNumberValue(MinServerMemoryInMB.Value);
            }
            if (Optional.IsDefined(MaxServerMemoryInMB))
            {
                writer.WritePropertyName("maxServerMemoryMB");
                writer.WriteNumberValue(MaxServerMemoryInMB.Value);
            }
            if (Optional.IsDefined(IsLpimEnabled))
            {
                writer.WritePropertyName("isLpimEnabled");
                writer.WriteBooleanValue(IsLpimEnabled.Value);
            }
            if (Optional.IsDefined(IsIfiEnabled))
            {
                writer.WritePropertyName("isIfiEnabled");
                writer.WriteBooleanValue(IsIfiEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static SqlInstanceSettings DeserializeSqlInstanceSettings(JsonElement element)
        {
            Optional<string> collation = default;
            Optional<int> maxDop = default;
            Optional<bool> isOptimizeForAdHocWorkloadsEnabled = default;
            Optional<int> minServerMemoryMB = default;
            Optional<int> maxServerMemoryMB = default;
            Optional<bool> isLpimEnabled = default;
            Optional<bool> isIfiEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("collation"))
                {
                    collation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxDop"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxDop = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isOptimizeForAdHocWorkloadsEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isOptimizeForAdHocWorkloadsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minServerMemoryMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minServerMemoryMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxServerMemoryMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxServerMemoryMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isLpimEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isLpimEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isIfiEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isIfiEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SqlInstanceSettings(collation.Value, Optional.ToNullable(maxDop), Optional.ToNullable(isOptimizeForAdHocWorkloadsEnabled), Optional.ToNullable(minServerMemoryMB), Optional.ToNullable(maxServerMemoryMB), Optional.ToNullable(isLpimEnabled), Optional.ToNullable(isIfiEnabled));
        }
    }
}
