Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace TwoSchedulers
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            For i As Integer = 0 To 9
                Dim resource As Resource = schedulerStorage1.CreateResource(i)
                resource.Caption = "Resource" & i
                schedulerStorage1.Resources.Add(resource)
            Next i
        End Sub
        Private Sub schedulerControl1_VisibleIntervalChanged(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl1.VisibleIntervalChanged
            SetStart(schedulerControl2, schedulerControl1)
        End Sub

        Private Sub schedulerControl2_VisibleIntervalChanged(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl2.VisibleIntervalChanged
            SetStart(schedulerControl1, schedulerControl2)
        End Sub

        Private Shared Sub SetStart(ByVal firstScheduler As SchedulerControl, ByVal secondScheduler As SchedulerControl)
            firstScheduler.Start = secondScheduler.Start
        End Sub

        Private Sub schedulerControl1_CustomDrawResourceHeader(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles schedulerControl1.CustomDrawResourceHeader
            SetFirstVisibleResourceIndex(schedulerControl2, schedulerControl1)
            SetResourcesPerPage(schedulerControl2, schedulerControl1)
        End Sub

        Private Sub schedulerControl2_CustomDrawResourceHeader(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles schedulerControl2.CustomDrawResourceHeader
            SetFirstVisibleResourceIndex(schedulerControl1, schedulerControl2)
            SetResourcesPerPage(schedulerControl1, schedulerControl2)
        End Sub

        Private Shared Sub SetFirstVisibleResourceIndex(ByVal firstScheduler As SchedulerControl, ByVal secondScheduler As SchedulerControl)
            If firstScheduler.ActiveView.FirstVisibleResourceIndex <> secondScheduler.ActiveView.FirstVisibleResourceIndex Then
                firstScheduler.ActiveView.FirstVisibleResourceIndex = secondScheduler.ActiveView.FirstVisibleResourceIndex
            End If
        End Sub

        Private Shared Sub SetResourcesPerPage(ByVal firstScheduler As SchedulerControl, ByVal secondScheduler As SchedulerControl)
            If firstScheduler.ActiveView.ResourcesPerPage <> secondScheduler.ActiveView.ResourcesPerPage Then
                firstScheduler.ActiveView.ResourcesPerPage = secondScheduler.ActiveView.ResourcesPerPage
            End If
        End Sub
    End Class
End Namespace
