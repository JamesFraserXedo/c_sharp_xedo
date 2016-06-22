using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers.Suits
{
    public class SuitChooser : ChooserBase
    {
        public SuitChooser(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<Suit> Suits
        {
            get {
                var suitElements = Container.FindElements(Locators.Suits);
                var suits = new List<Suit>();

                foreach(IWebElement element in suitElements)
                {
                    suits.Add(new Suit(TestSettings, element));
                }
                return suits.AsReadOnly();
            }
        }

        public Suit SelectedSuit
        {
            get {
                if (!Container.FindElements(Suit.Locators.SelectedWrapper).Any()) {
                    return null;
                }
                var suits = Suits;
                foreach(Suit suit in suits)
                {
                    if (suit.Selected) {
                        return suit;
                    }
                }
                return null;
            }
        }

        public void SelectSuitByName(string name)
        {
            if (SelectedSuit.Name == name)
            {
                return;
            }

            var suits = Suits;
            foreach (Suit suit in suits)
            {
                if (suit.Name == name)
                {
                    suit.Select();
                    return;
                }
            }
        }

        public ReadOnlyCollection<Suit> GetSuitsWithNameContaining(string search)
        {
            search = search.ToLower();
            var suits = Suits;
            var matchingSuits = new List<Suit>();
            foreach (Suit suit in suits)
            {
                if (suit.Name.ToLower().Contains(search))
                {
                    matchingSuits.Add(suit);
                }
            }
            return matchingSuits.AsReadOnly();
        }

        public new class Locators : ChooserBase.Locators
        {
            public static By Suits = By.XPath("//*[@class='item suit']");
        }
    }
}
