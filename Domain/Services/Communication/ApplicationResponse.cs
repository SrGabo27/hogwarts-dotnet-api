using hogwartsApi.Domain.Models;

namespace hogwartsApi.Domain.Services.Communication
{
    public class ApplicationResponse : BaseResponse
    {
        public Application Application { get; private set; }

        private ApplicationResponse(bool success, string message, Application application) : base(success, message)
        {
            Application = application;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="application">Saved application.</param>
        /// <returns>Response.</returns>
        public ApplicationResponse(Application application) : this(true, string.Empty, application)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public ApplicationResponse(string message) : this(false, message, null)
        { }
    }
}
