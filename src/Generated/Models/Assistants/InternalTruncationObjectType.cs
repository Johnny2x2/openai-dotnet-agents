// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalTruncationObjectType : IEquatable<InternalTruncationObjectType>
    {
        private readonly string _value;
        private const string AutoValue = "auto";
        private const string LastMessagesValue = "last_messages";

        public InternalTruncationObjectType(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalTruncationObjectType Auto { get; } = new InternalTruncationObjectType(AutoValue);

        internal static InternalTruncationObjectType LastMessages { get; } = new InternalTruncationObjectType(LastMessagesValue);

        public static bool operator ==(InternalTruncationObjectType left, InternalTruncationObjectType right) => left.Equals(right);

        public static bool operator !=(InternalTruncationObjectType left, InternalTruncationObjectType right) => !left.Equals(right);

        public static implicit operator InternalTruncationObjectType(string value) => new InternalTruncationObjectType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalTruncationObjectType other && Equals(other);

        public bool Equals(InternalTruncationObjectType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
