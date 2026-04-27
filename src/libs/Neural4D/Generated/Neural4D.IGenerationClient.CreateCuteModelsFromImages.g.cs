#nullable enable

namespace Neural4D
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Create stylized character models from images
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neural4D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neural4D.GenerationResponse> CreateCuteModelsFromImagesAsync(

            global::Neural4D.CreateCuteModelsFromImagesRequest request,
            global::Neural4D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create stylized character models from images
        /// </summary>
        /// <param name="images">
        /// Source image files.
        /// </param>
        /// <param name="styleType">
        /// Requested stylization type.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neural4D.GenerationResponse> CreateCuteModelsFromImagesAsync(
            global::System.Collections.Generic.IList<byte[]> images,
            string styleType,
            global::Neural4D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}