using System;
using Selenium.core.browsers;

namespace Selenium.pages
{
    public class HomePage
    {
        private readonly IBrowser _browser;

        public HomePage(IBrowser browser)
        {
            _browser = browser;
        }

        public RegisterPage Register()
        {
            Console.WriteLine("Navegando para a página de registro");
            _browser.Page.GoToUrl("http://www.google.com");
            return new RegisterPage(_browser);
        }

        public RegisterPage OpenYahooPage()
        {
            Console.WriteLine("Navegando para a página do Yahoo");
            _browser.Page.GoToUrl("http://www.yahoo.com");
            return new RegisterPage(_browser);
        }

        public RegisterPage OpenGooglePage()
        {
            Console.WriteLine("Navegando para a página do Google");
            _browser.Page.GoToUrl("http://www.google.com");
            return new RegisterPage(_browser);
        }

        public RegisterPage OpenGithubPage()
        {
            Console.WriteLine("Navegando para a página do Github");
            _browser.Page.GoToUrl("http://www.github.com");
            return new RegisterPage(_browser);
        }
    }
}