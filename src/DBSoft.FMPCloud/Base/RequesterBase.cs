using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Model;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DBSoft.FMPCloud
{
    public class RequesterBase<TResponse, TResponseData>
        : FmpBase
        where TResponse : ResponseBase<TResponseData>, new()
    {
        protected readonly Dictionary<string, string> Parameters;
        protected readonly string BaseUrl = StaticResources.BaseUrl;
        protected string RequesterPath = string.Empty;

        protected string Url
        {
            get
            {
                return $"{BaseUrl}{RequesterPath}";
            }
        }

        internal RequesterBase(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            Parameters = new Dictionary<string, string>()
            {
                {"apikey", configuration.ApiKey }
            };
        }

        protected virtual T Deserialize<T>(string content)
        {
            return JsonConvert.DeserializeObject<T>(content, Configuration.SerializerSettings);
        }

        protected virtual TResponse GetStandardResponse(SubmitResponse response)
        {
            var errorResponse = CheckForError(response);

            return new TResponse
            {
                Status = errorResponse == null ? Status.Success : Status.Error,
                ErrorMessage = errorResponse == null ? string.Empty : errorResponse.ErrorMessage,
                Data = errorResponse == null ? Deserialize<TResponseData>(response.Content) : default
            };
        }

        protected virtual ErrorResponse CheckForError(SubmitResponse response)
        {
            if (response.Content.Contains("Error Message"))
                return Deserialize<ErrorResponse>(response.Content);

            return null;
        }
    }
}
