
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MattingImageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queuePosition")]
        public int? QueuePosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadedImageUrl")]
        public string? UploadedImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public double? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MattingImageResponse" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <param name="queuePosition"></param>
        /// <param name="uploadedImageUrl"></param>
        /// <param name="requestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MattingImageResponse(
            string? type,
            string? message,
            int? queuePosition,
            string? uploadedImageUrl,
            double? requestId)
        {
            this.Type = type;
            this.Message = message;
            this.QueuePosition = queuePosition;
            this.UploadedImageUrl = uploadedImageUrl;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MattingImageResponse" /> class.
        /// </summary>
        public MattingImageResponse()
        {
        }

    }
}