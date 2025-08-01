// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeClientEventConversationItemRetrieve : IJsonModel<InternalRealtimeClientEventConversationItemRetrieve>
    {
        internal InternalRealtimeClientEventConversationItemRetrieve() : this(InternalRealtimeClientEventType.ConversationItemRetrieve, null, null, null)
        {
        }

        void IJsonModel<InternalRealtimeClientEventConversationItemRetrieve>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventConversationItemRetrieve>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeClientEventConversationItemRetrieve)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("item_id") != true)
            {
                writer.WritePropertyName("item_id"u8);
                writer.WriteStringValue(ItemId);
            }
        }

        InternalRealtimeClientEventConversationItemRetrieve IJsonModel<InternalRealtimeClientEventConversationItemRetrieve>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRealtimeClientEventConversationItemRetrieve)JsonModelCreateCore(ref reader, options);

        protected override InternalRealtimeClientEvent JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventConversationItemRetrieve>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeClientEventConversationItemRetrieve)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeClientEventConversationItemRetrieve(document.RootElement, options);
        }

        internal static InternalRealtimeClientEventConversationItemRetrieve DeserializeInternalRealtimeClientEventConversationItemRetrieve(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRealtimeClientEventType kind = default;
            string eventId = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string itemId = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalRealtimeClientEventType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("event_id"u8))
                {
                    eventId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("item_id"u8))
                {
                    itemId = prop.Value.GetString();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeClientEventConversationItemRetrieve(kind, eventId, additionalBinaryDataProperties, itemId);
        }

        BinaryData IPersistableModel<InternalRealtimeClientEventConversationItemRetrieve>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventConversationItemRetrieve>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeClientEventConversationItemRetrieve)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeClientEventConversationItemRetrieve IPersistableModel<InternalRealtimeClientEventConversationItemRetrieve>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRealtimeClientEventConversationItemRetrieve)PersistableModelCreateCore(data, options);

        protected override InternalRealtimeClientEvent PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventConversationItemRetrieve>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeClientEventConversationItemRetrieve(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeClientEventConversationItemRetrieve)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeClientEventConversationItemRetrieve>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
