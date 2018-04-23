' Developer Express Code Central Example:
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
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Windows

Namespace BarManagerControllerExample
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application
	End Class
End Namespace
