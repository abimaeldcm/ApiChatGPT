using ApiChatGpt.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiChatGpt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<string>> GetAsync([FromBody] string prompt)
        {
            try
            {
                // Substitua "YOUR_API_KEY" pela sua chave de API gerada anteriormente
                //string apiKey = "sk-proj-UdMLKXspFLnuX4Rh6nplT3BlbkFJqBAcj4EAV19lhGaA8bO2";
                string apiKey = "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";

                // Especifique o modelo do ChatGPT a ser usado (você pode experimentar outros modelos)
                string model = "gpt-3.5-turbo";

                // Chame o método para obter a resposta do ChatGPT
                string response = await GetChat.GetChatGPTResponse(apiKey, model, prompt);

                // Retorne a resposta obtida do ChatGPT
                return Ok(response);
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorne um status de erro 500 e uma mensagem de erro
                return StatusCode(500, $"Erro ao obter resposta do ChatGPT: {ex.Message}");
            }
        }
    }
}
