using System.CodeDom.Compiler;
using System.IO;
using System.Text;
using Microsoft.CSharp;
using NMG.Core.Generator;
using NUnit.Framework;

namespace NMG.Tests.Generator
{
    [TestFixture]
    public class CodeGenerationHelperTest
    {
        [Test]
        public void ShouldGenerateField()
        {
            var codeGenerationHelper = new CodeGenerationHelper();
            var codeMemberField = codeGenerationHelper.CreateField(typeof (string), "name");
            var cSharpCodeProvider = new CSharpCodeProvider();
            var stringBuilder = new StringBuilder();
            var codeCompileUnit = codeGenerationHelper.GetCodeCompileUnit("someNamespace", "someType", codeMemberField);
            cSharpCodeProvider.GenerateCodeFromCompileUnit(codeCompileUnit, new StringWriter(stringBuilder), new CodeGeneratorOptions());
            Assert.IsTrue(stringBuilder.ToString().Contains("private string name;"));
        }

        [Test]
        public void ShouldGenerateProperty()
        {
            var codeGenerationHelper = new CodeGenerationHelper();
            var codeMemberField = codeGenerationHelper.CreateProperty(typeof(string), "name");
            var cSharpCodeProvider = new CSharpCodeProvider();
            var stringBuilder = new StringBuilder();
            var codeCompileUnit = codeGenerationHelper.GetCodeCompileUnit("someNamespace", "someType", codeMemberField);
            cSharpCodeProvider.GenerateCodeFromCompileUnit(codeCompileUnit, new StringWriter(stringBuilder), new CodeGeneratorOptions());
            Assert.IsTrue(stringBuilder.ToString().Contains(@"public virtual string name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }"));
        }


        [Test]
        public void ShouldGenerateAutoProperty()
        {
            var codeGenerationHelper = new CodeGenerationHelper();
            var codeMemberField = codeGenerationHelper.CreateProperty(typeof(string), "name");
            var cSharpCodeProvider = new CSharpCodeProvider();
            var stringBuilder = new StringBuilder();
            var codeCompileUnit = codeGenerationHelper.GetCodeCompileUnit("someNamespace", "someType", codeMemberField);
            cSharpCodeProvider.GenerateCodeFromCompileUnit(codeCompileUnit, new StringWriter(stringBuilder), new CodeGeneratorOptions());
            Assert.IsTrue(stringBuilder.ToString().Contains(@"public virtual string name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }"));
        }
    }
}