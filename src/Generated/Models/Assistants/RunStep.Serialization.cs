// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Assistants
{
    public partial class RunStep : IJsonModel<RunStep>
    {
        internal RunStep() : this(null, default, null, null, null, default, default, null, default, default, default, default, null, null, null, null, null)
        {
        }

        void IJsonModel<RunStep>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStep)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("id") != true)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("created_at") != true)
            {
                writer.WritePropertyName("created_at"u8);
                writer.WriteNumberValue(CreatedAt, "U");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("assistant_id") != true)
            {
                writer.WritePropertyName("assistant_id"u8);
                writer.WriteStringValue(AssistantId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("thread_id") != true)
            {
                writer.WritePropertyName("thread_id"u8);
                writer.WriteStringValue(ThreadId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("run_id") != true)
            {
                writer.WritePropertyName("run_id"u8);
                writer.WriteStringValue(RunId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Kind.ToSerialString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("status") != true)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("last_error") != true)
            {
                if (Optional.IsDefined(LastError))
                {
                    writer.WritePropertyName("last_error"u8);
                    writer.WriteObjectValue(LastError, options);
                }
                else
                {
                    writer.WriteNull("last_error"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("expired_at") != true)
            {
                if (Optional.IsDefined(ExpiredAt))
                {
                    writer.WritePropertyName("expired_at"u8);
                    writer.WriteNumberValue(ExpiredAt.Value, "U");
                }
                else
                {
                    writer.WriteNull("expired_at"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("cancelled_at") != true)
            {
                if (Optional.IsDefined(CancelledAt))
                {
                    writer.WritePropertyName("cancelled_at"u8);
                    writer.WriteNumberValue(CancelledAt.Value, "U");
                }
                else
                {
                    writer.WriteNull("cancelled_at"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("failed_at") != true)
            {
                if (Optional.IsDefined(FailedAt))
                {
                    writer.WritePropertyName("failed_at"u8);
                    writer.WriteNumberValue(FailedAt.Value, "U");
                }
                else
                {
                    writer.WriteNull("failed_at"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("completed_at") != true)
            {
                if (Optional.IsDefined(CompletedAt))
                {
                    writer.WritePropertyName("completed_at"u8);
                    writer.WriteNumberValue(CompletedAt.Value, "U");
                }
                else
                {
                    writer.WriteNull("completed_at"u8);
                }
            }
            // Plugin customization: remove options.Format != "W" check
            if (_additionalBinaryDataProperties?.ContainsKey("metadata") != true)
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (_additionalBinaryDataProperties?.ContainsKey("usage") != true)
            {
                if (Optional.IsDefined(Usage))
                {
                    writer.WritePropertyName("usage"u8);
                    writer.WriteObjectValue(Usage, options);
                }
                else
                {
                    writer.WriteNull("usage"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("object") != true)
            {
                writer.WritePropertyName("object"u8);
                writer.WriteStringValue(Object);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("step_details") != true)
            {
                writer.WritePropertyName("step_details"u8);
                writer.WriteObjectValue(Details, options);
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

        RunStep IJsonModel<RunStep>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual RunStep JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStep)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStep(document.RootElement, options);
        }

        internal static RunStep DeserializeRunStep(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            DateTimeOffset createdAt = default;
            string assistantId = default;
            string threadId = default;
            string runId = default;
            RunStepKind kind = default;
            RunStepStatus status = default;
            RunStepError lastError = default;
            DateTimeOffset? expiredAt = default;
            DateTimeOffset? cancelledAt = default;
            DateTimeOffset? failedAt = default;
            DateTimeOffset? completedAt = default;
            IReadOnlyDictionary<string, string> metadata = default;
            RunStepTokenUsage usage = default;
            string @object = default;
            RunStepDetails details = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("assistant_id"u8))
                {
                    assistantId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("thread_id"u8))
                {
                    threadId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("run_id"u8))
                {
                    runId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToRunStepKind();
                    continue;
                }
                if (prop.NameEquals("status"u8))
                {
                    status = new RunStepStatus(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("last_error"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastError = null;
                        continue;
                    }
                    lastError = RunStepError.DeserializeRunStepError(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("expired_at"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        expiredAt = null;
                        continue;
                    }
                    expiredAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("cancelled_at"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        cancelledAt = null;
                        continue;
                    }
                    cancelledAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("failed_at"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        failedAt = null;
                        continue;
                    }
                    failedAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("completed_at"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        completedAt = null;
                        continue;
                    }
                    completedAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("metadata"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        metadata = new ChangeTrackingDictionary<string, string>();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var prop0 in prop.Value.EnumerateObject())
                    {
                        if (prop0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(prop0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(prop0.Name, prop0.Value.GetString());
                        }
                    }
                    metadata = dictionary;
                    continue;
                }
                if (prop.NameEquals("usage"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        usage = null;
                        continue;
                    }
                    usage = RunStepTokenUsage.DeserializeRunStepTokenUsage(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("object"u8))
                {
                    @object = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("step_details"u8))
                {
                    details = RunStepDetails.DeserializeRunStepDetails(prop.Value, options);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new RunStep(
                id,
                createdAt,
                assistantId,
                threadId,
                runId,
                kind,
                status,
                lastError,
                expiredAt,
                cancelledAt,
                failedAt,
                completedAt,
                metadata,
                usage,
                @object,
                details,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<RunStep>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RunStep)} does not support writing '{options.Format}' format.");
            }
        }

        RunStep IPersistableModel<RunStep>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual RunStep PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeRunStep(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStep)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStep>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
