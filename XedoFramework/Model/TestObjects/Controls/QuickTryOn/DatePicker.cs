﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.QuickTryOn
{
    public class DatePicker : ControlBase
    {
        private IWebElement Container;

        public DatePicker(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            Container = container;
        }
        
        public IWebElement Body
        {
            get { return Driver.FindElement(Container, Locators.Body); }
        }

        public void SelectDate(string date)
        {
            GoToMonth(int.Parse(date.Split('-')[1])+1);
            GoToYear(date.Split('-')[0]);
            Driver.FindElement(Container, Locators.FindDate(date)).Click();
        }

        public void SelectDate(int day, int month, int year)
        {
            GoToMonth(month);
            GoToYear(year.ToString());

            Driver.FindElement(Container, Locators.FindDate(day, month, year)).Click();
        }

        public bool DateActive(int day, int month, int year)
        {
            var dateElement = Driver.FindElement(Container, Locators.FindDate(day, month, year));
            return dateElement.GetAttribute("class").ToLower().Contains("dw-cal-day-v");
        }

        public string SelectedDate
        {
            get { return Driver.FindElement(Container, Locators.SelectedDate).GetAttribute("data-full"); }
        }

        //Note, case-sensitive and full month required (i.e. "January" - instead of "Jan" or "january")
        public void GoToMonth(string month)
        {
            Driver.FindElement(Container, Locators.MonthPicker).Click();
            Thread.Sleep(250);
            Body.FindElement(By.XPath(string.Format("//div[@aria-label='{0}']/div/div", month))).Click();
            Thread.Sleep(250);
        }

        public void GoToMonth(int month)
        {
            Driver.FindElement(Container, Locators.MonthPicker).Click();
            Thread.Sleep(250);
            Body.FindElement(By.XPath(string.Format("//div[@data-val='{0}']/div/div", month-1))).Click();
            Thread.Sleep(250);
        }

        public void GoToYear(string year)
        {
            Driver.FindElement(Container, Locators.YearPicker).Click();
            Thread.Sleep(250);
            Body.FindElement(By.XPath(string.Format("//div[@data-val='{0}']/div/div", year))).Click();
            Thread.Sleep(250);
        }

        public string SelectFirstAvailableDate()
        {
            return SelectAvailableDate(0);
        }

        public string SelectAvailableDate(int index)
        {
            var element = Driver.FindElements(Locators.ValidDates)[index];
            var date = element.GetAttribute("data-full");
            SelectDate(date);
            return date;
        }

        public class Locators {
            public static By Body = By.XPath("//div[@class='dw-cal-body']");
            public static By MonthPicker = By.XPath("//span[@class='dw-cal-month']");
            public static By YearPicker = By.XPath("//span[@class='dw-cal-year']");
            public static By SelectedDate = By.XPath("//*[@aria-selected='true']");
            public static By ValidDates = By.XPath("//*[contains(@class, 'dw-cal-day-v')]");

            public static By FindDate(int day, int month, int year)
            {
                return By.XPath(
                    string.Format("//div[(@data-full='{0}-{1}-{2}') and (not(contains(@class, 'dw-cal-day-diff')))]",
                        year, month - 1, day));
            }
            public static By FindDate(string yyyymmdd)
            {
                return By.XPath(
                    string.Format("//div[(@data-full='{0}') and (not(contains(@class, 'dw-cal-day-diff')))]",
                        yyyymmdd));
            }
        }
    }
}
