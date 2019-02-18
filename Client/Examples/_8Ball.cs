using System;
using Response_Generator_Boilerplate;
namespace Client.Examples
{
    public class _8Ball
    {
        private string[] _responses;
        private Response_Generator_Boilerplate.ResponseGenerator _rgen;
        public _8Ball()
        {
            _responses = new string[] { "It is certain.", "It is decidedly so.", "Without a doubt.", "Yes - definitely.", "You may rely on it.", 
            "As I see it, yes.", "Most likely.", "Outlook good.", "Yes.", "Signs point to yes.", "Reply hazy, try again.", "Ask again later.", "Better not tell you now.",
            "Cannot predict now.", "Concentrate and ask again.", "Don't count on it.", "My reply is no.", "My sources say no.", "Outlook not so good.", "Very doubtful." };
            _rgen = new Response_Generator_Boilerplate.ResponseGenerator(_responses);
        }
        public string GenerateResponse()
            => _rgen.GenerateResponse();
    }
}
