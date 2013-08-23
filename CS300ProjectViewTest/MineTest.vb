Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports WindowsApplication1



'''<summary>
'''This is a test class for MineTest and is intended
'''to contain all MineTest Unit Tests
'''</summary>
<TestClass()> _
Public Class MineTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''A test for Mine Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub MineConstructorTest()
        Dim target As Mine = New Mine()
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub

    '''<summary>
    '''A test for get_toxicity
    '''</summary>
    <TestMethod()> _
    Public Sub get_toxicityTest()
        Dim target As Mine = New Mine() ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        actual = target.get_toxicity
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for set_toxicity
    '''</summary>
    <TestMethod()> _
    Public Sub set_toxicityTest()
        Dim target As Mine = New Mine() ' TODO: Initialize to an appropriate value
        Dim toxicity_level As Double = 0.0! ' TODO: Initialize to an appropriate value
        target.set_toxicity(toxicity_level)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
End Class
