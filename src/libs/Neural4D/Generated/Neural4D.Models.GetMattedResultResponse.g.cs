
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMattedResultResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mattedImageUrls")]
        public global::System.Collections.Generic.IList<string>? MattedImageUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileKeys")]
        public global::System.Collections.Generic.IList<string>? FileKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMattedResultResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="mattedImageUrls"></param>
        /// <param name="fileKeys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMattedResultResponse(
            string? message,
            global::System.Collections.Generic.IList<string>? mattedImageUrls,
            global::System.Collections.Generic.IList<string>? fileKeys)
        {
            this.Message = message;
            this.MattedImageUrls = mattedImageUrls;
            this.FileKeys = fileKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMattedResultResponse" /> class.
        /// </summary>
        public GetMattedResultResponse()
        {
        }

    }
}