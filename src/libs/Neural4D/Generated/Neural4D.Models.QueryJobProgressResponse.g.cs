
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryJobProgressResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusType")]
        public string? StatusType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryJobProgressResponse" /> class.
        /// </summary>
        /// <param name="statusType"></param>
        /// <param name="progress"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryJobProgressResponse(
            string? statusType,
            double? progress,
            string? message)
        {
            this.StatusType = statusType;
            this.Progress = progress;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryJobProgressResponse" /> class.
        /// </summary>
        public QueryJobProgressResponse()
        {
        }

    }
}