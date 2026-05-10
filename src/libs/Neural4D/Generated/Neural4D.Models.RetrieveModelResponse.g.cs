
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieveModelResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codeStatus")]
        public string? CodeStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelUrl")]
        public string? ModelUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        public global::System.Collections.Generic.IList<string>? Prompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourcePage")]
        public string? SourcePage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveModelResponse" /> class.
        /// </summary>
        /// <param name="codeStatus"></param>
        /// <param name="message"></param>
        /// <param name="modelUrl"></param>
        /// <param name="imageUrl"></param>
        /// <param name="prompts"></param>
        /// <param name="createdAt"></param>
        /// <param name="sourcePage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveModelResponse(
            string? codeStatus,
            string? message,
            string? modelUrl,
            string? imageUrl,
            global::System.Collections.Generic.IList<string>? prompts,
            string? createdAt,
            string? sourcePage)
        {
            this.CodeStatus = codeStatus;
            this.Message = message;
            this.ModelUrl = modelUrl;
            this.ImageUrl = imageUrl;
            this.Prompts = prompts;
            this.CreatedAt = createdAt;
            this.SourcePage = sourcePage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveModelResponse" /> class.
        /// </summary>
        public RetrieveModelResponse()
        {
        }

    }
}