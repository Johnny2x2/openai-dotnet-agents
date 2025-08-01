// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal readonly partial struct InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum : IEquatable<InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum>
    {
        private readonly string _value;
        private const string AutoValue = "auto";

        public InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum Auto { get; } = new InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum(AutoValue);

        public static bool operator ==(InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum left, InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum right) => left.Equals(right);

        public static bool operator !=(InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum left, InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum right) => !left.Equals(right);

        public static implicit operator InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum(string value) => new InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum other && Equals(other);

        public bool Equals(InternalCreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
