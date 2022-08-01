using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Logging;
using DBSoft.FMPCloud.Model;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.Utilities.Submitters
{
    public class WebSubmitter : ISubmitter
    {
        protected readonly IHttpClientFactory HttpClientFactory;
        protected readonly ILogger Logger;
        protected readonly string MediaType = "application/json";

        public WebSubmitter(IHttpClientFactory httpClientFactory, ILogger<WebSubmitter> logger)
            => (HttpClientFactory, Logger) = (httpClientFactory, logger);


        public async Task<SubmitResponse> SubmitAsync(string destination, Dictionary<string, string> parameters)
        {
            try
            {
                var client = HttpClientFactory.CreateClient();

                client.DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue(MediaType));

                var webResponse = await client.GetAsync(FormatDestination(destination, parameters));

                return new SubmitResponse
                {
                    StatusCode = webResponse.StatusCode,
                    Content = await webResponse.Content.ReadAsStringAsync()
                };
            }
            catch (Exception ex)
            {
                Logger.RequestError(destination, ex);
                throw;
            }
        }

        public virtual string FormatDestination(string destination, Dictionary<string, string> parameters)
        {
            var builder = new StringBuilder();
            foreach (KeyValuePair<string, string> pairs in parameters)
            {
                builder.Append($"{pairs.Key}={pairs.Value}&");
            }

            return $"{destination}?{builder.ToString().TrimEnd('&')}";
        }
    }
}
