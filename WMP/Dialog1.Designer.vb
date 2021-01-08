<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dialog1))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Notreeforstart = New System.Windows.Forms.RadioButton()
        Me.Treeforstart = New System.Windows.Forms.RadioButton()
        Me.No = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(237, 111)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(104, 22)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "ОК"
        '
        'Notreeforstart
        '
        Me.Notreeforstart.AutoSize = True
        Me.Notreeforstart.Location = New System.Drawing.Point(12, 12)
        Me.Notreeforstart.Name = "Notreeforstart"
        Me.Notreeforstart.Size = New System.Drawing.Size(198, 17)
        Me.Notreeforstart.TabIndex = 12
        Me.Notreeforstart.Text = "Развернуть при воспроизведении"
        Me.Notreeforstart.UseVisualStyleBackColor = True
        '
        'Treeforstart
        '
        Me.Treeforstart.AutoSize = True
        Me.Treeforstart.Location = New System.Drawing.Point(12, 35)
        Me.Treeforstart.Name = "Treeforstart"
        Me.Treeforstart.Size = New System.Drawing.Size(186, 17)
        Me.Treeforstart.TabIndex = 13
        Me.Treeforstart.Text = "Свернуть при воспроизведении"
        Me.Treeforstart.UseVisualStyleBackColor = True
        '
        'No
        '
        Me.No.AutoSize = True
        Me.No.Checked = True
        Me.No.Location = New System.Drawing.Point(12, 58)
        Me.No.Name = "No"
        Me.No.Size = New System.Drawing.Size(61, 17)
        Me.No.TabIndex = 14
        Me.No.TabStop = True
        Me.No.Text = "Ничего"
        Me.No.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 110)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(148, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Крупно показать отсчёт"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 87)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(338, 17)
        Me.CheckBox2.TabIndex = 16
        Me.CheckBox2.Text = "Сбросить значение задержки и имя файла по началу отсчёта"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Dialog1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 139)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.No)
        Me.Controls.Add(Me.Treeforstart)
        Me.Controls.Add(Me.Notreeforstart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Настройки"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Notreeforstart As System.Windows.Forms.RadioButton
    Friend WithEvents Treeforstart As System.Windows.Forms.RadioButton
    Friend WithEvents No As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox

End Class
