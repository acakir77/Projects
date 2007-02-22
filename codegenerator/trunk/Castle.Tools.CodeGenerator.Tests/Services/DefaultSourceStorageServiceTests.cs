using System;
using System.Collections.Generic;

using ICSharpCode.NRefactory.Parser;

using Rhino.Mocks;
using NUnit.Framework;

namespace Castle.Tools.CodeGenerator.Services
{
  [TestFixture]
  public class DefaultSourceStorageServiceTests
  {
    #region Member Data
    private MockRepository _mocks;
    private DefaultSourceStorageService _service;
    #endregion

    #region Test Setup and Teardown Methods
    [SetUp]
    public void Setup()
    {
      _mocks = new MockRepository();
      _service = new DefaultSourceStorageService();
    }
    #endregion

    #region Test Methods
    [Test]
    [ExpectedException(typeof(KeyNotFoundException))]
    public void GetParsedSource_NoSource_Throws()
    {
      _service.GetParsedSource("Source.cs");
    }

    [Test]
    public void Add_NewSource_Works()
    {
      _service.Add("Source.cs", _mocks.CreateMock<IParser>());
      Assert.IsNotNull(_service.GetParsedSource("Source.cs"));
    }

    [Test]
    public void Add_TwpSources_Works()
    {
      _service.Add("Source1.cs", _mocks.CreateMock<IParser>());
      _service.Add("Source2.cs", _mocks.CreateMock<IParser>());
      Assert.IsNotNull(_service.GetParsedSource("Source1.cs"));
      Assert.IsNotNull(_service.GetParsedSource("Source2.cs"));
    }

    [Test]
    [ExpectedException(typeof(ArgumentException))]
    public void Add_DuplicateSource_Throws()
    {
      _service.Add("Source.cs", _mocks.CreateMock<IParser>());
      _service.Add("Source.cs", _mocks.CreateMock<IParser>());
    }
    #endregion
  }
}
