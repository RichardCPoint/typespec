// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Encode.Numeric.Models
{
    public partial class Uint32AsStringProperty : IJsonModel<Uint32AsStringProperty>
    {
        void IJsonModel<Uint32AsStringProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        Uint32AsStringProperty IJsonModel<Uint32AsStringProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual Uint32AsStringProperty JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<Uint32AsStringProperty>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        Uint32AsStringProperty IPersistableModel<Uint32AsStringProperty>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual Uint32AsStringProperty PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<Uint32AsStringProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        public static implicit operator BinaryContent(Uint32AsStringProperty uint32AsStringProperty) => throw null;

        public static explicit operator Uint32AsStringProperty(ClientResult result) => throw null;
    }
}