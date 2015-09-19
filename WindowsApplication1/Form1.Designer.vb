<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lb_collections = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_retroloc = New System.Windows.Forms.TextBox()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.cb_corelist = New System.Windows.Forms.ComboBox()
        Me.tb_collecname = New System.Windows.Forms.TextBox()
        Me.btn_SaveCore = New System.Windows.Forms.Button()
        Me.tb_messsysname = New System.Windows.Forms.TextBox()
        Me.lbl_messsysname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lb_collections
        '
        Me.lb_collections.FormattingEnabled = True
        Me.lb_collections.Location = New System.Drawing.Point(12, 38)
        Me.lb_collections.Name = "lb_collections"
        Me.lb_collections.Size = New System.Drawing.Size(203, 355)
        Me.lb_collections.Sorted = True
        Me.lb_collections.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RetroFE Collections"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(659, 367)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(91, 30)
        Me.btn_close.TabIndex = 2
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RetroArch Launcher Config"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "RetroArch Path:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "RetroArch Core:"
        '
        'tb_retroloc
        '
        Me.tb_retroloc.Location = New System.Drawing.Point(335, 61)
        Me.tb_retroloc.Name = "tb_retroloc"
        Me.tb_retroloc.Size = New System.Drawing.Size(318, 20)
        Me.tb_retroloc.TabIndex = 6
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(659, 55)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(91, 30)
        Me.btn_browse.TabIndex = 7
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'cb_corelist
        '
        Me.cb_corelist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_corelist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_corelist.FormattingEnabled = True
        Me.cb_corelist.Location = New System.Drawing.Point(335, 154)
        Me.cb_corelist.Name = "cb_corelist"
        Me.cb_corelist.Size = New System.Drawing.Size(415, 21)
        Me.cb_corelist.Sorted = True
        Me.cb_corelist.TabIndex = 8
        '
        'tb_collecname
        '
        Me.tb_collecname.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tb_collecname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_collecname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_collecname.Location = New System.Drawing.Point(221, 117)
        Me.tb_collecname.Name = "tb_collecname"
        Me.tb_collecname.Size = New System.Drawing.Size(529, 24)
        Me.tb_collecname.TabIndex = 9
        '
        'btn_SaveCore
        '
        Me.btn_SaveCore.Location = New System.Drawing.Point(659, 181)
        Me.btn_SaveCore.Name = "btn_SaveCore"
        Me.btn_SaveCore.Size = New System.Drawing.Size(91, 30)
        Me.btn_SaveCore.TabIndex = 10
        Me.btn_SaveCore.Text = "Save"
        Me.btn_SaveCore.UseVisualStyleBackColor = True
        '
        'tb_messsysname
        '
        Me.tb_messsysname.AcceptsTab = True
        Me.tb_messsysname.Location = New System.Drawing.Point(335, 181)
        Me.tb_messsysname.Name = "tb_messsysname"
        Me.tb_messsysname.Size = New System.Drawing.Size(123, 20)
        Me.tb_messsysname.TabIndex = 12
        Me.tb_messsysname.Visible = False
        '
        'lbl_messsysname
        '
        Me.lbl_messsysname.AutoSize = True
        Me.lbl_messsysname.Location = New System.Drawing.Point(223, 184)
        Me.lbl_messsysname.Name = "lbl_messsysname"
        Me.lbl_messsysname.Size = New System.Drawing.Size(103, 13)
        Me.lbl_messsysname.TabIndex = 11
        Me.lbl_messsysname.Text = "Mess System Name:"
        Me.lbl_messsysname.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 409)
        Me.Controls.Add(Me.tb_messsysname)
        Me.Controls.Add(Me.lbl_messsysname)
        Me.Controls.Add(Me.btn_SaveCore)
        Me.Controls.Add(Me.tb_collecname)
        Me.Controls.Add(Me.cb_corelist)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.tb_retroloc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_collections)
        Me.Name = "Form1"
        Me.Text = "RetroArch Launcher Config"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_collections As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_retroloc As System.Windows.Forms.TextBox
    Friend WithEvents btn_browse As System.Windows.Forms.Button
    Friend WithEvents cb_corelist As System.Windows.Forms.ComboBox
    Friend WithEvents tb_collecname As System.Windows.Forms.TextBox
    Friend WithEvents btn_SaveCore As System.Windows.Forms.Button
    Friend WithEvents tb_messsysname As System.Windows.Forms.TextBox
    Friend WithEvents lbl_messsysname As System.Windows.Forms.Label

End Class
