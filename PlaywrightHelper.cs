using Microsoft.Playwright;
using System;
using System.Threading.Tasks;

namespace SwagLabsDemo.Tests.Helpers
{
    public static class PlaywrightHelper
    {

        public static async Task<(IBrowser Browser, IPage Page)> CreateBrowserAndPageAsync(
            bool headless = true,
            string? browserNameOverride = null)
        {
            var playwright = await Playwright.CreateAsync();

            // Determine which browser to launch
            string browserName = browserNameOverride ?? Environment.GetEnvironmentVariable("BROWSER") ?? "chromium";

            IBrowser browser = browserName.ToLower() switch
            {
                "firefox" => await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions { Headless = headless }),
                "webkit"  => await playwright.Webkit.LaunchAsync(new BrowserTypeLaunchOptions { Headless = headless }),
                _         => await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = headless })
            };

            var page = await browser.NewPageAsync();
            return (browser, page);
        }
    }
}
