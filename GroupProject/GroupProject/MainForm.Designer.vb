﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm     





' jsdklfjs;l
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
        Me.btnTransactionMode = New System.Windows.Forms.Button()
        Me.btnInventoryManager = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTransactionMode
        '
        Me.btnTransactionMode.Location = New System.Drawing.Point(12, 12)
        Me.btnTransactionMode.Name = "btnTransactionMode"
        Me.btnTransactionMode.Size = New System.Drawing.Size(250, 75)
        Me.btnTransactionMode.TabIndex = 0
        Me.btnTransactionMode.Text = "Transaction Mode"
        Me.btnTransactionMode.UseVisualStyleBackColor = True
        '
        'btnInventoryManager
        '
        Me.btnInventoryManager.Location = New System.Drawing.Point(12, 93)
        Me.btnInventoryManager.Name = "btnInventoryManager"
        Me.btnInventoryManager.Size = New System.Drawing.Size(250, 75)
        Me.btnInventoryManager.TabIndex = 1
        Me.btnInventoryManager.Text = "Inventory Manager"
        Me.btnInventoryManager.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 482)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(250, 75)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 569)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInventoryManager)
        Me.Controls.Add(Me.btnTransactionMode)
        Me.Name = "MainForm"
        Me.Text = "Game Store"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTransactionMode As Button
    Friend WithEvents btnInventoryManager As Button
    Friend WithEvents btnExit As Button
End Class