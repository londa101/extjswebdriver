using OpenQA.Selenium;

namespace ExtjsWd.Elements
{
    public class CheckBox : CheckableElement
    {
        public CheckBox(IWebElement element, IWebDriver driver)
            : base(element, driver)
        {
            //The element is the table parent of the input, extjs does not use checkboxes but tables with layout
        }


        protected override IWebElement TheClickableElement
        {
            get { return Element.FindElement(By.CssSelector(".x-form-checkbox")); }

        }
    }
}