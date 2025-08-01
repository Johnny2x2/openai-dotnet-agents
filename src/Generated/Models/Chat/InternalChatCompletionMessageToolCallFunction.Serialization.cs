// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionMessageToolCallFunction : IJsonModel<InternalChatCompletionMessageToolCallFunction>
    {
        internal InternalChatCompletionMessageToolCallFunction()
        {
        }

        void IJsonModel<InternalChatCompletionMessageToolCallFunction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionMessageToolCallFunction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionMessageToolCallFunction)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("name") != true)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("arguments") != true)
            {
                writer.WritePropertyName("arguments"u8);
                SerializeArgumentsValue(writer, options);
            }
            // Plugin customization: remove options.Format != "W" check
            if (_additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        InternalChatCompletionMessageToolCallFunction IJsonModel<InternalChatCompletionMessageToolCallFunction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalChatCompletionMessageToolCallFunction JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionMessageToolCallFunction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionMessageToolCallFunction)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalChatCompletionMessageToolCallFunction(document.RootElement, options);
        }

        internal static InternalChatCompletionMessageToolCallFunction DeserializeInternalChatCompletionMessageToolCallFunction(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            BinaryData arguments = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("name"u8))
                {
                    name = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("arguments"u8))
                {
                    DeserializeArgumentsValue(prop, ref arguments);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalChatCompletionMessageToolCallFunction(name, arguments, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalChatCompletionMessageToolCallFunction>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionMessageToolCallFunction>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionMessageToolCallFunction)} does not support writing '{options.Format}' format.");
            }
        }

        InternalChatCompletionMessageToolCallFunction IPersistableModel<InternalChatCompletionMessageToolCallFunction>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalChatCompletionMessageToolCallFunction PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionMessageToolCallFunction>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalChatCompletionMessageToolCallFunction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionMessageToolCallFunction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalChatCompletionMessageToolCallFunction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
