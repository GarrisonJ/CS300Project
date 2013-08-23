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
        Dim Cell_Map_X_dim As Integer = 0
        Dim Cell_Map_Y_dim As Integer = 0
        Dim initial_state As State = New State()
        Dim target As Map = New Map(Cell_Map_X_dim, Cell_Map_Y_dim, initial_state)
        Assert.IsNotNull(target)
    End Sub


    '''<summary>
    '''A test for add_mine_to_map and return_list_of_mines and decrement_number_of_mines
    '''</summary>
    <TestMethod()> _
    Public Sub add_mine_to_mapTest()
        Dim Cell_Map_X_dim As Integer = 20
        Dim Cell_Map_Y_dim As Integer = 20
        Dim initial_state As State = New State()
        Dim target As Map = New Map(Cell_Map_X_dim, Cell_Map_Y_dim, initial_state)
        Dim Expected_mine_location As New Point(5, 5)
        Dim location_of_new_mine As Point = New Point(5, 5)

        target.add_mine_to_map(location_of_new_mine)                                          ' Add mine at possible location

        Assert.AreEqual(Expected_mine_location, target.return_list_of_mines.First.get_location()) ' Assert that it was added to the list of mines

        target.decrement_number_of_mines()                                                    ' Decrement the number of mines

        Assert.AreEqual(target.return_list_of_mines.Count, 0)                                   ' Assert that list is empty

        target.add_mine_to_map(New Point(500, 500))                                           ' Try to add mine at impossible location
        Assert.AreEqual(target.return_list_of_mines.Count, 1)                                   ' Assert list is still empty

    End Sub

End Class
