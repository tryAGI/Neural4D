
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertToFormatResponse
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("statusType")]
        public string? StatusType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertToFormatResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="modelUrl"></param>
        /// <param name="statusType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvertToFormatResponse(
            string? message,
            string? modelUrl,
            string? statusType)
        {
            this.Message = message;
            this.ModelUrl = modelUrl;
            this.StatusType = statusType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertToFormatResponse" /> class.
        /// </summary>
        public ConvertToFormatResponse()
        {
        }
    }
}