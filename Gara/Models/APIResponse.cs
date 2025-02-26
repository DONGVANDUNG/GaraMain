﻿namespace Gara.Models
{
    public class APIResponse
    {
        public dynamic Data { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }

        public APIResponse(dynamic data, int code, string message)
        {
            Data = data;
            Code = code;
            Message = message;
        }
    }
}

