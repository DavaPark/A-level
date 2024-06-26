﻿using System.Net.Http;
using System.Threading.Tasks;

namespace Rest.Services.Abstractions;
public interface IInternalHttpClientService
{
    Task<TResponse> SendAsync<TResponse>(string url, HttpMethod method, object? content = null);
    Task SendAsync(string url, HttpMethod method, object? content = null);
}