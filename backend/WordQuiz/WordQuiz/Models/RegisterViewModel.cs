﻿namespace WordQuiz.Models
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PlayerName { get; set; }

        public string? PhotoContentType { get; set; }
        public byte[]? PhotoData { get; set; }

        public string Password { get; set; }

    }
}
