
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateModelWithTextRequest
    {
        /// <summary>
        /// Prompt describing the model to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateModelWithTextRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Prompt describing the model to generate.
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
        public GenerateModelWithTextRequest(
            string prompt,
            int? modelCount,
            int? disablePbr)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ModelCount = modelCount;
            this.DisablePbr = disablePbr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateModelWithTextRequest" /> class.
        /// </summary>
        public GenerateModelWithTextRequest()
        {
        }
    }
}