Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class XtraUserControl1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraUserControl1))
			Me.printBarManager1 = New DevExpress.XtraPrinting.Preview.PrintBarManager()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.previewBar1 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.previewBar2 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.previewBar3 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.printPreviewStaticItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
			Me.printPreviewStaticItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
			Me.printPreviewStaticItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
			Me.printPreviewBarItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem4 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem5 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem6 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem7 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem8 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem9 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem10 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem11 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem12 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem13 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.zoomBarEditItem1 = New DevExpress.XtraPrinting.Preview.ZoomBarEditItem()
			Me.printPreviewRepositoryItemComboBox1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox()
			Me.printPreviewBarItem14 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem15 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem16 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem17 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem18 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem19 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem20 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem21 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem22 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem23 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem24 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewSubItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.printPreviewSubItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.printPreviewSubItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.printPreviewSubItem4 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.printPreviewBarItem25 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem26 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.barToolbarsListItem1 = New DevExpress.XtraBars.BarToolbarsListItem()
			Me.printPreviewBarCheckItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem4 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem5 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem6 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem7 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem8 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem9 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem10 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem11 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem12 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem13 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem14 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem15 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
			CType(Me.printBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.printPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printBarManager1
			' 
			Me.printBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.previewBar1, Me.previewBar2, Me.previewBar3})
			Me.printBarManager1.DockControls.Add(Me.barDockControlTop)
			Me.printBarManager1.DockControls.Add(Me.barDockControlBottom)
			Me.printBarManager1.DockControls.Add(Me.barDockControlLeft)
			Me.printBarManager1.DockControls.Add(Me.barDockControlRight)
			Me.printBarManager1.Form = Me
			Me.printBarManager1.ImageStream = (CType(resources.GetObject("printBarManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.printBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.printPreviewStaticItem1, Me.printPreviewStaticItem2, Me.printPreviewStaticItem3, Me.printPreviewBarItem1, Me.printPreviewBarItem2, Me.printPreviewBarItem3, Me.printPreviewBarItem4, Me.printPreviewBarItem5, Me.printPreviewBarItem6, Me.printPreviewBarItem7, Me.printPreviewBarItem8, Me.printPreviewBarItem9, Me.printPreviewBarItem10, Me.printPreviewBarItem11, Me.printPreviewBarItem12, Me.printPreviewBarItem13, Me.zoomBarEditItem1, Me.printPreviewBarItem14, Me.printPreviewBarItem15, Me.printPreviewBarItem16, Me.printPreviewBarItem17, Me.printPreviewBarItem18, Me.printPreviewBarItem19, Me.printPreviewBarItem20, Me.printPreviewBarItem21, Me.printPreviewBarItem22, Me.printPreviewBarItem23, Me.printPreviewBarItem24, Me.printPreviewSubItem1, Me.printPreviewSubItem2, Me.printPreviewSubItem3, Me.printPreviewSubItem4, Me.printPreviewBarItem25, Me.printPreviewBarItem26, Me.barToolbarsListItem1, Me.printPreviewBarCheckItem1, Me.printPreviewBarCheckItem2, Me.printPreviewBarCheckItem3, Me.printPreviewBarCheckItem4, Me.printPreviewBarCheckItem5, Me.printPreviewBarCheckItem6, Me.printPreviewBarCheckItem7, Me.printPreviewBarCheckItem8, Me.printPreviewBarCheckItem9, Me.printPreviewBarCheckItem10, Me.printPreviewBarCheckItem11, Me.printPreviewBarCheckItem12, Me.printPreviewBarCheckItem13, Me.printPreviewBarCheckItem14, Me.printPreviewBarCheckItem15})
			Me.printBarManager1.MainMenu = Me.previewBar3
			Me.printBarManager1.MaxItemId = 50
			Me.printBarManager1.PreviewBar = Me.previewBar1
			Me.printBarManager1.PrintControl = Me.printControl1
			Me.printBarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.printPreviewRepositoryItemComboBox1})
			Me.printBarManager1.StatusBar = Me.previewBar2
			' 
			' previewBar1
			' 
			Me.previewBar1.BarName = "Toolbar"
			Me.previewBar1.DockCol = 0
			Me.previewBar1.DockRow = 1
			Me.previewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.previewBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem13, True), New DevExpress.XtraBars.LinkPersistInfo(Me.zoomBarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem15, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem19, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem22, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem24, True)})
			Me.previewBar1.Text = "Toolbar"
			' 
			' previewBar2
			' 
			Me.previewBar2.BarName = "Status Bar"
			Me.previewBar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.previewBar2.DockCol = 0
			Me.previewBar2.DockRow = 0
			Me.previewBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.previewBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewStaticItem3)})
			Me.previewBar2.OptionsBar.AllowQuickCustomization = False
			Me.previewBar2.OptionsBar.DrawDragBorder = False
			Me.previewBar2.OptionsBar.UseWholeRow = True
			Me.previewBar2.Text = "Status Bar"
			' 
			' previewBar3
			' 
			Me.previewBar3.BarName = "Main Menu"
			Me.previewBar3.DockCol = 0
			Me.previewBar3.DockRow = 0
			Me.previewBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.previewBar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem3)})
			Me.previewBar3.OptionsBar.MultiLine = True
			Me.previewBar3.OptionsBar.UseWholeRow = True
			Me.previewBar3.Text = "Main Menu"
			' 
			' printPreviewStaticItem1
			' 
			Me.printPreviewStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
			Me.printPreviewStaticItem1.Caption = "Current Page: none"
			Me.printPreviewStaticItem1.Id = 0
			Me.printPreviewStaticItem1.LeftIndent = 1
			Me.printPreviewStaticItem1.Name = "printPreviewStaticItem1"
			Me.printPreviewStaticItem1.RightIndent = 1
			Me.printPreviewStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			Me.printPreviewStaticItem1.Type = "CurrentPageNo"
			Me.printPreviewStaticItem1.Width = 200
			' 
			' printPreviewStaticItem2
			' 
			Me.printPreviewStaticItem2.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
			Me.printPreviewStaticItem2.Caption = "Total Pages: 0"
			Me.printPreviewStaticItem2.Id = 1
			Me.printPreviewStaticItem2.LeftIndent = 1
			Me.printPreviewStaticItem2.Name = "printPreviewStaticItem2"
			Me.printPreviewStaticItem2.RightIndent = 1
			Me.printPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
			Me.printPreviewStaticItem2.Type = "TotalPageNo"
			Me.printPreviewStaticItem2.Width = 200
			' 
			' printPreviewStaticItem3
			' 
			Me.printPreviewStaticItem3.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
			Me.printPreviewStaticItem3.Caption = "Zoom Factor: 100%"
			Me.printPreviewStaticItem3.Id = 2
			Me.printPreviewStaticItem3.LeftIndent = 1
			Me.printPreviewStaticItem3.Name = "printPreviewStaticItem3"
			Me.printPreviewStaticItem3.RightIndent = 1
			Me.printPreviewStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near
			Me.printPreviewStaticItem3.Type = "ZoomFactor"
			Me.printPreviewStaticItem3.Width = 200
			' 
			' printPreviewBarItem1
			' 
			Me.printPreviewBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem1.Caption = "Document Map"
			Me.printPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap
			Me.printPreviewBarItem1.Enabled = False
			Me.printPreviewBarItem1.Hint = "Document Map"
			Me.printPreviewBarItem1.Id = 3
			Me.printPreviewBarItem1.ImageIndex = 19
			Me.printPreviewBarItem1.Name = "printPreviewBarItem1"
			' 
			' printPreviewBarItem2
			' 
			Me.printPreviewBarItem2.Caption = "Search"
			Me.printPreviewBarItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find
			Me.printPreviewBarItem2.Enabled = False
			Me.printPreviewBarItem2.Hint = "Search"
			Me.printPreviewBarItem2.Id = 4
			Me.printPreviewBarItem2.ImageIndex = 20
			Me.printPreviewBarItem2.Name = "printPreviewBarItem2"
			' 
			' printPreviewBarItem3
			' 
			Me.printPreviewBarItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem3.Caption = "Customize"
			Me.printPreviewBarItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize
			Me.printPreviewBarItem3.Enabled = False
			Me.printPreviewBarItem3.Hint = "Customize"
			Me.printPreviewBarItem3.Id = 5
			Me.printPreviewBarItem3.ImageIndex = 14
			Me.printPreviewBarItem3.Name = "printPreviewBarItem3"
			' 
			' printPreviewBarItem4
			' 
			Me.printPreviewBarItem4.Caption = "Open"
			Me.printPreviewBarItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open
			Me.printPreviewBarItem4.Hint = "Open a document"
			Me.printPreviewBarItem4.Id = 6
			Me.printPreviewBarItem4.ImageIndex = 22
			Me.printPreviewBarItem4.Name = "printPreviewBarItem4"
			' 
			' printPreviewBarItem5
			' 
			Me.printPreviewBarItem5.Caption = "Save"
			Me.printPreviewBarItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save
			Me.printPreviewBarItem5.Enabled = False
			Me.printPreviewBarItem5.Hint = "Save the document"
			Me.printPreviewBarItem5.Id = 7
			Me.printPreviewBarItem5.ImageIndex = 23
			Me.printPreviewBarItem5.Name = "printPreviewBarItem5"
			' 
			' printPreviewBarItem6
			' 
			Me.printPreviewBarItem6.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem6.Caption = "&Print..."
			Me.printPreviewBarItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print
			Me.printPreviewBarItem6.Enabled = False
			Me.printPreviewBarItem6.Hint = "Print"
			Me.printPreviewBarItem6.Id = 8
			Me.printPreviewBarItem6.ImageIndex = 0
			Me.printPreviewBarItem6.Name = "printPreviewBarItem6"
			' 
			' printPreviewBarItem7
			' 
			Me.printPreviewBarItem7.Caption = "P&rint"
			Me.printPreviewBarItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect
			Me.printPreviewBarItem7.Enabled = False
			Me.printPreviewBarItem7.Hint = "Quick Print"
			Me.printPreviewBarItem7.Id = 9
			Me.printPreviewBarItem7.ImageIndex = 1
			Me.printPreviewBarItem7.Name = "printPreviewBarItem7"
			' 
			' printPreviewBarItem8
			' 
			Me.printPreviewBarItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem8.Caption = "Page Set&up..."
			Me.printPreviewBarItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup
			Me.printPreviewBarItem8.Enabled = False
			Me.printPreviewBarItem8.Hint = "Page Setup"
			Me.printPreviewBarItem8.Id = 10
			Me.printPreviewBarItem8.ImageIndex = 2
			Me.printPreviewBarItem8.Name = "printPreviewBarItem8"
			' 
			' printPreviewBarItem9
			' 
			Me.printPreviewBarItem9.Caption = "Header And Footer"
			Me.printPreviewBarItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF
			Me.printPreviewBarItem9.Enabled = False
			Me.printPreviewBarItem9.Hint = "Header And Footer"
			Me.printPreviewBarItem9.Id = 11
			Me.printPreviewBarItem9.ImageIndex = 15
			Me.printPreviewBarItem9.Name = "printPreviewBarItem9"
			' 
			' printPreviewBarItem10
			' 
			Me.printPreviewBarItem10.ActAsDropDown = True
			Me.printPreviewBarItem10.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem10.Caption = "Scale"
			Me.printPreviewBarItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale
			Me.printPreviewBarItem10.Enabled = False
			Me.printPreviewBarItem10.Hint = "Scale"
			Me.printPreviewBarItem10.Id = 12
			Me.printPreviewBarItem10.ImageIndex = 24
			Me.printPreviewBarItem10.Name = "printPreviewBarItem10"
			' 
			' printPreviewBarItem11
			' 
			Me.printPreviewBarItem11.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem11.Caption = "Hand Tool"
			Me.printPreviewBarItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool
			Me.printPreviewBarItem11.Enabled = False
			Me.printPreviewBarItem11.Hint = "Hand Tool"
			Me.printPreviewBarItem11.Id = 13
			Me.printPreviewBarItem11.ImageIndex = 16
			Me.printPreviewBarItem11.Name = "printPreviewBarItem11"
			' 
			' printPreviewBarItem12
			' 
			Me.printPreviewBarItem12.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem12.Caption = "Magnifier"
			Me.printPreviewBarItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier
			Me.printPreviewBarItem12.Enabled = False
			Me.printPreviewBarItem12.Hint = "Magnifier"
			Me.printPreviewBarItem12.Id = 14
			Me.printPreviewBarItem12.ImageIndex = 3
			Me.printPreviewBarItem12.Name = "printPreviewBarItem12"
			' 
			' printPreviewBarItem13
			' 
			Me.printPreviewBarItem13.Caption = "Zoom Out"
			Me.printPreviewBarItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut
			Me.printPreviewBarItem13.Enabled = False
			Me.printPreviewBarItem13.Hint = "Zoom Out"
			Me.printPreviewBarItem13.Id = 15
			Me.printPreviewBarItem13.ImageIndex = 5
			Me.printPreviewBarItem13.Name = "printPreviewBarItem13"
			' 
			' zoomBarEditItem1
			' 
			Me.zoomBarEditItem1.Caption = "Zoom"
			Me.zoomBarEditItem1.Edit = Me.printPreviewRepositoryItemComboBox1
			Me.zoomBarEditItem1.EditValue = "100%"
			Me.zoomBarEditItem1.Enabled = False
			Me.zoomBarEditItem1.Hint = "Zoom"
			Me.zoomBarEditItem1.Id = 16
			Me.zoomBarEditItem1.Name = "zoomBarEditItem1"
			Me.zoomBarEditItem1.Width = 70
			' 
			' printPreviewRepositoryItemComboBox1
			' 
			Me.printPreviewRepositoryItemComboBox1.AutoComplete = False
			Me.printPreviewRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.printPreviewRepositoryItemComboBox1.DropDownRows = 11
			Me.printPreviewRepositoryItemComboBox1.Name = "printPreviewRepositoryItemComboBox1"
			' 
			' printPreviewBarItem14
			' 
			Me.printPreviewBarItem14.Caption = "Zoom In"
			Me.printPreviewBarItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn
			Me.printPreviewBarItem14.Enabled = False
			Me.printPreviewBarItem14.Hint = "Zoom In"
			Me.printPreviewBarItem14.Id = 17
			Me.printPreviewBarItem14.ImageIndex = 4
			Me.printPreviewBarItem14.Name = "printPreviewBarItem14"
			' 
			' printPreviewBarItem15
			' 
			Me.printPreviewBarItem15.Caption = "First Page"
			Me.printPreviewBarItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage
			Me.printPreviewBarItem15.Enabled = False
			Me.printPreviewBarItem15.Hint = "First Page"
			Me.printPreviewBarItem15.Id = 18
			Me.printPreviewBarItem15.ImageIndex = 7
			Me.printPreviewBarItem15.Name = "printPreviewBarItem15"
			' 
			' printPreviewBarItem16
			' 
			Me.printPreviewBarItem16.Caption = "Previous Page"
			Me.printPreviewBarItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage
			Me.printPreviewBarItem16.Enabled = False
			Me.printPreviewBarItem16.Hint = "Previous Page"
			Me.printPreviewBarItem16.Id = 19
			Me.printPreviewBarItem16.ImageIndex = 8
			Me.printPreviewBarItem16.Name = "printPreviewBarItem16"
			' 
			' printPreviewBarItem17
			' 
			Me.printPreviewBarItem17.Caption = "Next Page"
			Me.printPreviewBarItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage
			Me.printPreviewBarItem17.Enabled = False
			Me.printPreviewBarItem17.Hint = "Next Page"
			Me.printPreviewBarItem17.Id = 20
			Me.printPreviewBarItem17.ImageIndex = 9
			Me.printPreviewBarItem17.Name = "printPreviewBarItem17"
			' 
			' printPreviewBarItem18
			' 
			Me.printPreviewBarItem18.Caption = "Last Page"
			Me.printPreviewBarItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage
			Me.printPreviewBarItem18.Enabled = False
			Me.printPreviewBarItem18.Hint = "Last Page"
			Me.printPreviewBarItem18.Id = 21
			Me.printPreviewBarItem18.ImageIndex = 10
			Me.printPreviewBarItem18.Name = "printPreviewBarItem18"
			' 
			' printPreviewBarItem19
			' 
			Me.printPreviewBarItem19.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem19.Caption = "Multiple Pages"
			Me.printPreviewBarItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages
			Me.printPreviewBarItem19.Enabled = False
			Me.printPreviewBarItem19.Hint = "Multiple Pages"
			Me.printPreviewBarItem19.Id = 22
			Me.printPreviewBarItem19.ImageIndex = 11
			Me.printPreviewBarItem19.Name = "printPreviewBarItem19"
			' 
			' printPreviewBarItem20
			' 
			Me.printPreviewBarItem20.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem20.Caption = "&Color..."
			Me.printPreviewBarItem20.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground
			Me.printPreviewBarItem20.Enabled = False
			Me.printPreviewBarItem20.Hint = "Background"
			Me.printPreviewBarItem20.Id = 23
			Me.printPreviewBarItem20.ImageIndex = 12
			Me.printPreviewBarItem20.Name = "printPreviewBarItem20"
			' 
			' printPreviewBarItem21
			' 
			Me.printPreviewBarItem21.Caption = "&Watermark..."
			Me.printPreviewBarItem21.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark
			Me.printPreviewBarItem21.Enabled = False
			Me.printPreviewBarItem21.Hint = "Watermark"
			Me.printPreviewBarItem21.Id = 24
			Me.printPreviewBarItem21.ImageIndex = 21
			Me.printPreviewBarItem21.Name = "printPreviewBarItem21"
			' 
			' printPreviewBarItem22
			' 
			Me.printPreviewBarItem22.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem22.Caption = "Export Document..."
			Me.printPreviewBarItem22.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile
			Me.printPreviewBarItem22.Enabled = False
			Me.printPreviewBarItem22.Hint = "Export Document..."
			Me.printPreviewBarItem22.Id = 25
			Me.printPreviewBarItem22.ImageIndex = 18
			Me.printPreviewBarItem22.Name = "printPreviewBarItem22"
			' 
			' printPreviewBarItem23
			' 
			Me.printPreviewBarItem23.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem23.Caption = "Send via E-Mail..."
			Me.printPreviewBarItem23.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile
			Me.printPreviewBarItem23.Enabled = False
			Me.printPreviewBarItem23.Hint = "Send via E-Mail..."
			Me.printPreviewBarItem23.Id = 26
			Me.printPreviewBarItem23.ImageIndex = 17
			Me.printPreviewBarItem23.Name = "printPreviewBarItem23"
			' 
			' printPreviewBarItem24
			' 
			Me.printPreviewBarItem24.Caption = "E&xit"
			Me.printPreviewBarItem24.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview
			Me.printPreviewBarItem24.Hint = "Close Preview"
			Me.printPreviewBarItem24.Id = 27
			Me.printPreviewBarItem24.ImageIndex = 13
			Me.printPreviewBarItem24.Name = "printPreviewBarItem24"
			' 
			' printPreviewSubItem1
			' 
			Me.printPreviewSubItem1.Caption = "&File"
			Me.printPreviewSubItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File
			Me.printPreviewSubItem1.Id = 28
			Me.printPreviewSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem22, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem24, True)})
			Me.printPreviewSubItem1.Name = "printPreviewSubItem1"
			' 
			' printPreviewSubItem2
			' 
			Me.printPreviewSubItem2.Caption = "&View"
			Me.printPreviewSubItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View
			Me.printPreviewSubItem2.Id = 29
			Me.printPreviewSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barToolbarsListItem1, True)})
			Me.printPreviewSubItem2.Name = "printPreviewSubItem2"
			' 
			' printPreviewSubItem3
			' 
			Me.printPreviewSubItem3.Caption = "&Background"
			Me.printPreviewSubItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Background
			Me.printPreviewSubItem3.Id = 30
			Me.printPreviewSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem21)})
			Me.printPreviewSubItem3.Name = "printPreviewSubItem3"
			' 
			' printPreviewSubItem4
			' 
			Me.printPreviewSubItem4.Caption = "&Page Layout"
			Me.printPreviewSubItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout
			Me.printPreviewSubItem4.Id = 31
			Me.printPreviewSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem26)})
			Me.printPreviewSubItem4.Name = "printPreviewSubItem4"
			' 
			' printPreviewBarItem25
			' 
			Me.printPreviewBarItem25.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem25.Caption = "&Facing"
			Me.printPreviewBarItem25.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing
			Me.printPreviewBarItem25.Enabled = False
			Me.printPreviewBarItem25.GroupIndex = 100
			Me.printPreviewBarItem25.Id = 32
			Me.printPreviewBarItem25.Name = "printPreviewBarItem25"
			' 
			' printPreviewBarItem26
			' 
			Me.printPreviewBarItem26.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem26.Caption = "&Continuous"
			Me.printPreviewBarItem26.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous
			Me.printPreviewBarItem26.Enabled = False
			Me.printPreviewBarItem26.GroupIndex = 100
			Me.printPreviewBarItem26.Id = 33
			Me.printPreviewBarItem26.Name = "printPreviewBarItem26"
			' 
			' barToolbarsListItem1
			' 
			Me.barToolbarsListItem1.Caption = "Bars"
			Me.barToolbarsListItem1.Id = 34
			Me.barToolbarsListItem1.Name = "barToolbarsListItem1"
			' 
			' printPreviewBarCheckItem1
			' 
			Me.printPreviewBarCheckItem1.Caption = "PDF File"
			Me.printPreviewBarCheckItem1.Checked = True
			Me.printPreviewBarCheckItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf
			Me.printPreviewBarCheckItem1.Enabled = False
			Me.printPreviewBarCheckItem1.GroupIndex = 2
			Me.printPreviewBarCheckItem1.Hint = "PDF File"
			Me.printPreviewBarCheckItem1.Id = 35
			Me.printPreviewBarCheckItem1.Name = "printPreviewBarCheckItem1"
			' 
			' printPreviewBarCheckItem2
			' 
			Me.printPreviewBarCheckItem2.Caption = "HTML File"
			Me.printPreviewBarCheckItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm
			Me.printPreviewBarCheckItem2.Enabled = False
			Me.printPreviewBarCheckItem2.GroupIndex = 2
			Me.printPreviewBarCheckItem2.Hint = "HTML File"
			Me.printPreviewBarCheckItem2.Id = 36
			Me.printPreviewBarCheckItem2.Name = "printPreviewBarCheckItem2"
			' 
			' printPreviewBarCheckItem3
			' 
			Me.printPreviewBarCheckItem3.Caption = "MHT File"
			Me.printPreviewBarCheckItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht
			Me.printPreviewBarCheckItem3.Enabled = False
			Me.printPreviewBarCheckItem3.GroupIndex = 2
			Me.printPreviewBarCheckItem3.Hint = "MHT File"
			Me.printPreviewBarCheckItem3.Id = 37
			Me.printPreviewBarCheckItem3.Name = "printPreviewBarCheckItem3"
			' 
			' printPreviewBarCheckItem4
			' 
			Me.printPreviewBarCheckItem4.Caption = "RTF File"
			Me.printPreviewBarCheckItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf
			Me.printPreviewBarCheckItem4.Enabled = False
			Me.printPreviewBarCheckItem4.GroupIndex = 2
			Me.printPreviewBarCheckItem4.Hint = "RTF File"
			Me.printPreviewBarCheckItem4.Id = 38
			Me.printPreviewBarCheckItem4.Name = "printPreviewBarCheckItem4"
			' 
			' printPreviewBarCheckItem5
			' 
			Me.printPreviewBarCheckItem5.Caption = "Excel File"
			Me.printPreviewBarCheckItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls
			Me.printPreviewBarCheckItem5.Enabled = False
			Me.printPreviewBarCheckItem5.GroupIndex = 2
			Me.printPreviewBarCheckItem5.Hint = "Excel File"
			Me.printPreviewBarCheckItem5.Id = 39
			Me.printPreviewBarCheckItem5.Name = "printPreviewBarCheckItem5"
			' 
			' printPreviewBarCheckItem6
			' 
			Me.printPreviewBarCheckItem6.Caption = "CSV File"
			Me.printPreviewBarCheckItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv
			Me.printPreviewBarCheckItem6.Enabled = False
			Me.printPreviewBarCheckItem6.GroupIndex = 2
			Me.printPreviewBarCheckItem6.Hint = "CSV File"
			Me.printPreviewBarCheckItem6.Id = 40
			Me.printPreviewBarCheckItem6.Name = "printPreviewBarCheckItem6"
			' 
			' printPreviewBarCheckItem7
			' 
			Me.printPreviewBarCheckItem7.Caption = "Text File"
			Me.printPreviewBarCheckItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt
			Me.printPreviewBarCheckItem7.Enabled = False
			Me.printPreviewBarCheckItem7.GroupIndex = 2
			Me.printPreviewBarCheckItem7.Hint = "Text File"
			Me.printPreviewBarCheckItem7.Id = 41
			Me.printPreviewBarCheckItem7.Name = "printPreviewBarCheckItem7"
			' 
			' printPreviewBarCheckItem8
			' 
			Me.printPreviewBarCheckItem8.Caption = "Image File"
			Me.printPreviewBarCheckItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic
			Me.printPreviewBarCheckItem8.Enabled = False
			Me.printPreviewBarCheckItem8.GroupIndex = 2
			Me.printPreviewBarCheckItem8.Hint = "Image File"
			Me.printPreviewBarCheckItem8.Id = 42
			Me.printPreviewBarCheckItem8.Name = "printPreviewBarCheckItem8"
			' 
			' printPreviewBarCheckItem9
			' 
			Me.printPreviewBarCheckItem9.Caption = "PDF File"
			Me.printPreviewBarCheckItem9.Checked = True
			Me.printPreviewBarCheckItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf
			Me.printPreviewBarCheckItem9.Enabled = False
			Me.printPreviewBarCheckItem9.GroupIndex = 1
			Me.printPreviewBarCheckItem9.Hint = "PDF File"
			Me.printPreviewBarCheckItem9.Id = 43
			Me.printPreviewBarCheckItem9.Name = "printPreviewBarCheckItem9"
			' 
			' printPreviewBarCheckItem10
			' 
			Me.printPreviewBarCheckItem10.Caption = "MHT File"
			Me.printPreviewBarCheckItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht
			Me.printPreviewBarCheckItem10.Enabled = False
			Me.printPreviewBarCheckItem10.GroupIndex = 1
			Me.printPreviewBarCheckItem10.Hint = "MHT File"
			Me.printPreviewBarCheckItem10.Id = 44
			Me.printPreviewBarCheckItem10.Name = "printPreviewBarCheckItem10"
			' 
			' printPreviewBarCheckItem11
			' 
			Me.printPreviewBarCheckItem11.Caption = "RTF File"
			Me.printPreviewBarCheckItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf
			Me.printPreviewBarCheckItem11.Enabled = False
			Me.printPreviewBarCheckItem11.GroupIndex = 1
			Me.printPreviewBarCheckItem11.Hint = "RTF File"
			Me.printPreviewBarCheckItem11.Id = 45
			Me.printPreviewBarCheckItem11.Name = "printPreviewBarCheckItem11"
			' 
			' printPreviewBarCheckItem12
			' 
			Me.printPreviewBarCheckItem12.Caption = "Excel File"
			Me.printPreviewBarCheckItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls
			Me.printPreviewBarCheckItem12.Enabled = False
			Me.printPreviewBarCheckItem12.GroupIndex = 1
			Me.printPreviewBarCheckItem12.Hint = "Excel File"
			Me.printPreviewBarCheckItem12.Id = 46
			Me.printPreviewBarCheckItem12.Name = "printPreviewBarCheckItem12"
			' 
			' printPreviewBarCheckItem13
			' 
			Me.printPreviewBarCheckItem13.Caption = "CSV File"
			Me.printPreviewBarCheckItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv
			Me.printPreviewBarCheckItem13.Enabled = False
			Me.printPreviewBarCheckItem13.GroupIndex = 1
			Me.printPreviewBarCheckItem13.Hint = "CSV File"
			Me.printPreviewBarCheckItem13.Id = 47
			Me.printPreviewBarCheckItem13.Name = "printPreviewBarCheckItem13"
			' 
			' printPreviewBarCheckItem14
			' 
			Me.printPreviewBarCheckItem14.Caption = "Text File"
			Me.printPreviewBarCheckItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt
			Me.printPreviewBarCheckItem14.Enabled = False
			Me.printPreviewBarCheckItem14.GroupIndex = 1
			Me.printPreviewBarCheckItem14.Hint = "Text File"
			Me.printPreviewBarCheckItem14.Id = 48
			Me.printPreviewBarCheckItem14.Name = "printPreviewBarCheckItem14"
			' 
			' printPreviewBarCheckItem15
			' 
			Me.printPreviewBarCheckItem15.Caption = "Image File"
			Me.printPreviewBarCheckItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic
			Me.printPreviewBarCheckItem15.Enabled = False
			Me.printPreviewBarCheckItem15.GroupIndex = 1
			Me.printPreviewBarCheckItem15.Hint = "Image File"
			Me.printPreviewBarCheckItem15.Id = 49
			Me.printPreviewBarCheckItem15.Name = "printPreviewBarCheckItem15"
			' 
			' printControl1
			' 
			Me.printControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.printControl1.IsMetric = False
			Me.printControl1.Location = New System.Drawing.Point(0, 51)
			Me.printControl1.Name = "printControl1"
			Me.printControl1.Size = New System.Drawing.Size(775, 320)
			Me.printControl1.TabIndex = 4
			' 
			' XtraUserControl1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.printControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "XtraUserControl1"
			Me.Size = New System.Drawing.Size(775, 394)
			CType(Me.printBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.printPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private printBarManager1 As DevExpress.XtraPrinting.Preview.PrintBarManager
		Private previewBar1 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private printPreviewBarItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem3 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem4 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem5 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem6 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem7 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem8 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem9 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem10 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem11 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem12 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem13 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private zoomBarEditItem1 As DevExpress.XtraPrinting.Preview.ZoomBarEditItem
		Private printPreviewRepositoryItemComboBox1 As DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
		Private printPreviewBarItem14 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem15 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem16 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem17 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem18 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem19 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem20 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem21 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem22 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem23 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem24 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private previewBar2 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private printPreviewStaticItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem
		Private printPreviewStaticItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem
		Private printPreviewStaticItem3 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem
		Private previewBar3 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private printPreviewSubItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private printPreviewSubItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private printPreviewSubItem4 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private printPreviewBarItem25 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem26 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private barToolbarsListItem1 As DevExpress.XtraBars.BarToolbarsListItem
		Private printPreviewSubItem3 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private printPreviewBarCheckItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem3 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem4 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem5 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem6 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem7 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem8 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem9 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem10 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem11 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem12 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem13 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem14 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem15 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Public printControl1 As DevExpress.XtraPrinting.Control.PrintControl
	End Class
End Namespace
