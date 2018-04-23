﻿' Developer Express Code Central Example:
' How to define bars and bar items via a template
' 
' This example shows how to define a bar, bar items and bar item links in a
' DataTemplate, and then use this template to create these objects in a
' BarManager. Bar objects are defined via the DataTemplate class. The
' DataTemplate's content must be a BarManagerActionContainer object, containing
' actions to create bar objects. The created template is used within the
' BarManager via the BarManager.Controllers collection.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1731


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace BarManagerControllerExample
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnExit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Wpf.Bars.ItemClickEventArgs)
			Close()
		End Sub

		Private Sub btnAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Wpf.Bars.ItemClickEventArgs)
			MessageBox.Show("About Window")
		End Sub
	End Class
End Namespace
