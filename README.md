Strategy:
All tests are run in all three browsers when on git. 
D:\Code\SwagLabs\SwagLabsDemo\.github\workflows\playwright-tests.yml
      strategy:
        matrix:
          browser: [chromium, firefox, webkit] 

For debugging, locally the browser and headless mode can be changed on each test via:

            var browserAndPage = await PlaywrightHelper.CreateBrowserAndPageAsync(
                headless: true,
                browserNameOverride: "chromium");







Buying the shirt test. 
D:\Code\SwagLabs\SwagLabsDemo\Tests\BuyingTshirt.cs

// 1. Go to website and log in
// 2. Add T-shirt to cart and verify cart count
// 3. Proceed to checkout and fill info
// 4. Verify item in checkout overview
// 5. Finish checkout and verify confirmation


