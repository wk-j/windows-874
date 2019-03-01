using System;
using System.IO;
using System.Text;
using Xunit;

namespace Windows874.Tests {
    public class UnitTest1 {
        [Fact]
        public void Test4() {
            Windows874.Register();
            var xml = File.ReadAllText("Resource/1234.xml", Encoding.GetEncoding("windows-874"));
            Assert.Contains("คุณ วิไลวรรณ", xml);
        }
    }
}
