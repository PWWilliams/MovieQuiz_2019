﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScore
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
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IstHighScore = New System.Windows.Forms.ListBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAgain
        '
        Me.btnAgain.Location = New System.Drawing.Point(654, 360)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(75, 23)
        Me.btnAgain.TabIndex = 0
        Me.btnAgain.Text = "Again"
        Me.btnAgain.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(757, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Congratulations!  Your score will be added to the Hall of Fame"
        '
        'IstHighScore
        '
        Me.IstHighScore.FormattingEnabled = True
        Me.IstHighScore.Location = New System.Drawing.Point(59, 140)
        Me.IstHighScore.Name = "IstHighScore"
        Me.IstHighScore.Size = New System.Drawing.Size(547, 199)
        Me.IstHighScore.TabIndex = 2
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(654, 399)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 478)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.IstHighScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgain)
        Me.Name = "frmHighScore"
        Me.Text = "frmHighScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents IstHighScore As ListBox
    Friend WithEvents btnQuit As Button
End Class
