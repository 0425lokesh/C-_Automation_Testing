using System;
using System.Collections.Generic;
using NUnit.Framework;
using selenium_automation_testing;

public class TestAutomationAnalysis : Basesetup
{
    private const string WikipediaUrl = "https://en.wikipedia.org/wiki/Test_automation";

    [Test]
    public void AnalyzeTDD()
    {
        NavigateToUrl(WikipediaUrl);
        string content = WikipediaPage.ExtractTextContentFromTDD();
        Dictionary<string, int> wordCount = CountUniqueWords(content);
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    private Dictionary<string, int> CountUniqueWords(string content)
    {
        throw new NotImplementedException();
    }

    private void NavigateToUrl(string wikipediaUrl)
    {
        throw new NotImplementedException();
    }
}
