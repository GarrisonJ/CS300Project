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
    '''A test for Planet_state Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub Planet_stateConstructorTest()
        Dim initial_planet_state As State = New State()
        Dim planet_pixel_size_x As Integer = 0
        Dim planet_pixel_size_y As Integer = 0
        Dim target As Planet_state = New Planet_state(initial_planet_state, planet_pixel_size_x, planet_pixel_size_y)
        Assert.IsNotNull(target)
    End Sub

    '''<summary>
    '''A test for increment_number_of_mines, decrement_number_of_mines, and location_of_mines_as_a_string
    '''</summary>
    <TestMethod()> _
    Public Sub Planet_state_minesTest()
        Dim initial_planet_state As State = New State()
        Dim planet_pixel_size_x As Integer = 100
        Dim planet_pixel_size_y As Integer = 100
        Dim target As Planet_state = New Planet_state(initial_planet_state, planet_pixel_size_x, planet_pixel_size_y)
        Dim add_mine_at_this_point As Point = New Point(20, 20)
        Dim Expected_string As String = New String("20,20,")

        target.increment_number_of_mines_on_current_map(add_mine_at_this_point)                ' Add mine at point.

        Assert.AreEqual(Expected_string, target.location_of_current_mines_as_a_string)  ' Assert mine exist in list, and is represented as a string properly.

        target.decrement_number_of_mines()                                      ' Decrement number of mines.

        Assert.AreEqual("", target.location_of_current_mines_as_a_string)               ' Assert string is empty.

        target.increment_number_of_mines_on_current_map()                                      ' Create random mine.

        target.decrement_number_of_mines()                                      ' Decrement number of mines.

        Assert.AreEqual("", target.location_of_current_mines_as_a_string)               ' Assert string is empty.

    End Sub
End Class
