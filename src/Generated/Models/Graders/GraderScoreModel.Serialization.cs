// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;
using OpenAI.Evals;

namespace OpenAI.Graders
{
    public partial class GraderScoreModel : IJsonModel<GraderScoreModel>
    {
        internal GraderScoreModel() : this(GraderType.ScoreModel, null, null, null, null, null, null)
        {
        }

        void IJsonModel<GraderScoreModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GraderScoreModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GraderScoreModel)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("name") != true)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("model") != true)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (Optional.IsDefined(SamplingParams) && _additionalBinaryDataProperties?.ContainsKey("sampling_params") != true)
            {
                writer.WritePropertyName("sampling_params"u8);
#if NET6_0_OR_GREATER
                writer.WriteRawValue(SamplingParams);
#else
                using (JsonDocument document = JsonDocument.Parse(SamplingParams))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (_additionalBinaryDataProperties?.ContainsKey("input") != true)
            {
                writer.WritePropertyName("input"u8);
                writer.WriteStartArray();
                foreach (InternalEvalItem item in Input)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Range) && _additionalBinaryDataProperties?.ContainsKey("range") != true)
            {
                writer.WritePropertyName("range"u8);
                writer.WriteStartArray();
                foreach (float item in Range)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
        }

        GraderScoreModel IJsonModel<GraderScoreModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (GraderScoreModel)JsonModelCreateCore(ref reader, options);

        protected override Grader JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GraderScoreModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GraderScoreModel)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGraderScoreModel(document.RootElement, options);
        }

        internal static GraderScoreModel DeserializeGraderScoreModel(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GraderType kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string name = default;
            string model = default;
            BinaryData samplingParams = default;
            IList<InternalEvalItem> input = default;
            IList<float> range = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new GraderType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("name"u8))
                {
                    name = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("model"u8))
                {
                    model = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("sampling_params"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samplingParams = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                if (prop.NameEquals("input"u8))
                {
                    List<InternalEvalItem> array = new List<InternalEvalItem>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(InternalEvalItem.DeserializeInternalEvalItem(item, options));
                    }
                    input = array;
                    continue;
                }
                if (prop.NameEquals("range"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    range = array;
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new GraderScoreModel(
                kind,
                additionalBinaryDataProperties,
                name,
                model,
                samplingParams,
                input,
                range ?? new ChangeTrackingList<float>());
        }

        BinaryData IPersistableModel<GraderScoreModel>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GraderScoreModel>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(GraderScoreModel)} does not support writing '{options.Format}' format.");
            }
        }

        GraderScoreModel IPersistableModel<GraderScoreModel>.Create(BinaryData data, ModelReaderWriterOptions options) => (GraderScoreModel)PersistableModelCreateCore(data, options);

        protected override Grader PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<GraderScoreModel>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeGraderScoreModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GraderScoreModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GraderScoreModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
