﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectEntry
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.tblControls = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtImageUrl = New System.Windows.Forms.TextBox()
        Me.lblObjectID = New System.Windows.Forms.Label()
        Me.txtObjectID = New System.Windows.Forms.TextBox()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.txtOffsetY = New System.Windows.Forms.TextBox()
        Me.lblOffsetY = New System.Windows.Forms.Label()
        Me.cboTeam = New System.Windows.Forms.ComboBox()
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.txtAngle = New System.Windows.Forms.TextBox()
        Me.lblDamage = New System.Windows.Forms.Label()
        Me.txtDamage = New System.Windows.Forms.TextBox()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.lblImageUrl = New System.Windows.Forms.Label()
        Me.tblControls.SuspendLayout()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Location = New System.Drawing.Point(962, 4)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(70, 20)
        Me.btnBrowse.TabIndex = 16
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'tblControls
        '
        Me.tblControls.AutoSize = True
        Me.tblControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tblControls.ColumnCount = 3
        Me.tblControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblControls.Controls.Add(Me.btnNew, 0, 0)
        Me.tblControls.Controls.Add(Me.btnRemove, 1, 0)
        Me.tblControls.Dock = System.Windows.Forms.DockStyle.Right
        Me.tblControls.Location = New System.Drawing.Point(1035, 0)
        Me.tblControls.Name = "tblControls"
        Me.tblControls.RowCount = 1
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tblControls.Size = New System.Drawing.Size(135, 28)
        Me.tblControls.TabIndex = 5
        '
        'btnNew
        '
        Me.btnNew.AutoSize = True
        Me.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNew.Location = New System.Drawing.Point(0, 0)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 28)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "[ + ] New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.AutoSize = True
        Me.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRemove.Location = New System.Drawing.Point(60, 0)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 28)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "[ - ] Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtImageUrl
        '
        Me.txtImageUrl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImageUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImageUrl.Location = New System.Drawing.Point(824, 4)
        Me.txtImageUrl.Margin = New System.Windows.Forms.Padding(0)
        Me.txtImageUrl.Name = "txtImageUrl"
        Me.txtImageUrl.Size = New System.Drawing.Size(138, 20)
        Me.txtImageUrl.TabIndex = 15
        '
        'lblObjectID
        '
        Me.lblObjectID.AutoSize = True
        Me.lblObjectID.Location = New System.Drawing.Point(3, 8)
        Me.lblObjectID.Name = "lblObjectID"
        Me.lblObjectID.Size = New System.Drawing.Size(52, 13)
        Me.lblObjectID.TabIndex = 0
        Me.lblObjectID.Text = "ObjectID:"
        '
        'txtObjectID
        '
        Me.txtObjectID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObjectID.Location = New System.Drawing.Point(61, 4)
        Me.txtObjectID.Name = "txtObjectID"
        Me.txtObjectID.Size = New System.Drawing.Size(87, 20)
        Me.txtObjectID.TabIndex = 1
        '
        'pnlContainer
        '
        Me.pnlContainer.Controls.Add(Me.txtOffsetY)
        Me.pnlContainer.Controls.Add(Me.lblOffsetY)
        Me.pnlContainer.Controls.Add(Me.cboTeam)
        Me.pnlContainer.Controls.Add(Me.lblAngle)
        Me.pnlContainer.Controls.Add(Me.txtAngle)
        Me.pnlContainer.Controls.Add(Me.lblDamage)
        Me.pnlContainer.Controls.Add(Me.txtDamage)
        Me.pnlContainer.Controls.Add(Me.lblTeam)
        Me.pnlContainer.Controls.Add(Me.lblHeight)
        Me.pnlContainer.Controls.Add(Me.txtHeight)
        Me.pnlContainer.Controls.Add(Me.lblWidth)
        Me.pnlContainer.Controls.Add(Me.txtWidth)
        Me.pnlContainer.Controls.Add(Me.txtImageUrl)
        Me.pnlContainer.Controls.Add(Me.btnBrowse)
        Me.pnlContainer.Controls.Add(Me.tblControls)
        Me.pnlContainer.Controls.Add(Me.lblObjectID)
        Me.pnlContainer.Controls.Add(Me.txtObjectID)
        Me.pnlContainer.Controls.Add(Me.lblImageUrl)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(1170, 28)
        Me.pnlContainer.TabIndex = 0
        '
        'txtOffsetY
        '
        Me.txtOffsetY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOffsetY.Location = New System.Drawing.Point(728, 4)
        Me.txtOffsetY.MaxLength = 5
        Me.txtOffsetY.Name = "txtOffsetY"
        Me.txtOffsetY.Size = New System.Drawing.Size(48, 20)
        Me.txtOffsetY.TabIndex = 13
        '
        'lblOffsetY
        '
        Me.lblOffsetY.AutoSize = True
        Me.lblOffsetY.Location = New System.Drawing.Point(642, 8)
        Me.lblOffsetY.Name = "lblOffsetY"
        Me.lblOffsetY.Size = New System.Drawing.Size(80, 13)
        Me.lblOffsetY.TabIndex = 12
        Me.lblOffsetY.Text = "Image Y Offset:"
        '
        'cboTeam
        '
        Me.cboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeam.Items.AddRange(New Object() {"0] Astros", "1] Aliens"})
        Me.cboTeam.Location = New System.Drawing.Point(350, 3)
        Me.cboTeam.Name = "cboTeam"
        Me.cboTeam.Size = New System.Drawing.Size(75, 21)
        Me.cboTeam.TabIndex = 7
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.Location = New System.Drawing.Point(431, 8)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(37, 13)
        Me.lblAngle.TabIndex = 8
        Me.lblAngle.Text = "Angle:"
        '
        'txtAngle
        '
        Me.txtAngle.AutoCompleteCustomSource.AddRange(New String() {"0", "0.25", "0.50", "0.75"})
        Me.txtAngle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAngle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAngle.Location = New System.Drawing.Point(474, 4)
        Me.txtAngle.Name = "txtAngle"
        Me.txtAngle.Size = New System.Drawing.Size(50, 20)
        Me.txtAngle.TabIndex = 9
        '
        'lblDamage
        '
        Me.lblDamage.AutoSize = True
        Me.lblDamage.Location = New System.Drawing.Point(530, 8)
        Me.lblDamage.Name = "lblDamage"
        Me.lblDamage.Size = New System.Drawing.Size(50, 13)
        Me.lblDamage.TabIndex = 10
        Me.lblDamage.Text = "Damage:"
        '
        'txtDamage
        '
        Me.txtDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDamage.Location = New System.Drawing.Point(586, 4)
        Me.txtDamage.Name = "txtDamage"
        Me.txtDamage.Size = New System.Drawing.Size(50, 20)
        Me.txtDamage.TabIndex = 11
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Location = New System.Drawing.Point(307, 8)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(37, 13)
        Me.lblTeam.TabIndex = 6
        Me.lblTeam.Text = "Team:"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(229, 8)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(41, 13)
        Me.lblHeight.TabIndex = 4
        Me.lblHeight.Text = "Height:"
        '
        'txtHeight
        '
        Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHeight.Location = New System.Drawing.Point(276, 4)
        Me.txtHeight.MaxLength = 2
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(25, 20)
        Me.txtHeight.TabIndex = 5
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(154, 8)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 2
        Me.lblWidth.Text = "Width:"
        '
        'txtWidth
        '
        Me.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWidth.Location = New System.Drawing.Point(198, 4)
        Me.txtWidth.MaxLength = 2
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(25, 20)
        Me.txtWidth.TabIndex = 3
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblImageUrl
        '
        Me.lblImageUrl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImageUrl.AutoSize = True
        Me.lblImageUrl.Location = New System.Drawing.Point(782, 8)
        Me.lblImageUrl.Name = "lblImageUrl"
        Me.lblImageUrl.Size = New System.Drawing.Size(39, 13)
        Me.lblImageUrl.TabIndex = 14
        Me.lblImageUrl.Text = "Image:"
        '
        'ObjectEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.pnlContainer)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ObjectEntry"
        Me.Size = New System.Drawing.Size(1170, 28)
        Me.tblControls.ResumeLayout(False)
        Me.tblControls.PerformLayout()
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents tblControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents txtImageUrl As System.Windows.Forms.TextBox
    Friend WithEvents lblObjectID As System.Windows.Forms.Label
    Friend WithEvents txtObjectID As System.Windows.Forms.TextBox
    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents lblImageUrl As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblAngle As System.Windows.Forms.Label
    Friend WithEvents txtAngle As System.Windows.Forms.TextBox
    Friend WithEvents lblDamage As System.Windows.Forms.Label
    Friend WithEvents txtDamage As System.Windows.Forms.TextBox
    Friend WithEvents lblTeam As System.Windows.Forms.Label
    Friend WithEvents cboTeam As System.Windows.Forms.ComboBox
    Friend WithEvents txtOffsetY As System.Windows.Forms.TextBox
    Friend WithEvents lblOffsetY As System.Windows.Forms.Label

End Class
