# API de Chat GPT

Esta é uma API simples em ASP.NET Core que usa o modelo GPT-3.5-turbo da OpenAI para responder a consultas de usuário.

## Vídeo de Demonstração

[![Vídeo de Demonstração](https://img.youtube.com/vi/EVdJ3AjLozo/0.jpg)](https://www.youtube.com/watch?v=EVdJ3AjLozo)


## Pré-requisitos

- .NET Core SDK instalado
- Uma chave de API válida para a API OpenAI

## Como usar

1. Clone este repositório para o seu ambiente local:

git clone https://github.com/seu-usuario/api-chat-gpt.git

2. Abra o projeto em seu editor de código.

3. No arquivo `ChatGptController.cs`, substitua `"openaiApiKey"` pela sua chave de API OpenAI.

4. Execute o projeto. Você pode usar uma ferramenta como Postman ou Swagger para fazer solicitações GET para o endpoint `/api/ChatGpt` com um parâmetro de consulta chamado `query`. Por exemplo: `https://localhost:porta/api/ChatGpt?query=Como está o tempo hoje?`.

5. Você receberá uma resposta do modelo GPT-3.5-turbo com base na consulta fornecida.

## Observações

- Certifique-se de proteger sua chave de API e não a compartilhar publicamente.
- Este exemplo foi criado com base na documentação e práticas recomendadas da OpenAI disponíveis em [https://beta.openai.com/docs/](https://beta.openai.com/docs/).

## Contribuindo

Contribuições são bem-vindas! Sinta-se à vontade para abrir problemas ou enviar solicitações pull.

## Licença

Este projeto é licenciado sob a [Licença MIT](LICENSE).
