using Framework.POM;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Net.NetworkInformation;
using Tests.BaseClasses;

namespace Tests
{
    internal class languagesDemotests : BaseLanguagesDemo
    {
       
        [Test]
        public void ChangeLanguageDropdownTest()
        {

            string ExpectedLanguage = "EN";
            languagesDemo.ClickLanguagesButtonOnHeader();
            languagesDemo.ClickEnglishLanguageButton();// testas failina sitoj vietoj,neranda tokio elemento,
            //todel kad atidaromas sumazintas langas, mano laptopo monitorius nepakankamai didelis,
            //kad pasileistu pilna svetaines versija google chrome narsyklej. Per inspection neradau to elemento sumazinto lango
            //versijoje, sita versija neturi headerio meniu dalyje tokio funkcionalumo kaip kalbos
            //pasirinkimas isskleidziant dropdown funkcija
            string actualLanguage = languagesDemo.GetTheSelectedLanguage();

            Assert.AreEqual(ExpectedLanguage, actualLanguage);  


        }
       




    }
}

