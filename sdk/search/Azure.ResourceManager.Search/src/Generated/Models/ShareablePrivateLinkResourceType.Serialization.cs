// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    public partial class ShareablePrivateLinkResourceType
    {
        internal static ShareablePrivateLinkResourceType DeserializeShareablePrivateLinkResourceType(JsonElement element)
        {
            Optional<string> name = default;
            Optional<ShareablePrivateLinkResourceProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = ShareablePrivateLinkResourceProperties.DeserializeShareablePrivateLinkResourceProperties(property.Value);
                    continue;
                }
            }
            return new ShareablePrivateLinkResourceType(name.Value, properties.Value);
        }
    }
}
