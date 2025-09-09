using Microsoft.Playwright;

namespace SwagLabsDemo.Pages
{
    public class CheckoutPage
    {
        private readonly IPage _page;

        public CheckoutPage(IPage page)
        {
            _page = page;
        }

        public async Task FillCheckoutInfo(string firstName, string lastName, string postalCode)
        {
            await FirstNameField.FillAsync(firstName);
            await LastNameField.FillAsync(lastName);
            await PostalCodeField.FillAsync(postalCode);
        }

        public async Task FillCheckoutWithTestData()
        {
            await FillCheckoutInfo("Lizard", "Wizard", "0-0");
        }

        public async Task Continue()
        {
            await ContinueButton.ClickAsync();
        }

        public async Task Cancel()
        {
            await CancelButton.ClickAsync();
        }

        // Locators
        
        
        private ILocator FirstNameField => _page.Locator("#first-name");
        private ILocator LastNameField => _page.Locator("#last-name");
        private ILocator PostalCodeField => _page.Locator("#postal-code");
        private ILocator ContinueButton => _page.Locator("#continue");
        private ILocator CancelButton => _page.Locator("#cancel");
    }
}
