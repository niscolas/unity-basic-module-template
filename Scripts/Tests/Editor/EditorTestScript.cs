using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace ModuleName.Tests.Editor
{
    public class EditorTestScript
    {
        [Test]
        public void EditorTestScriptSimplePasses()
        {
            Assert.IsTrue(true);
        }

        [UnityTest]
        public IEnumerator EditorTestScriptWithEnumeratorPasses()
        {
            yield return null;
            Assert.IsTrue(true);
        }
    }
}
