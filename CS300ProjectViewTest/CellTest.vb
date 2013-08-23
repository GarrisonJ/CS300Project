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
    '''A test for Cell Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub CellConstructorTest()
        Dim target As Cell = New Cell()
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub

    '''<summary>
    '''A test for Clone
    '''</summary>
    <TestMethod()> _
    Public Sub CloneTest()
        Dim target As Cell = New Cell() ' TODO: Initialize to an appropriate value
        Dim expected As Cell = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Cell
        actual = target.Clone
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Draw_cell
    '''</summary>
    <TestMethod()> _
    Public Sub Draw_cellTest()
        Dim target As Cell = New Cell() ' TODO: Initialize to an appropriate value
        Dim graphic_contex As Graphics = Nothing ' TODO: Initialize to an appropriate value
        Dim graphic_contexExpected As Graphics = Nothing ' TODO: Initialize to an appropriate value
        target.Draw_cell(graphic_contex)
        Assert.AreEqual(graphic_contexExpected, graphic_contex)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Set_cell_color
    '''</summary>
    <TestMethod()> _
    Public Sub Set_cell_colorTest()
        Dim target As Cell = New Cell() ' TODO: Initialize to an appropriate value
        Dim new_cell_color As Color = New Color() ' TODO: Initialize to an appropriate value
        Dim new_cell_colorExpected As Color = New Color() ' TODO: Initialize to an appropriate value
        target.Set_cell_color(new_cell_color)
        Assert.AreEqual(new_cell_colorExpected, new_cell_color)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Set_cell_point
    '''</summary>
    <TestMethod()> _
    Public Sub Set_cell_pointTest()
        Dim target As Cell = New Cell() ' TODO: Initialize to an appropriate value
        Dim x_placement As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim x_placementExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim y_placement As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim y_placementExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        target.Set_cell_point(x_placement, y_placement)
        Assert.AreEqual(x_placementExpected, x_placement)
        Assert.AreEqual(y_placementExpected, y_placement)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for get_location
    '''</summary>
    <TestMethod()> _
    Public Sub get_locationTest()
        Dim target As Cell = New Cell() ' TODO: Initialize to an appropriate value
        Dim expected As Point = New Point() ' TODO: Initialize to an appropriate value
        Dim actual As Point
        actual = target.get_location
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for set_side_length
    '''</summary>
    <TestMethod()> _
    Public Sub set_side_lengthTest()
        Dim target As Cell = New Cell() ' TODO: Initialize to an appropriate value
        Dim new_side_length As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim new_side_lengthExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        target.set_side_length(new_side_length)
        Assert.AreEqual(new_side_lengthExpected, new_side_length)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
End Class
