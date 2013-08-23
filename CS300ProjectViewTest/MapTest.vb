Imports System.Collections.Generic

Imports System.Drawing

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports WindowsApplication1



'''<summary>
'''This is a test class for MapTest and is intended
'''to contain all MapTest Unit Tests
'''</summary>
<TestClass()> _
Public Class MapTest


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
    '''A test for Map Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub MapConstructorTest()
        Dim Cell_Map_X_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_X_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim initial_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim initial_stateExpected As State = New State() ' TODO: Initialize to an appropriate value
        Dim target As Map = New Map(Cell_Map_X_dim, Cell_Map_Y_dim, initial_state)
        Assert.AreEqual(Cell_Map_X_dimExpected, Cell_Map_X_dim)
        Assert.AreEqual(Cell_Map_Y_dimExpected, Cell_Map_Y_dim)
        Assert.AreEqual(initial_stateExpected, initial_state)
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub

    '''<summary>
    '''A test for Distance
    '''</summary>
    <TestMethod(), _
     DeploymentItem("cs_300_ampla_project.exe")> _
    Public Sub DistanceTest()
        Dim param0 As PrivateObject = Nothing ' TODO: Initialize to an appropriate value
        Dim target As Map_Accessor = New Map_Accessor(param0) ' TODO: Initialize to an appropriate value
        Dim a As Point = New Point() ' TODO: Initialize to an appropriate value
        Dim aExpected As Point = New Point() ' TODO: Initialize to an appropriate value
        Dim b As Point = New Point() ' TODO: Initialize to an appropriate value
        Dim bExpected As Point = New Point() ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        actual = target.Distance(a, b)
        Assert.AreEqual(aExpected, a)
        Assert.AreEqual(bExpected, b)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Draw_map
    '''</summary>
    <TestMethod()> _
    Public Sub Draw_mapTest()
        Dim Cell_Map_X_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_X_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim initial_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim initial_stateExpected As State = New State() ' TODO: Initialize to an appropriate value
        Dim target As Map = New Map(Cell_Map_X_dim, Cell_Map_Y_dim, initial_state) ' TODO: Initialize to an appropriate value
        Dim graphic_to_display_graph As Graphics = Nothing ' TODO: Initialize to an appropriate value
        Dim graphic_to_display_graphExpected As Graphics = Nothing ' TODO: Initialize to an appropriate value
        Dim rectange_window As Rectangle = New Rectangle() ' TODO: Initialize to an appropriate value
        Dim rectange_windowExpected As Rectangle = New Rectangle() ' TODO: Initialize to an appropriate value
        target.Draw_map(graphic_to_display_graph, rectange_window)
        Assert.AreEqual(Cell_Map_X_dimExpected, Cell_Map_X_dim)
        Assert.AreEqual(Cell_Map_Y_dimExpected, Cell_Map_Y_dim)
        Assert.AreEqual(initial_stateExpected, initial_state)
        Assert.AreEqual(graphic_to_display_graphExpected, graphic_to_display_graph)
        Assert.AreEqual(rectange_windowExpected, rectange_window)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for New_map_state
    '''</summary>
    <TestMethod()> _
    Public Sub New_map_stateTest()
        Dim Cell_Map_X_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_X_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim initial_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim initial_stateExpected As State = New State() ' TODO: Initialize to an appropriate value
        Dim target As Map = New Map(Cell_Map_X_dim, Cell_Map_Y_dim, initial_state) ' TODO: Initialize to an appropriate value
        Dim new_map_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim new_map_stateExpected As State = New State() ' TODO: Initialize to an appropriate value
        target.New_map_state(new_map_state)
        Assert.AreEqual(Cell_Map_X_dimExpected, Cell_Map_X_dim)
        Assert.AreEqual(Cell_Map_Y_dimExpected, Cell_Map_Y_dim)
        Assert.AreEqual(initial_stateExpected, initial_state)
        Assert.AreEqual(new_map_stateExpected, new_map_state)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Update_map
    '''</summary>
    <TestMethod()> _
    Public Sub Update_mapTest()
        Dim Cell_Map_X_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_X_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim initial_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim initial_stateExpected As State = New State() ' TODO: Initialize to an appropriate value
        Dim target As Map = New Map(Cell_Map_X_dim, Cell_Map_Y_dim, initial_state) ' TODO: Initialize to an appropriate value
        target.Update_map()
        Assert.AreEqual(Cell_Map_X_dimExpected, Cell_Map_X_dim)
        Assert.AreEqual(Cell_Map_Y_dimExpected, Cell_Map_Y_dim)
        Assert.AreEqual(initial_stateExpected, initial_state)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for add_mine_to_map
    '''</summary>
    <TestMethod()> _
    Public Sub add_mine_to_mapTest()
        Dim Cell_Map_X_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_X_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim initial_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim initial_stateExpected As State = New State() ' TODO: Initialize to an appropriate value
        Dim target As Map = New Map(Cell_Map_X_dim, Cell_Map_Y_dim, initial_state) ' TODO: Initialize to an appropriate value
        Dim location_of_new_mine As Point = New Point() ' TODO: Initialize to an appropriate value
        Dim location_of_new_mineExpected As Point = New Point() ' TODO: Initialize to an appropriate value
        target.add_mine_to_map(location_of_new_mine)
        Assert.AreEqual(Cell_Map_X_dimExpected, Cell_Map_X_dim)
        Assert.AreEqual(Cell_Map_Y_dimExpected, Cell_Map_Y_dim)
        Assert.AreEqual(initial_stateExpected, initial_state)
        Assert.AreEqual(location_of_new_mineExpected, location_of_new_mine)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for decrement_number_of_mines
    '''</summary>
    <TestMethod()> _
    Public Sub decrement_number_of_minesTest()
        Dim Cell_Map_X_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_X_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim initial_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim initial_stateExpected As State = New State() ' TODO: Initialize to an appropriate value
        Dim target As Map = New Map(Cell_Map_X_dim, Cell_Map_Y_dim, initial_state) ' TODO: Initialize to an appropriate value
        target.decrement_number_of_mines()
        Assert.AreEqual(Cell_Map_X_dimExpected, Cell_Map_X_dim)
        Assert.AreEqual(Cell_Map_Y_dimExpected, Cell_Map_Y_dim)
        Assert.AreEqual(initial_stateExpected, initial_state)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for return_list_of_mines
    '''</summary>
    <TestMethod()> _
    Public Sub return_list_of_minesTest()
        Dim Cell_Map_X_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_X_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dim As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Cell_Map_Y_dimExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim initial_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim initial_stateExpected As State = New State() ' TODO: Initialize to an appropriate value
        Dim target As Map = New Map(Cell_Map_X_dim, Cell_Map_Y_dim, initial_state) ' TODO: Initialize to an appropriate value
        Dim expected As List(Of Mine) = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As List(Of Mine)
        actual = target.return_list_of_mines
        Assert.AreEqual(Cell_Map_X_dimExpected, Cell_Map_X_dim)
        Assert.AreEqual(Cell_Map_Y_dimExpected, Cell_Map_Y_dim)
        Assert.AreEqual(initial_stateExpected, initial_state)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
