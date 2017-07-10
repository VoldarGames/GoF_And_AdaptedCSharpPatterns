using Domain;
using Domain.Enums;
using Domain.Extensions;
using GoF_CSharp.Patterns.Strategy.ActionStrategy;
using GoF_CSharp.Patterns.Strategy.ClassicStrategy;
using GoF_CSharp.Patterns.Strategy.DynamicStrategy;
using GoF_CSharp.Patterns.Strategy.GenericDynamicStrategy;
using GoF_CSharp.Patterns.Strategy.SimpleStrategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoF_CSharp.Patterns.Strategy
{
    [TestClass]
    [TestCategory("Strategy Pattern")]
    public class StrategyTest
    {
        [TestMethod]
        public void ClassicStrategyTest()
        {
            var colorRed = new Color();
            var target = new ColorClassicStrategyContext(new RedColorClassicStrategy(), colorRed);
            target.DefineStrategy();
            Assert.AreEqual(GlobalLocationEnum.RedMeaning.Translate(), colorRed.Meaning);

            var colorGreen = new Color();
            var target2 = new ColorClassicStrategyContext(new GreenColorClassicStrategy(), colorGreen);
            target2.DefineStrategy();
            Assert.AreEqual(GlobalLocationEnum.GreenMeaning.Translate(), colorGreen.Meaning);
        }

        [TestMethod]
        public void SimpleStrategyTest()
        {
            var redColor = new Color()
            {
                Name = GlobalLocationEnum.Red.Translate()
            };

            var blueColor = new Color()
            {
                Name = GlobalLocationEnum.Blue.Translate()
            };

            var greenColor = new Color()
            {
                Name = GlobalLocationEnum.Green.Translate()
            };


            Assert.AreEqual(GlobalLocationEnum.RedMeaning.Translate(), ColorStrategyHandler.Handle(redColor));
            Assert.AreEqual(GlobalLocationEnum.RedMeaning.Translate(), redColor.Meaning);
            Assert.AreEqual(GlobalLocationEnum.BlueMeaning.Translate(), ColorStrategyHandler.Handle(blueColor));
            Assert.AreEqual(GlobalLocationEnum.BlueMeaning.Translate(), blueColor.Meaning);
            Assert.AreEqual(GlobalLocationEnum.GreenMeaning.Translate(), ColorStrategyHandler.Handle(greenColor));
            Assert.AreEqual(GlobalLocationEnum.GreenMeaning.Translate(), greenColor.Meaning);



        }

        [TestMethod]
        public void DynamicStrategyTest()
        {
            var redColor = new Color()
            {
                Name = GlobalLocationEnum.Red.Translate()
            };

            var blueColor = new Color()
            {
                Name = GlobalLocationEnum.Blue.Translate()
            };

            var greenColor = new Color()
            {
                Name = GlobalLocationEnum.Green.Translate()
            };


            Assert.AreEqual(GlobalLocationEnum.RedMeaning.Translate(), ColorDynamicStrategyHandler.Handle(redColor));
            Assert.AreEqual(GlobalLocationEnum.RedMeaning.Translate(), redColor.Meaning);
            Assert.AreEqual(GlobalLocationEnum.BlueMeaning.Translate(), ColorDynamicStrategyHandler.Handle(blueColor));
            Assert.AreEqual(GlobalLocationEnum.BlueMeaning.Translate(), blueColor.Meaning);
            Assert.AreEqual(GlobalLocationEnum.GreenMeaning.Translate(), ColorDynamicStrategyHandler.Handle(greenColor));
            Assert.AreEqual(GlobalLocationEnum.GreenMeaning.Translate(), greenColor.Meaning);



        }

        [TestMethod]
        public void ActionStrategyTest()
        {
            var redColor = new Color()
            {
                Name = GlobalLocationEnum.Red.Translate()
            };

            var blueColor = new Color()
            {
                Name = GlobalLocationEnum.Blue.Translate()
            };

            var greenColor = new Color()
            {
                Name = GlobalLocationEnum.Green.Translate()
            };


            Assert.AreEqual(GlobalLocationEnum.RedMeaning.Translate(), ColorActionStrategyHandler.Handle(redColor));
            Assert.AreEqual(GlobalLocationEnum.RedMeaning.Translate(), redColor.Meaning);
            Assert.AreEqual(GlobalLocationEnum.BlueMeaning.Translate(), ColorActionStrategyHandler.Handle(blueColor));
            Assert.AreEqual(GlobalLocationEnum.BlueMeaning.Translate(), blueColor.Meaning);
            Assert.AreEqual(GlobalLocationEnum.GreenMeaning.Translate(), ColorActionStrategyHandler.Handle(greenColor));
            Assert.AreEqual(GlobalLocationEnum.GreenMeaning.Translate(), greenColor.Meaning);
        }

        [TestMethod]
        public void GenericDynamicLabeledStrategyTest()
        {
            
            var color1 = new Color();
            GenericDynamicLabeledStrategyHandler<Color>.Handle(color1, GlobalLocationEnum.Red.Translate());
            Assert.AreEqual(GlobalLocationEnum.RedMeaning.Translate(), color1.Meaning );

            var color2 = new Color();
            GenericDynamicLabeledStrategyHandler<Color>.Handle(color2,GlobalLocationEnum.Green.Translate());
            Assert.AreEqual(GlobalLocationEnum.GreenMeaning.Translate(),color2.Meaning );

            var color3 = new Color();
            GenericDynamicLabeledStrategyHandler<Color>.Handle(color3,"Doesn't exist label");
            Assert.AreEqual(null,color3.Meaning);

            var bird = new Eagle();
            GenericDynamicLabeledStrategyHandler<Bird>.Handle(bird, GlobalLocationEnum.Bird.Translate());
            Assert.AreEqual(GlobalLocationEnum.FlyPhrase.Translate(), bird.Name);

        }
    }
}
