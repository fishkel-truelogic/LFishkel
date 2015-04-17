using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LFishkel.Data;
using System.Data.Entity;
using System.Linq;

namespace LFishkel.Data.Tests
{
    [TestClass]
    public class DataModelContainerTests
    {
        [TestMethod]
        public void Given_When_Then()
        {
            using (var dbContext = new DbContext("name=lfishkelEntities"))
            {

                SaveSantander(dbContext);
                RemoveSantander(dbContext);
               

            }
        }

       public void SaveSantander(DbContext dbContext) {
            // Arrange
                var dbSet = dbContext.Set<Bank>();

                // Act
                var bank = new Bank();
                bank.Name = "Santander";
                dbSet.Add(bank);
                var result = dbContext.SaveChanges();
                Assert.AreEqual(result, 1);
                

              
       }

       public void RemoveSantander(DbContext dbContext)
       {
           // Arrange
           var santander = dbContext.Set<Bank>()
               .Where(b => b.Name == "Santander")
               // .Include("Account")
               .FirstOrDefault();

           if (santander == null) 
           {
               Assert.IsNotNull(santander);
           } 
           else 
           {
               dbContext.Set<Bank>().Remove(santander);
               var result = dbContext.SaveChanges();
               Assert.AreEqual(result, 1);

           }
                
       }
    }
}
