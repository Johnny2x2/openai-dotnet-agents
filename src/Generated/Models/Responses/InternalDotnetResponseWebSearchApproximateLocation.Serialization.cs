// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalDotnetResponseWebSearchApproximateLocation : IJsonModel<InternalDotnetResponseWebSearchApproximateLocation>
    {
        void IJsonModel<InternalDotnetResponseWebSearchApproximateLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalDotnetResponseWebSearchApproximateLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalDotnetResponseWebSearchApproximateLocation)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Country) && _additionalBinaryDataProperties?.ContainsKey("country") != true)
            {
                writer.WritePropertyName("country"u8);
                writer.WriteStringValue(Country);
            }
            if (Optional.IsDefined(Region) && _additionalBinaryDataProperties?.ContainsKey("region") != true)
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(City) && _additionalBinaryDataProperties?.ContainsKey("city") != true)
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (Optional.IsDefined(Timezone) && _additionalBinaryDataProperties?.ContainsKey("timezone") != true)
            {
                writer.WritePropertyName("timezone"u8);
                writer.WriteStringValue(Timezone);
            }
        }

        InternalDotnetResponseWebSearchApproximateLocation IJsonModel<InternalDotnetResponseWebSearchApproximateLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalDotnetResponseWebSearchApproximateLocation)JsonModelCreateCore(ref reader, options);

        protected override WebSearchUserLocation JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalDotnetResponseWebSearchApproximateLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalDotnetResponseWebSearchApproximateLocation)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalDotnetResponseWebSearchApproximateLocation(document.RootElement, options);
        }

        internal static InternalDotnetResponseWebSearchApproximateLocation DeserializeInternalDotnetResponseWebSearchApproximateLocation(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalWebSearchUserLocationKind kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string country = default;
            string region = default;
            string city = default;
            string timezone = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalWebSearchUserLocationKind(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("country"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        country = null;
                        continue;
                    }
                    country = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("region"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        region = null;
                        continue;
                    }
                    region = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("city"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        city = null;
                        continue;
                    }
                    city = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("timezone"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        timezone = null;
                        continue;
                    }
                    timezone = prop.Value.GetString();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalDotnetResponseWebSearchApproximateLocation(
                kind,
                additionalBinaryDataProperties,
                country,
                region,
                city,
                timezone);
        }

        BinaryData IPersistableModel<InternalDotnetResponseWebSearchApproximateLocation>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalDotnetResponseWebSearchApproximateLocation>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalDotnetResponseWebSearchApproximateLocation)} does not support writing '{options.Format}' format.");
            }
        }

        InternalDotnetResponseWebSearchApproximateLocation IPersistableModel<InternalDotnetResponseWebSearchApproximateLocation>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalDotnetResponseWebSearchApproximateLocation)PersistableModelCreateCore(data, options);

        protected override WebSearchUserLocation PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalDotnetResponseWebSearchApproximateLocation>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalDotnetResponseWebSearchApproximateLocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalDotnetResponseWebSearchApproximateLocation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalDotnetResponseWebSearchApproximateLocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
