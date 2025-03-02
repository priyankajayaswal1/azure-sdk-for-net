// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AutomationActionEventHub : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EventHubResourceId))
            {
                writer.WritePropertyName("eventHubResourceId");
                writer.WriteStringValue(EventHubResourceId);
            }
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString");
                writer.WriteStringValue(ConnectionString);
            }
            writer.WritePropertyName("actionType");
            writer.WriteStringValue(ActionType.ToString());
            writer.WriteEndObject();
        }

        internal static AutomationActionEventHub DeserializeAutomationActionEventHub(JsonElement element)
        {
            Optional<string> eventHubResourceId = default;
            Optional<string> sasPolicyName = default;
            Optional<string> connectionString = default;
            ActionType actionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventHubResourceId"))
                {
                    eventHubResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasPolicyName"))
                {
                    sasPolicyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionString"))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionType"))
                {
                    actionType = new ActionType(property.Value.GetString());
                    continue;
                }
            }
            return new AutomationActionEventHub(actionType, eventHubResourceId.Value, sasPolicyName.Value, connectionString.Value);
        }
    }
}
