#nullable enable

namespace Neural4D
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Check whether an image contains a person
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neural4D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neural4D.CheckHumanImageResponse> CheckHumanImageAsync(

            global::Neural4D.CheckHumanImageRequest request,
            global::Neural4D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check whether an image contains a person
        /// </summary>
        /// <param name="image">
        /// Image to inspect.
        /// </param>
        /// <param name="imagename">
        /// Image to inspect.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neural4D.CheckHumanImageResponse> CheckHumanImageAsync(
            byte[] image,
            string imagename,
            global::Neural4D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}