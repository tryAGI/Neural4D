
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCuteModelsFromImagesRequest
    {
        /// <summary>
        /// Source image files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Images { get; set; }

        /// <summary>
        /// Requested stylization type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StyleType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCuteModelsFromImagesRequest" /> class.
        /// </summary>
        /// <param name="images">
        /// Source image files.
        /// </param>
        /// <param name="styleType">
        /// Requested stylization type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCuteModelsFromImagesRequest(
            global::System.Collections.Generic.IList<byte[]> images,
            string styleType)
        {
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.StyleType = styleType ?? throw new global::System.ArgumentNullException(nameof(styleType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCuteModelsFromImagesRequest" /> class.
        /// </summary>
        public CreateCuteModelsFromImagesRequest()
        {
        }
    }
}