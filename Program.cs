using Microsoft.Playwright;

var playwright = await Playwright.CreateAsync();
var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
var driver = await browser.NewPageAsync();

var ya = driver.Ya(options => options.WithBaseUrl("https://github.com"));

ya.SearchPage.Open(query: "yapoml")
    .Repositories[r => r.Name == "yapoml/yapoml"]
    .Name.Click();

ya.RepositoryPage.Star.Click();