using NovaBot.Models.ViewModels;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NovaBot.Helpers
{
    public class SlackOauthHelper
    {
        private readonly IHttpClientFactory _clientFactory;
        public string clientId = "";
        private readonly string scope = "";
        private readonly string redirectUri = "www";
        private readonly string clientSecret = "";
        public SlackOauthHelper(
            IHttpClientFactory clientFactory
            ) {
            _clientFactory = clientFactory;
        }


        public async Task SendUserAuth()
        {
            UriBuilder builder = new UriBuilder("https://slack.com/oauth/authorize");
            builder.Query = $"client_id={clientId}&scope={scope}&redirect_uri={redirectUri}";
            var request = new HttpRequestMessage(HttpMethod.Get, 
                builder.Uri);
           
            var client = _clientFactory.CreateClient();
            var result = await client.SendAsync(request);

        }

        public async Task ProcessVerificationCode(string code) {
            UriBuilder builder = new UriBuilder("https://slack.com/api/oauth.access");
            var payload = new ExchangeVerificationCodeRequestModel()
            {
                code = code,
                client_id = clientId,
                client_secret = clientSecret,
                redirect_uri = redirectUri


            };



        }

      
    }





}