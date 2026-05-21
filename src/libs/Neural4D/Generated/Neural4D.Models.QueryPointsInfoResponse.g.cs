
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryPointsInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusType")]
        public string? StatusType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Neural4D.PointsInfo? Data { get; set; }

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
        /// Initializes a new instance of the <see cref="QueryPointsInfoResponse" /> class.
        /// </summary>
        /// <param name="statusType"></param>
        /// <param name="data"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryPointsInfoResponse(
            string? statusType,
            global::Neural4D.PointsInfo? data,
            string? message)
        {
            this.StatusType = statusType;
            this.Data = data;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPointsInfoResponse" /> class.
        /// </summary>
        public QueryPointsInfoResponse()
        {
        }

    }
}