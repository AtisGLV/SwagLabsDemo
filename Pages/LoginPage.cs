using Microsoft.Playwright;

namespace SwagLabsDemo.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;

        public LoginPage(IPage page)
        {
            _page = page;
        }


        public async Task GoToWebsite()
        {
            await _page.GotoAsync("https://www.saucedemo.com/");
        }

        // Generic login
        public async Task LogIn(string username, string password)
        {

            await UsernameField.FillAsync(username);
            await PasswordField.FillAsync(password);
            await LoginButton.ClickAsync();
        }

        // Predefined logins
        public async Task LogInAsStandardUser()
        {
            var username = Environment.GetEnvironmentVariable("SAUCE_USERNAME") ?? "standard_user";
            var password = Environment.GetEnvironmentVariable("SAUCE_PASSWORD") ?? "secret_sauce";

            await LogIn(username, password);
        }

        public async Task LogInAsLockedOutUser()
        {
            await LogIn("locked_out_user", "secret_sauce");
        }

        public async Task LogInAsProblemUser()
        {
            await LogIn("problem_user", "secret_sauce");
        }

        public async Task LogInAsPerformanceGlitchUser()
        {
            await LogIn("performance_glitch_user", "secret_sauce");
        }

        public async Task LogInAsErrorUser()
        {
            await LogIn("error_user", "secret_sauce");
        }

        public async Task LogInAsVisualUser()
        {
            await LogIn("visual_user", "secret_sauce");
        }

        public async Task AssertLoginFieldsVisible()
        {
            Assert.True(await UsernameField.IsVisibleAsync(), "Username field not visible");
            Assert.True(await PasswordField.IsVisibleAsync(), "Password field not visible");
            Assert.True(await LoginButton.IsVisibleAsync(), "Login button not visible");
        }

        // Locators

        private ILocator UsernameField => _page.Locator("#user-name");
        private ILocator PasswordField => _page.Locator("#password");
        private ILocator LoginButton => _page.Locator("#login-button");


    }
}
