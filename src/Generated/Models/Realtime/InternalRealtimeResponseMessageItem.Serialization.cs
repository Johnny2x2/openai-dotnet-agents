// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeResponseMessageItem : IJsonModel<InternalRealtimeResponseMessageItem>
    {
        internal InternalRealtimeResponseMessageItem() : this(null, InternalRealtimeItemType.Message, null, null, default, default, null)
        {
        }

        void IJsonModel<InternalRealtimeResponseMessageItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseMessageItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeResponseMessageItem)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("status") != true)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("role") != true)
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("content") != true)
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStartArray();
                foreach (ConversationContentPart item in Content)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        InternalRealtimeResponseMessageItem IJsonModel<InternalRealtimeResponseMessageItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRealtimeResponseMessageItem)JsonModelCreateCore(ref reader, options);

        protected override InternalRealtimeResponseItem JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseMessageItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeResponseMessageItem)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeResponseMessageItem(document.RootElement, options);
        }

        internal static InternalRealtimeResponseMessageItem DeserializeInternalRealtimeResponseMessageItem(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @object = default;
            InternalRealtimeItemType kind = default;
            string id = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            ConversationItemStatus status = default;
            ConversationMessageRole role = default;
            IReadOnlyList<ConversationContentPart> content = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("object"u8))
                {
                    @object = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalRealtimeItemType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("id"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                        continue;
                    }
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("status"u8))
                {
                    status = new ConversationItemStatus(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("role"u8))
                {
                    role = new ConversationMessageRole(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("content"u8))
                {
                    List<ConversationContentPart> array = new List<ConversationContentPart>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ConversationContentPart.DeserializeConversationContentPart(item, options));
                    }
                    content = array;
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeResponseMessageItem(
                @object,
                kind,
                id,
                additionalBinaryDataProperties,
                status,
                role,
                content);
        }

        BinaryData IPersistableModel<InternalRealtimeResponseMessageItem>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseMessageItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeResponseMessageItem)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeResponseMessageItem IPersistableModel<InternalRealtimeResponseMessageItem>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRealtimeResponseMessageItem)PersistableModelCreateCore(data, options);

        protected override InternalRealtimeResponseItem PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseMessageItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeResponseMessageItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeResponseMessageItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeResponseMessageItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
