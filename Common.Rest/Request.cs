﻿namespace FluentChange.Extensions.Common.Rest
{
    public class Request
    {

    }

    public class SingleRequest<T> : Request where T : class
    {
        public T Data { get; set; }

    }
}
