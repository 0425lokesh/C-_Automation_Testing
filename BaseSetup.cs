using NUnit.Framework;
using System;
public static class BaseTest
{
    [OneTimeSetUp]
    public static void OneTimeSetup()
    {
        BrowserManager.LaunchBrowser();
    }

    [OneTimeTearDown]
    public static void OneTimeTearDown()
    {
        BrowserManager.CloseBrowser();
    }
}
