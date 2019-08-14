using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System.Security.Claims;
using GradeView.Data;

class CustomAuthStateProvider : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, "mrfibuli"),
        }, "Fake authentication type");

        var user = new ClaimsPrincipal(identity);

        return Task.FromResult(new AuthenticationState(user));
    }
}

namespace GradeView
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
            services.AddSingleton<WeatherForecastService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }

        //public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        //{
        //    // hack: create a new HttpClient rather than relying on the registered service as the AuthenticationStateProvider is initialized prior to IUriHelper ( https://github.com/aspnet/AspNetCore/issues/11867 )
        //    HttpClient http = new HttpClient();
        //    Uri uri = new Uri(urihelper.GetAbsoluteUri());
        //    string apiurl = uri.Scheme + "://" + uri.Authority + "/~/api/User/authenticate";
        //    User user = await http.GetJsonAsync<User>(apiurl);
        //    var identity = user.IsAuthenticated
        //        ? new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, user.Username) }, "serverauth")
        //        : new ClaimsIdentity();
        //    return new AuthenticationState(new ClaimsPrincipal(identity));
        //}
    }
}
