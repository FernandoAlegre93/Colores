<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.txtIntroducir = New System.Windows.Forms.TextBox()
        Me.rdbtnRojo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbtnVerde = New System.Windows.Forms.RadioButton()
        Me.rdbtnAmarillo = New System.Windows.Forms.RadioButton()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnOcultar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbtnViol = New System.Windows.Forms.RadioButton()
        Me.rdbtnRosa = New System.Windows.Forms.RadioButton()
        Me.rdbtnAzul = New System.Windows.Forms.RadioButton()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIngreso
        '
        Me.btnIngreso.Location = New System.Drawing.Point(443, 22)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(75, 23)
        Me.btnIngreso.TabIndex = 0
        Me.btnIngreso.Text = "Ingresar"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'txtIntroducir
        '
        Me.txtIntroducir.Location = New System.Drawing.Point(224, 27)
        Me.txtIntroducir.Name = "txtIntroducir"
        Me.txtIntroducir.Size = New System.Drawing.Size(100, 20)
        Me.txtIntroducir.TabIndex = 1
        '
        'rdbtnRojo
        '
        Me.rdbtnRojo.AutoSize = True
        Me.rdbtnRojo.Location = New System.Drawing.Point(6, 19)
        Me.rdbtnRojo.Name = "rdbtnRojo"
        Me.rdbtnRojo.Size = New System.Drawing.Size(47, 17)
        Me.rdbtnRojo.TabIndex = 2
        Me.rdbtnRojo.TabStop = True
        Me.rdbtnRojo.Text = "Rojo"
        Me.rdbtnRojo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbtnVerde)
        Me.GroupBox1.Controls.Add(Me.rdbtnAmarillo)
        Me.GroupBox1.Controls.Add(Me.rdbtnRojo)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color de Texto"
        '
        'rdbtnVerde
        '
        Me.rdbtnVerde.AutoSize = True
        Me.rdbtnVerde.Location = New System.Drawing.Point(6, 42)
        Me.rdbtnVerde.Name = "rdbtnVerde"
        Me.rdbtnVerde.Size = New System.Drawing.Size(53, 17)
        Me.rdbtnVerde.TabIndex = 4
        Me.rdbtnVerde.TabStop = True
        Me.rdbtnVerde.Text = "Verde"
        Me.rdbtnVerde.UseVisualStyleBackColor = True
        '
        'rdbtnAmarillo
        '
        Me.rdbtnAmarillo.AutoSize = True
        Me.rdbtnAmarillo.Location = New System.Drawing.Point(6, 65)
        Me.rdbtnAmarillo.Name = "rdbtnAmarillo"
        Me.rdbtnAmarillo.Size = New System.Drawing.Size(61, 17)
        Me.rdbtnAmarillo.TabIndex = 5
        Me.rdbtnAmarillo.TabStop = True
        Me.rdbtnAmarillo.Text = "Amarillo"
        Me.rdbtnAmarillo.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(84, 300)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(75, 23)
        Me.btnVer.TabIndex = 4
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnOcultar
        '
        Me.btnOcultar.Location = New System.Drawing.Point(234, 300)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Size = New System.Drawing.Size(75, 23)
        Me.btnOcultar.TabIndex = 5
        Me.btnOcultar.Text = "Ocultar"
        Me.btnOcultar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(382, 300)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(130, 27)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(81, 13)
        Me.lbl1.TabIndex = 7
        Me.lbl1.Text = "Introducir Texto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbtnViol)
        Me.GroupBox2.Controls.Add(Me.rdbtnRosa)
        Me.GroupBox2.Controls.Add(Me.rdbtnAzul)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(318, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Color de fondo"
        '
        'rdbtnViol
        '
        Me.rdbtnViol.AutoSize = True
        Me.rdbtnViol.Location = New System.Drawing.Point(6, 42)
        Me.rdbtnViol.Name = "rdbtnViol"
        Me.rdbtnViol.Size = New System.Drawing.Size(57, 17)
        Me.rdbtnViol.TabIndex = 4
        Me.rdbtnViol.TabStop = True
        Me.rdbtnViol.Text = "Violeta"
        Me.rdbtnViol.UseVisualStyleBackColor = True
        '
        'rdbtnRosa
        '
        Me.rdbtnRosa.AutoSize = True
        Me.rdbtnRosa.Location = New System.Drawing.Point(6, 65)
        Me.rdbtnRosa.Name = "rdbtnRosa"
        Me.rdbtnRosa.Size = New System.Drawing.Size(50, 17)
        Me.rdbtnRosa.TabIndex = 5
        Me.rdbtnRosa.TabStop = True
        Me.rdbtnRosa.Text = "Rosa"
        Me.rdbtnRosa.UseVisualStyleBackColor = True
        '
        'rdbtnAzul
        '
        Me.rdbtnAzul.AutoSize = True
        Me.rdbtnAzul.Location = New System.Drawing.Point(6, 19)
        Me.rdbtnAzul.Name = "rdbtnAzul"
        Me.rdbtnAzul.Size = New System.Drawing.Size(45, 17)
        Me.rdbtnAzul.TabIndex = 2
        Me.rdbtnAzul.TabStop = True
        Me.rdbtnAzul.Text = "Azul"
        Me.rdbtnAzul.UseVisualStyleBackColor = True
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.BackColor = System.Drawing.Color.White
        Me.lblTexto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTexto.Font = New System.Drawing.Font("Tahoma", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.ForeColor = System.Drawing.Color.Blue
        Me.lblTexto.Location = New System.Drawing.Point(177, 99)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(2, 27)
        Me.lblTexto.TabIndex = 8
        Me.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 335)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnOcultar)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIntroducir)
        Me.Controls.Add(Me.btnIngreso)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIngreso As System.Windows.Forms.Button
    Friend WithEvents txtIntroducir As System.Windows.Forms.TextBox
    Friend WithEvents rdbtnRojo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnVerde As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnAmarillo As System.Windows.Forms.RadioButton
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents btnOcultar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnViol As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnRosa As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnAzul As System.Windows.Forms.RadioButton
    Friend WithEvents lblTexto As System.Windows.Forms.Label

End Class
