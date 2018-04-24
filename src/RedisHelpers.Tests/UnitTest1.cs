using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RedisHelpers.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private RedisHelper _redisHelper = new RedisHelper("192.168.199.146:6379");

        [TestMethod]
        public void Set()
        {
            this._redisHelper.Set("k", "hahaha");
            this._redisHelper.Set("i", "123");
        }

        [TestMethod]
        public void GetString()
        {
            var k = this._redisHelper.Get<string>("k");
            Assert.IsTrue(!string.IsNullOrEmpty(k));
        }

        [TestMethod]
        public void GetInt()
        {
            var i = this._redisHelper.Get<int>("i");
            Assert.IsTrue(i > 0);
        }
    }
}
