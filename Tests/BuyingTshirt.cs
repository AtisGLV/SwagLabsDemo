using Microsoft.Playwright;
using SwagLabsDemo.Pages;
using SwagLabsDemo.Tests.Helpers;
using Xunit;

namespace SwagLabsDemo
{
    public class SimpleTest 
    {
        [Fact]
        public async Task Shirtbuy()
        {
            var browserAndPage = await PlaywrightHelper.CreateBrowserAndPageAsync(
                headless: true,
                browserNameOverride: "chromium");

            var browser = browserAndPage.Browser;
            var page = browserAndPage.Page;

            await using (browser)
            {
                var loginPage = new LoginPage(page);
                var homePage = new HomePage(page);
                var itemPage = new ItemPage(page);
                var cartPage = new CartPage(page);
                var checkoutPage = new CheckoutPage(page);
                var checkoutOverviewPage = new CheckoutOverviewPage(page);
                var checkoutCompletePage = new CheckoutCompletePage(page);

                // Navigate to website and log in
                await loginPage.GoToWebsite();
                await loginPage.LogInAsStandardUser();
                Assert.Equal("https://www.saucedemo.com/inventory.html", page.Url);

                // Add item to cart
                await homePage.GoToItemTshirt();
                await itemPage.AddToCart();
                var cartCount = await homePage.GetCartCount();
                Assert.Equal(1, cartCount);

                // Checkout flow
                await Flows.CheckoutFlow(homePage, cartPage, checkoutPage);

                // Assert correct item
                var itemName = await checkoutOverviewPage.GetItemName();
                Assert.Equal("Sauce Labs Bolt T-Shirt", itemName);

                await checkoutOverviewPage.FinishCheckout();

                // Assert final confirmation
                var confirmation = await checkoutCompletePage.GetConfirmationText();
                Assert.Contains("THANK YOU", confirmation.ToUpperInvariant());
            }
        }
    }
}
