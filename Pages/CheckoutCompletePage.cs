using Microsoft.Playwright;

namespace SwagLabsDemo.Pages
{
    public class CheckoutCompletePage
    {
        private readonly IPage _page;

        public CheckoutCompletePage(IPage page)
        {
            _page = page;
        }

                public async Task<string> GetConfirmationText()
        {
            return await ConfirmationHeader.InnerTextAsync();
        }

        // Locators

        private ILocator ConfirmationHeader => _page.Locator(".complete-header");
        private ILocator BackHomeButton => _page.Locator("#back-to-products");


    }
}
