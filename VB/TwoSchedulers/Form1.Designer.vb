Imports Microsoft.VisualBasic
Imports System
Namespace TwoSchedulers
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler4 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.schedulerControl2 = New DevExpress.XtraScheduler.SchedulerControl()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
			Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
			Me.schedulerControl1.Location = New System.Drawing.Point(13, 13)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(945, 245)
			Me.schedulerControl1.Start = New System.DateTime(2010, 5, 12, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.Enabled = False
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.MonthView.Enabled = False
			Me.schedulerControl1.Views.TimelineView.ResourcesPerPage = 2
			Me.schedulerControl1.Views.WeekView.Enabled = False
			Me.schedulerControl1.Views.WorkWeekView.Enabled = False
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
'			Me.schedulerControl1.VisibleIntervalChanged += New System.EventHandler(Me.schedulerControl1_VisibleIntervalChanged);
'			Me.schedulerControl1.CustomDrawResourceHeader += New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(Me.schedulerControl1_CustomDrawResourceHeader);
			' 
			' schedulerControl2
			' 
			Me.schedulerControl2.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
			Me.schedulerControl2.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
			Me.schedulerControl2.Location = New System.Drawing.Point(13, 292)
			Me.schedulerControl2.Name = "schedulerControl2"
			Me.schedulerControl2.Size = New System.Drawing.Size(945, 234)
			Me.schedulerControl2.Start = New System.DateTime(2010, 5, 12, 0, 0, 0, 0)
			Me.schedulerControl2.Storage = Me.schedulerStorage1
			Me.schedulerControl2.TabIndex = 1
			Me.schedulerControl2.Text = "schedulerControl2"
			Me.schedulerControl2.Views.DayView.Enabled = False
			Me.schedulerControl2.Views.DayView.TimeRulers.Add(timeRuler3)
			Me.schedulerControl2.Views.MonthView.Enabled = False
			Me.schedulerControl2.Views.TimelineView.ResourcesPerPage = 2
			Me.schedulerControl2.Views.WeekView.Enabled = False
			Me.schedulerControl2.Views.WorkWeekView.Enabled = False
			Me.schedulerControl2.Views.WorkWeekView.TimeRulers.Add(timeRuler4)
'			Me.schedulerControl2.VisibleIntervalChanged += New System.EventHandler(Me.schedulerControl2_VisibleIntervalChanged);
'			Me.schedulerControl2.CustomDrawResourceHeader += New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(Me.schedulerControl2_CustomDrawResourceHeader);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(970, 538)
			Me.Controls.Add(Me.schedulerControl2)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private WithEvents schedulerControl2 As DevExpress.XtraScheduler.SchedulerControl
	End Class
End Namespace

