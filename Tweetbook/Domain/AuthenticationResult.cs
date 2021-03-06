using System.Collections.Generic;

namespace Tweetbook.Domain
{
    public class AuthenticationResult
    {
        public string Token { get; set; }

        public string RefreshToken { get; set; }

        public bool Success { get; set; }

        public IEnumerable<string> ErrorMessage { get; set; }
    }
}
