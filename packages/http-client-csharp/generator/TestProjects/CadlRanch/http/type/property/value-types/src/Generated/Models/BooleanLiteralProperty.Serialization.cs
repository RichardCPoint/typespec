// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Type.Property.ValueTypes.Models
{
    public partial class BooleanLiteralProperty : IJsonModel<BooleanLiteralProperty>
    {
        void IJsonModel<BooleanLiteralProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        BooleanLiteralProperty IJsonModel<BooleanLiteralProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual BooleanLiteralProperty JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<BooleanLiteralProperty>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        BooleanLiteralProperty IPersistableModel<BooleanLiteralProperty>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual BooleanLiteralProperty PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<BooleanLiteralProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        public static implicit operator BinaryContent(BooleanLiteralProperty booleanLiteralProperty) => throw null;

        public static explicit operator BooleanLiteralProperty(ClientResult result) => throw null;
    }
}