﻿using System.Net.Http;
using System.Threading.Tasks;
using KPPDesktopUI.Library.Models;


namespace KPPDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}