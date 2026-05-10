
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateModelWithImageRequest
    {
        /// <summary>
        /// File key returned by the matting result endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileKey { get; set; }

        /// <summary>
        /// Number of model candidates to generate.<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelCount")]
        public int? ModelCount { get; set; }

        /// <summary>
        /// Set to 1 to disable PBR material generation.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disablePbr")]
        public int? DisablePbr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateModelWithImageRequest" /> class.
        /// </summary>
        /// <param name="fileKey">
        /// File key returned by the matting result endpoint.
        /// </param>
        /// <param name="modelCount">
        /// Number of model candidates to generate.<br/>
        /// Default Value: 4
        /// </param>
        /// <param name="disablePbr">
        /// Set to 1 to disable PBR material generation.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateModelWithImageRequest(
            string fileKey,
            int? modelCount,
            int? disablePbr)
        {
            this.FileKey = fileKey ?? throw new global::System.ArgumentNullException(nameof(fileKey));
            this.ModelCount = modelCount;
            this.DisablePbr = disablePbr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateModelWithImageRequest" /> class.
        /// </summary>
        public GenerateModelWithImageRequest()
        {
        }

    }
}