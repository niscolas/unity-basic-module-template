using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace ModuleName.Tests.Runtime
{
    public class RuntimeTestScript
    {
        [Test]
        public void RuntimeTestScriptSimplePasses()
        {
            Assert.IsTrue(true);
        }

        [UnityTest]
        public IEnumerator RuntimeTestScriptWithEnumeratorPasses()
        {
            yield return null;
            Assert.IsTrue(true);
        }
    }
}
