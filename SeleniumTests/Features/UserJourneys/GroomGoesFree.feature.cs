﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SeleniumTests.Features.UserJourneys
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Groom Goes Free offer for 5 paid hires", SourceFile="Features\\UserJourneys\\GroomGoesFree.feature", SourceLine=0)]
    public partial class GroomGoesFreeOfferFor5PaidHiresFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GroomGoesFree.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Groom Goes Free offer for 5 paid hires", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void CheckThatTheGroomPaysNormalPriceForLessThan6Hires(string number, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that the groom pays normal price for less than 6 hires", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("I am on the Xedo OutfitBuilder page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("I am logged on to the site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
 testRunner.And("I have added an outfit to my order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("I have chosen a wedding date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.When(string.Format("I add {0} additional party members", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.And("I continue to payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I complete billing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("the groom should be shown the quoted price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that the groom pays normal price for less than 6 hires, 0", SourceLine=14)]
        public virtual void CheckThatTheGroomPaysNormalPriceForLessThan6Hires_0()
        {
            this.CheckThatTheGroomPaysNormalPriceForLessThan6Hires("0", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that the groom pays normal price for less than 6 hires, 1", SourceLine=14)]
        public virtual void CheckThatTheGroomPaysNormalPriceForLessThan6Hires_1()
        {
            this.CheckThatTheGroomPaysNormalPriceForLessThan6Hires("1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that the groom pays normal price for less than 6 hires, 2", SourceLine=14)]
        public virtual void CheckThatTheGroomPaysNormalPriceForLessThan6Hires_2()
        {
            this.CheckThatTheGroomPaysNormalPriceForLessThan6Hires("2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that the groom pays normal price for less than 6 hires, 3", SourceLine=14)]
        public virtual void CheckThatTheGroomPaysNormalPriceForLessThan6Hires_3()
        {
            this.CheckThatTheGroomPaysNormalPriceForLessThan6Hires("3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that the groom pays normal price for less than 6 hires, 4", SourceLine=14)]
        public virtual void CheckThatTheGroomPaysNormalPriceForLessThan6Hires_4()
        {
            this.CheckThatTheGroomPaysNormalPriceForLessThan6Hires("4", ((string[])(null)));
#line hidden
        }
        
        public virtual void CheckThatTheGroomPaysNothingFor6OrMoreHires(string number, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that the groom pays nothing for 6 or more hires", exampleTags);
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("I am on the Xedo OutfitBuilder page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.And("I am logged on to the site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("I have added an outfit to my order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I have chosen a wedding date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When(string.Format("I add {0} additional party members", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.And("I continue to payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("I complete billing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Then("the groom should get his outfit for free", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that the groom pays nothing for 6 or more hires, 5", SourceLine=32)]
        public virtual void CheckThatTheGroomPaysNothingFor6OrMoreHires_5()
        {
            this.CheckThatTheGroomPaysNothingFor6OrMoreHires("5", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that the groom pays nothing for 6 or more hires, 6", SourceLine=32)]
        public virtual void CheckThatTheGroomPaysNothingFor6OrMoreHires_6()
        {
            this.CheckThatTheGroomPaysNothingFor6OrMoreHires("6", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that the groom pays nothing for 6 or more hires, 7", SourceLine=32)]
        public virtual void CheckThatTheGroomPaysNothingFor6OrMoreHires_7()
        {
            this.CheckThatTheGroomPaysNothingFor6OrMoreHires("7", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that the groom pays nothing for 6 or more hires, 8", SourceLine=32)]
        public virtual void CheckThatTheGroomPaysNothingFor6OrMoreHires_8()
        {
            this.CheckThatTheGroomPaysNothingFor6OrMoreHires("8", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that the groom pays nothing for 6 or more hires, 9", SourceLine=32)]
        public virtual void CheckThatTheGroomPaysNothingFor6OrMoreHires_9()
        {
            this.CheckThatTheGroomPaysNothingFor6OrMoreHires("9", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check that the groom pays nothing for 6 or more hires, 10", SourceLine=32)]
        public virtual void CheckThatTheGroomPaysNothingFor6OrMoreHires_10()
        {
            this.CheckThatTheGroomPaysNothingFor6OrMoreHires("10", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Groom Goes Free offer for 5 paid hires")]
    public partial class GroomGoesFreeOfferFor5PaidHiresFeature_NUnit
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GroomGoesFree.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Groom Goes Free offer for 5 paid hires", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check that the groom pays normal price for less than 6 hires")]
        [NUnit.Framework.TestCaseAttribute("0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("1", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", new string[0])]
        [NUnit.Framework.TestCaseAttribute("3", new string[0])]
        [NUnit.Framework.TestCaseAttribute("4", new string[0])]
        public virtual void CheckThatTheGroomPaysNormalPriceForLessThan6Hires(string number, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that the groom pays normal price for less than 6 hires", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("I am on the Xedo OutfitBuilder page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("I am logged on to the site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
 testRunner.And("I have added an outfit to my order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("I have chosen a wedding date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.When(string.Format("I add {0} additional party members", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.And("I continue to payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I complete billing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("the groom should be shown the quoted price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check that the groom pays nothing for 6 or more hires")]
        [NUnit.Framework.TestCaseAttribute("5", new string[0])]
        [NUnit.Framework.TestCaseAttribute("6", new string[0])]
        [NUnit.Framework.TestCaseAttribute("7", new string[0])]
        [NUnit.Framework.TestCaseAttribute("8", new string[0])]
        [NUnit.Framework.TestCaseAttribute("9", new string[0])]
        [NUnit.Framework.TestCaseAttribute("10", new string[0])]
        public virtual void CheckThatTheGroomPaysNothingFor6OrMoreHires(string number, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that the groom pays nothing for 6 or more hires", exampleTags);
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("I am on the Xedo OutfitBuilder page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.And("I am logged on to the site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("I have added an outfit to my order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I have chosen a wedding date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When(string.Format("I add {0} additional party members", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.And("I continue to payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("I complete billing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Then("the groom should get his outfit for free", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion