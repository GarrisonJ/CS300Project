Imports System.Drawing

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports WindowsApplication1



'''<summary>
'''This is a test class for Planet_stateTest and is intended
'''to contain all Planet_stateTest Unit Tests
'''</summary>
<TestClass()> _
Public Class Planet_stateTest


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
    '''A test for Planet_state Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub Planet_stateConstructorTest()
        Dim initial_planet_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_x As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_y As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim target As Planet_state = New Planet_state(initial_planet_state, planet_pixel_size_x, planet_pixel_size_y)
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub

    '''<summary>
    '''A test for Display_current_state
    '''</summary>
    <TestMethod()> _
    Public Sub Display_current_stateTest()
        Dim initial_planet_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_x As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_y As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim target As Planet_state = New Planet_state(initial_planet_state, planet_pixel_size_x, planet_pixel_size_y) ' TODO: Initialize to an appropriate value
        Dim graphic_to_display_graph As Graphics = Nothing ' TODO: Initialize to an appropriate value
        Dim graphic_to_display_graphExpected As Graphics = Nothing ' TODO: Initialize to an appropriate value
        Dim rectange_window As Rectangle = New Rectangle() ' TODO: Initialize to an appropriate value
        Dim rectange_windowExpected As Rectangle = New Rectangle() ' TODO: Initialize to an appropriate value
        target.Display_current_state(graphic_to_display_graph, rectange_window)
        Assert.AreEqual(graphic_to_display_graphExpected, graphic_to_display_graph)
        Assert.AreEqual(rectange_windowExpected, rectange_window)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Display_initial_state
    '''</summary>
    <TestMethod()> _
    Public Sub Display_initial_stateTest()
        Dim initial_planet_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_x As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_y As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim target As Planet_state = New Planet_state(initial_planet_state, planet_pixel_size_x, planet_pixel_size_y) ' TODO: Initialize to an appropriate value
        Dim graphic_to_display_graph As Graphics = Nothing ' TODO: Initialize to an appropriate value
        Dim graphic_to_display_graphExpected As Graphics = Nothing ' TODO: Initialize to an appropriate value
        Dim rectange_window As Rectangle = New Rectangle() ' TODO: Initialize to an appropriate value
        Dim rectange_windowExpected As Rectangle = New Rectangle() ' TODO: Initialize to an appropriate value
        target.Display_initial_state(graphic_to_display_graph, rectange_window)
        Assert.AreEqual(graphic_to_display_graphExpected, graphic_to_display_graph)
        Assert.AreEqual(rectange_windowExpected, rectange_window)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for decrement_number_of_mines
    '''</summary>
    <TestMethod()> _
    Public Sub decrement_number_of_minesTest()
        Dim initial_planet_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_x As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_y As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim target As Planet_state = New Planet_state(initial_planet_state, planet_pixel_size_x, planet_pixel_size_y) ' TODO: Initialize to an appropriate value
        target.decrement_number_of_mines()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for increment_number_of_mines
    '''</summary>
    <TestMethod()> _
    Public Sub increment_number_of_minesTest()
        Dim initial_planet_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_x As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_y As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim target As Planet_state = New Planet_state(initial_planet_state, planet_pixel_size_x, planet_pixel_size_y) ' TODO: Initialize to an appropriate value
        target.increment_number_of_mines()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for location_of_mines_as_a_string
    '''</summary>
    <TestMethod()> _
    Public Sub location_of_mines_as_a_stringTest()
        Dim initial_planet_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_x As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_y As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim target As Planet_state = New Planet_state(initial_planet_state, planet_pixel_size_x, planet_pixel_size_y) ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = target.location_of_mines_as_a_string
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for update_state
    '''</summary>
    <TestMethod()> _
    Public Sub update_stateTest()
        Dim initial_planet_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_x As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim planet_pixel_size_y As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim target As Planet_state = New Planet_state(initial_planet_state, planet_pixel_size_x, planet_pixel_size_y) ' TODO: Initialize to an appropriate value
        Dim new_state As State = New State() ' TODO: Initialize to an appropriate value
        Dim new_stateExpected As State = New State() ' TODO: Initialize to an appropriate value
        target.update_state(new_state)
        Assert.AreEqual(new_stateExpected, new_state)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
End Class
