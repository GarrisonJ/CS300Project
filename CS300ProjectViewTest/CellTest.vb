Imports System.Drawing

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports WindowsApplication1


'''<summary>
'''This is a test class for CellTest and is intended
'''to contain all CellTest Unit Tests
'''</summary>
<TestClass()> _
Public Class CellTest


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
            testContextInstance = value
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
    '''A test for Cell Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub CellConstructorTest()
        Dim target As Cell = New Cell()
        Assert.IsNotNull(target)
    End Sub

    '''<summary>
    '''A test for Clone
    '''</summary>
    <TestMethod()> _
    Public Sub CloneTest()
        Dim target As Cell = New Cell()
        target.set_side_length(3)
        target.Set_cell_point(3, 5)
        target.Set_cell_color(Color.Red)
        Dim expected As Cell = Nothing
        expected = target.Clone()
        Dim ta As PrivateObject = New PrivateObject(target)
        Dim ex As PrivateObject = New PrivateObject(expected)
        Assert.AreEqual(ta.GetField("Cell_color"), ex.GetField("Cell_color"))
        Assert.AreEqual(ta.GetField("Cell_Brush"), ex.GetField("Cell_Brush"))
        Assert.AreEqual(ta.GetField("SideLength"), ex.GetField("SideLength"))
        Assert.AreEqual(ta.GetField("Location"), ex.GetField("Location"))
    End Sub

    '''<summary>
    '''A test for Set_cell_point and get_location
    '''</summary>
    <TestMethod()> _
    Public Sub Set_cell_pointTest()
        Dim target As Cell = New Cell()
        Dim x_placement As Integer = 10
        Dim y_placement As Integer = 10

        target.Set_cell_point(x_placement, y_placement)

        Dim ExpectedPoint As Point = target.get_location()
        Assert.AreEqual(ExpectedPoint.X, x_placement)
        Assert.AreEqual(ExpectedPoint.Y, y_placement)
    End Sub
End Class
