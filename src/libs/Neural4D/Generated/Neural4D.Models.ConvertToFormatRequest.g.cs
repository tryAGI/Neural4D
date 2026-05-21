
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertToFormatRequest
    {
        /// <summary>
        /// Generated model UUID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// Target model format.<br/>
        /// Default Value: glb
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neural4D.JsonConverters.ConvertToFormatRequestModelTypeJsonConverter))]
        public global::Neural4D.ConvertToFormatRequestModelType? ModelType { get; set; }

        /// <summary>
        /// Target model size preset.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelSize")]
        public int? ModelSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertToFormatRequest" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Generated model UUID.
        /// </param>
        /// <param name="modelType">
        /// Target model format.<br/>
        /// Default Value: glb
        /// </param>
        /// <param name="modelSize">
        /// Target model size preset.<br/>
        /// Default Value: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvertToFormatRequest(
            string uuid,
            global::Neural4D.ConvertToFormatRequestModelType? modelType,
            int? modelSize)
        {
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
            this.ModelType = modelType;
            this.ModelSize = modelSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertToFormatRequest" /> class.
        /// </summary>
        public ConvertToFormatRequest()
        {
        }

    }
}