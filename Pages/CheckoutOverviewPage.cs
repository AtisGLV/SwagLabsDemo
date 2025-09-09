using Microsoft.Playwright;

namespace SwagLabsDemo.Pages
{
    public class CheckoutOverviewPage
    {
        private readonly IPage _page;

        public CheckoutOverviewPage(IPage page)
        {
            _page = page;
        }

        public async Task FinishCheckout()
        {
            await FinishButton.ClickAsync();
        }

        public async Task Cancel()
        {
            await CancelButton.ClickAsync();
        }

        public async Task<string> GetItemName()
        {
            return await ItemName.InnerTextAsync();
        }

        // Locators

        private ILocator ItemName => _page.Locator(".inventory_item_name");
        private ILocator ItemPrice => _page.Locator(".inventory_item_price");
        private ILocator FinishButton => _page.Locator("#finish");
        private ILocator CancelButton => _page.Locator("#cancel");
    }
}

