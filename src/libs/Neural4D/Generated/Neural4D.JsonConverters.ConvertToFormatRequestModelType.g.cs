#nullable enable

namespace Neural4D.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConvertToFormatRequestModelTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neural4D.ConvertToFormatRequestModelType>
    {
        /// <inheritdoc />
        public override global::Neural4D.ConvertToFormatRequestModelType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Neural4D.ConvertToFormatRequestModelTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Neural4D.ConvertToFormatRequestModelType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Neural4D.ConvertToFormatRequestModelType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neural4D.ConvertToFormatRequestModelType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Neural4D.ConvertToFormatRequestModelTypeExtensions.ToValueString(value));
        }
    }
}
