// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeSessionCreateResponseInputAudioTranscription : IJsonModel<InternalRealtimeSessionCreateResponseInputAudioTranscription>
    {
        void IJsonModel<InternalRealtimeSessionCreateResponseInputAudioTranscription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateResponseInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateResponseInputAudioTranscription)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Model) && _additionalBinaryDataProperties?.ContainsKey("model") != true)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
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

        InternalRealtimeSessionCreateResponseInputAudioTranscription IJsonModel<InternalRealtimeSessionCreateResponseInputAudioTranscription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalRealtimeSessionCreateResponseInputAudioTranscription JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateResponseInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateResponseInputAudioTranscription)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeSessionCreateResponseInputAudioTranscription(document.RootElement, options);
        }

        internal static InternalRealtimeSessionCreateResponseInputAudioTranscription DeserializeInternalRealtimeSessionCreateResponseInputAudioTranscription(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string model = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("model"u8))
                {
                    model = prop.Value.GetString();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeSessionCreateResponseInputAudioTranscription(model, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRealtimeSessionCreateResponseInputAudioTranscription>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateResponseInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateResponseInputAudioTranscription)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeSessionCreateResponseInputAudioTranscription IPersistableModel<InternalRealtimeSessionCreateResponseInputAudioTranscription>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalRealtimeSessionCreateResponseInputAudioTranscription PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateResponseInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeSessionCreateResponseInputAudioTranscription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateResponseInputAudioTranscription)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeSessionCreateResponseInputAudioTranscription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
