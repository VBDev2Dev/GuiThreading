<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThreads
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.prgStatus = New System.Windows.Forms.ProgressBar()
        Me.btnWork = New System.Windows.Forms.Button()
        Me.btnDoWorkAsync = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'prgStatus
        '
        Me.prgStatus.Location = New System.Drawing.Point(36, 95)
        Me.prgStatus.Name = "prgStatus"
        Me.prgStatus.Size = New System.Drawing.Size(199, 23)
        Me.prgStatus.TabIndex = 0
        '
        'btnWork
        '
        Me.btnWork.Location = New System.Drawing.Point(62, 151)
        Me.btnWork.Name = "btnWork"
        Me.btnWork.Size = New System.Drawing.Size(75, 23)
        Me.btnWork.TabIndex = 1
        Me.btnWork.Text = "Do Work"
        Me.btnWork.UseVisualStyleBackColor = True
        '
        'btnDoWorkAsync
        '
        Me.btnDoWorkAsync.Location = New System.Drawing.Point(62, 202)
        Me.btnDoWorkAsync.Name = "btnDoWorkAsync"
        Me.btnDoWorkAsync.Size = New System.Drawing.Size(140, 23)
        Me.btnDoWorkAsync.TabIndex = 1
        Me.btnDoWorkAsync.Text = "Do Work Async"
        Me.btnDoWorkAsync.UseVisualStyleBackColor = True
        '
        'frmThreads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnDoWorkAsync)
        Me.Controls.Add(Me.btnWork)
        Me.Controls.Add(Me.prgStatus)
        Me.Name = "frmThreads"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prgStatus As ProgressBar
    Friend WithEvents btnWork As Button
    Friend WithEvents btnDoWorkAsync As Button
End Class
