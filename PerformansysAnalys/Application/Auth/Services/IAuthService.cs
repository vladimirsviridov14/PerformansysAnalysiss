

using Microsoft.AspNetCore.Identity.Data;
using PerformansysAnalys.Application.Auth.Dtos;
using LoginRequest = PerformansysAnalys.Application.Auth.Dtos.LoginRequest;

namespace PerformansysAnalys.Application.Auth.Services
{
   
        public interface IAuthService
        {
        Task<AuthResponse> RegisterAsync(ReqisterRequest request, CancellationToken ct = default);
        Task<AuthResponse> LoginAsync(LoginRequest request, CancellationToken ct = default);
        Task<AuthResponse> LoginWithCookieAsync(LoginWithCookieRequest request, CancellationToken ct = default);
        Task LogoutAsync(CancellationToken ct = default);
    }
    
}
