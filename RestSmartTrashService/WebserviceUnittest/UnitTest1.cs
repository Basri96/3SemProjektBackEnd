using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSmartTrashService.Controllers;
using RestSmartTrashService.Model;

namespace WebserviceUnittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WeightReaderTestDag()
        {
            // arrange
            IList<weight> weightListe = RestSmartTrashService.Controllers.weightController.GetWeightAsync(1).Result;
            
            // act
            int length = weightListe.Count;
            // assert

            Assert.AreEqual(length, 1);
            

        }
        
        [TestMethod]
        public void WeightReaderTestUge()
        {
            // arrange
            IList<weight> weightListe = RestSmartTrashService.Controllers.weightController.GetWeightAsync(2).Result;

            // act
            int length = weightListe.Count;
            // assert

            Assert.AreEqual(length, 7);


        }
        [TestMethod]
        public void WeightReaderTestMåned()
        {
            // arrange
            IList<weight> weightListe = RestSmartTrashService.Controllers.weightController.GetWeightAsync(3).Result;

            // act
            int length = weightListe.Count;
            // assert

            Assert.AreEqual(length, 30);


        }

        [TestMethod]
        public void WeightReaderTestÅr()
        {
            // arrange
            IList<weight> weightListe = RestSmartTrashService.Controllers.weightController.GetWeightAsync(4).Result;

            // act
            int length = weightListe.Count;
            // assert

            Assert.AreEqual(length, 365);


        }

        [TestMethod]
        public void WeightReaderTestForgåendeUge()
        {
            // arrange
            IList<weight> forgåendeUge = RestSmartTrashService.Controllers.weightController.GetWeightAsync(5).Result;
            IList<weight> nuværendeUge = RestSmartTrashService.Controllers.weightController.GetWeightAsync(2).Result;
            
            // act
            weight dage1 = nuværendeUge[0];
            weight forDag1 = forgåendeUge[0];
            
            // assert
            Assert.AreEqual(dage1.id, (forDag1.id + 13));
           


        }
    }
}
