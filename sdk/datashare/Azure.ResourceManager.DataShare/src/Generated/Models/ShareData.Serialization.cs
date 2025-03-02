// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    public partial class ShareData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ShareKind))
            {
                writer.WritePropertyName("shareKind");
                writer.WriteStringValue(ShareKind.Value.ToString());
            }
            if (Optional.IsDefined(Terms))
            {
                writer.WritePropertyName("terms");
                writer.WriteStringValue(Terms);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ShareData DeserializeShareData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<string> description = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<ShareKind> shareKind = default;
            Optional<string> terms = default;
            Optional<string> userEmail = default;
            Optional<string> userName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createdAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("shareKind"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            shareKind = new ShareKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("terms"))
                        {
                            terms = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userEmail"))
                        {
                            userEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userName"))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ShareData(id, name, type, systemData.Value, Optional.ToNullable(createdAt), description.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(shareKind), terms.Value, userEmail.Value, userName.Value);
        }
    }
}
