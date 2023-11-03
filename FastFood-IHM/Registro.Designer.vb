<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RegresarRBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.gusto = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RegistrarRBtn = New System.Windows.Forms.Button()
        Me.ContraseñaRtxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UsuarioRtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IdUtxt = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.Controls.Add(Me.RegresarRBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.ForeColor = System.Drawing.Color.Orange
        Me.Panel3.Location = New System.Drawing.Point(154, 310)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(450, 36)
        Me.Panel3.TabIndex = 103
        '
        'RegresarRBtn
        '
        Me.RegresarRBtn.BackColor = System.Drawing.Color.White
        Me.RegresarRBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegresarRBtn.Location = New System.Drawing.Point(340, 3)
        Me.RegresarRBtn.Name = "RegresarRBtn"
        Me.RegresarRBtn.Size = New System.Drawing.Size(98, 29)
        Me.RegresarRBtn.TabIndex = 100
        Me.RegresarRBtn.Text = "Regresar"
        Me.RegresarRBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.gusto)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(154, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 63)
        Me.Panel2.TabIndex = 102
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(361, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(65, 54)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 36
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(15, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 54)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'gusto
        '
        Me.gusto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gusto.AutoSize = True
        Me.gusto.BackColor = System.Drawing.Color.Red
        Me.gusto.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gusto.ForeColor = System.Drawing.Color.White
        Me.gusto.Location = New System.Drawing.Point(151, 9)
        Me.gusto.Name = "gusto"
        Me.gusto.Size = New System.Drawing.Size(161, 45)
        Me.gusto.TabIndex = 2
        Me.gusto.Text = "Fast Food"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(154, 346)
        Me.Panel1.TabIndex = 101
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(154, 125)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Freestyle Script", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 37)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "¡Comida rápida,"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Freestyle Script", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(22, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 37)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Instantánea!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Freestyle Script", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(36, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 37)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Felicidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(39, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 0
        '
        'RegistrarRBtn
        '
        Me.RegistrarRBtn.BackColor = System.Drawing.Color.White
        Me.RegistrarRBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrarRBtn.Location = New System.Drawing.Point(342, 225)
        Me.RegistrarRBtn.Name = "RegistrarRBtn"
        Me.RegistrarRBtn.Size = New System.Drawing.Size(198, 29)
        Me.RegistrarRBtn.TabIndex = 99
        Me.RegistrarRBtn.Text = "Registrar"
        Me.RegistrarRBtn.UseVisualStyleBackColor = False
        '
        'ContraseñaRtxt
        '
        Me.ContraseñaRtxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaRtxt.Location = New System.Drawing.Point(342, 164)
        Me.ContraseñaRtxt.Name = "ContraseñaRtxt"
        Me.ContraseñaRtxt.Size = New System.Drawing.Size(198, 27)
        Me.ContraseñaRtxt.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(204, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 22)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Contraseña:"
        '
        'UsuarioRtxt
        '
        Me.UsuarioRtxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioRtxt.Location = New System.Drawing.Point(342, 125)
        Me.UsuarioRtxt.Name = "UsuarioRtxt"
        Me.UsuarioRtxt.Size = New System.Drawing.Size(198, 27)
        Me.UsuarioRtxt.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 23)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Favor de registrar tus datos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Usuario:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(288, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 22)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "ID:"
        '
        'IdUtxt
        '
        Me.IdUtxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdUtxt.Location = New System.Drawing.Point(342, 87)
        Me.IdUtxt.Name = "IdUtxt"
        Me.IdUtxt.Size = New System.Drawing.Size(198, 27)
        Me.IdUtxt.TabIndex = 105
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 346)
        Me.Controls.Add(Me.IdUtxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RegistrarRBtn)
        Me.Controls.Add(Me.ContraseñaRtxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.UsuarioRtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRegistro"
        Me.Text = "Registro"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents gusto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RegresarRBtn As Button
    Friend WithEvents RegistrarRBtn As Button
    Friend WithEvents ContraseñaRtxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents UsuarioRtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents IdUtxt As TextBox
End Class
