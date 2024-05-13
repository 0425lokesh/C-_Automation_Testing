using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class WikipediaPage
{
 
    private static By Test = By.XPath("//span[@id='TDD']");

    public static By TDD { get; private set; }
    public string ExtractContent { get; private set; }

    public static string ExtractContentTDD()
    {
        IWebElement sectionElement = BrowserManager.FindElement(TDD);
        return sectionElement.Text;
    }

    private void NavigateToUrl(string wikipediaUrl)
    {
        throw new NotImplementedException();
    }

    private Dictionary<string, int> CountUniqueWords(string content)
    {
        content = content.ToLower();
        content = Regex.Replace(content, @"[\W]", " ");

        string[] words = content.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var wordCount = words.GroupBy(w => w)
                             .ToDictionary(g => g.Key, g => g.Count());

        return wordCount;
    }

    internal static string ExtractTextContentFromTDD()
    {
        throw new NotImplementedException();
    }
}
