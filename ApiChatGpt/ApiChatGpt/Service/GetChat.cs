using System.Text.Json;

namespace ApiChatGpt.Service
{
    public class GetChat
    {
        // Método para enviar a solicitação para o ChatGPT e obter a resposta
        public static async Task<string> GetChatGPTResponse(string apiKey, string model, string prompt)
        {
            // Inicialize um cliente HTTP
            using (HttpClient client = new HttpClient())
            {
                // Adicione a chave de API aos cabeçalhos da solicitação
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                decimal temperature = 0.7M;
                int max_tokens = 10;

                // Crie o corpo da solicitação em formato JSON
                string requestBody = JsonSerializer.Serialize(new
                {

                    model,
                    prompt,
                    max_tokens,
                    temperature
                }) ;

                // Converta o corpo da solicitação em um conteúdo HTTP
                var content = new StringContent(requestBody, System.Text.Encoding.UTF8, "application/json");

                // Envie a solicitação POST para a API do ChatGPT
                var response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);

                // Verifique se a solicitação foi bem-sucedida
                if (response.IsSuccessStatusCode)
                {
                    // Leia o corpo da resposta como uma string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Analise a resposta JSON
                    var jsonResponse = JsonSerializer.Deserialize<dynamic>(responseBody);

                    // Retorne a primeira escolha de resposta do ChatGPT
                    return jsonResponse.choices[0].text;
                }
                else
                {
                    // Em caso de erro, lance uma exceção
                    throw new Exception($"Erro ao enviar solicitação: {response.StatusCode}");
                }
            }
        }
    }
}
