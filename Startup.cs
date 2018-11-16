using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BlazorPlayground
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.ToList().ForEach(s => Console.WriteLine($"Service: {s.ServiceType?.Name ?? "Missing"} {s.Lifetime.ToString()} {s.ImplementationType?.FullName ?? "Missing"}"));
		}

		public void Configure(IBlazorApplicationBuilder app)
		{
			app.AddComponent<App>("app");
		}
	}
}
