
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Neural4D.JsonConverters.ConvertToFormatRequestModelTypeJsonConverter),

            typeof(global::Neural4D.JsonConverters.ConvertToFormatRequestModelTypeNullableJsonConverter),

            typeof(global::Neural4D.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.GenerateModelWithTextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.GenerateModelWithImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.UuidRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.GetMattedResultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.ConvertToFormatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.ConvertToFormatRequestModelType), TypeInfoPropertyName = "ConvertToFormatRequestModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.GenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.RetrieveModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.MattingImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.GetMattedResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.ConvertToFormatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.CheckHumanImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.QueryPointsInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.PointsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.QueryJobProgressResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.MattingImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.CreateCuteModelsFromImagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neural4D.CheckHumanImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}