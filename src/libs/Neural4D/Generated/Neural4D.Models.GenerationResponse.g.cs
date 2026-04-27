
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("uuids")]
        public global::System.Collections.Generic.IList<string>? Uuids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponse" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <param name="uuids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponse(
            string? type,
            string? message,
            global::System.Collections.Generic.IList<string>? uuids)
        {
            this.Type = type;
            this.Message = message;
            this.Uuids = uuids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponse" /> class.
        /// </summary>
        public GenerationResponse()
        {
        }
    }
}