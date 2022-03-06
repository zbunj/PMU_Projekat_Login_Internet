using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ProjekatLogin
{
    public class SignInService
    {
        private const string SignInURI = "https://teslachatapp.herokuapp.com/api/users";

        public static async Task<SignInResponse> SignIn(SignInRequest requestData)
        {
            var chatAppClient = new HttpClient();
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, SignInURI);
            string jsonString = JsonSerializer.Serialize(requestData);
            httpRequest.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await chatAppClient.SendAsync(httpRequest);
            if (response.IsSuccessStatusCode)
            {
                var text = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<SignInResponse>(text);
            }
            else
            {
                return null;
            }
        }
    }
}
