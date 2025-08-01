// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Assistants
{
    [Experimental("OPENAI001")]
    public partial class RunIncompleteDetails
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal RunIncompleteDetails()
        {
        }

        internal RunIncompleteDetails(RunIncompleteReason? reason, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Reason = reason;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public RunIncompleteReason? Reason { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
