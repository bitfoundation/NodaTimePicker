using Microsoft.AspNetCore.Blazor.Hosting;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace NodaTimePicker.Demo
{
    public class Program
	{
		public static async Task Main(string[] args)
		{
			CultureInfo Fa = new CultureInfo("fa-IR");

			Fa.DateTimeFormat.MonthNames = Fa.DateTimeFormat.AbbreviatedMonthGenitiveNames = Fa.DateTimeFormat.MonthGenitiveNames = Fa.DateTimeFormat.AbbreviatedMonthNames = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };

			CultureInfo.CurrentCulture = CultureInfo.CurrentUICulture = CultureInfo.DefaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentUICulture = Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = Fa;
			
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("app");

			await builder.Build().RunAsync();
		}
	}
}
