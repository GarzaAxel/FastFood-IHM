﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategoria))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPromociones = New System.Windows.Forms.Button()
        Me.btnCarrito = New System.Windows.Forms.Button()
        Me.btnPostres = New System.Windows.Forms.Button()
        Me.btnBebidas = New System.Windows.Forms.Button()
        Me.btnComida = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gusto = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ContactoCbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(425, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 33)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Elige la opción que deseas:"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(741, 503)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(291, 96)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "      Reservaciones"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnPromociones
        '
        Me.btnPromociones.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPromociones.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnPromociones.FlatAppearance.BorderSize = 0
        Me.btnPromociones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPromociones.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromociones.ForeColor = System.Drawing.Color.Black
        Me.btnPromociones.Image = CType(resources.GetObject("btnPromociones.Image"), System.Drawing.Image)
        Me.btnPromociones.Location = New System.Drawing.Point(374, 241)
        Me.btnPromociones.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPromociones.Name = "btnPromociones"
        Me.btnPromociones.Size = New System.Drawing.Size(265, 85)
        Me.btnPromociones.TabIndex = 26
        Me.btnPromociones.Text = " Promociones"
        Me.btnPromociones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPromociones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPromociones.UseVisualStyleBackColor = True
        '
        'btnCarrito
        '
        Me.btnCarrito.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCarrito.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnCarrito.FlatAppearance.BorderSize = 0
        Me.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarrito.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarrito.ForeColor = System.Drawing.Color.Black
        Me.btnCarrito.Image = CType(resources.GetObject("btnCarrito.Image"), System.Drawing.Image)
        Me.btnCarrito.Location = New System.Drawing.Point(741, 390)
        Me.btnCarrito.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCarrito.Name = "btnCarrito"
        Me.btnCarrito.Size = New System.Drawing.Size(252, 81)
        Me.btnCarrito.TabIndex = 30
        Me.btnCarrito.Text = "          Carrito"
        Me.btnCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCarrito.UseVisualStyleBackColor = True
        '
        'btnPostres
        '
        Me.btnPostres.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPostres.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnPostres.FlatAppearance.BorderSize = 0
        Me.btnPostres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPostres.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPostres.ForeColor = System.Drawing.Color.Black
        Me.btnPostres.Image = CType(resources.GetObject("btnPostres.Image"), System.Drawing.Image)
        Me.btnPostres.Location = New System.Drawing.Point(741, 232)
        Me.btnPostres.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPostres.Name = "btnPostres"
        Me.btnPostres.Size = New System.Drawing.Size(252, 94)
        Me.btnPostres.TabIndex = 29
        Me.btnPostres.Text = "          Postres"
        Me.btnPostres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPostres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPostres.UseVisualStyleBackColor = True
        '
        'btnBebidas
        '
        Me.btnBebidas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBebidas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnBebidas.FlatAppearance.BorderSize = 0
        Me.btnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBebidas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBebidas.ForeColor = System.Drawing.Color.Black
        Me.btnBebidas.Image = CType(resources.GetObject("btnBebidas.Image"), System.Drawing.Image)
        Me.btnBebidas.Location = New System.Drawing.Point(374, 503)
        Me.btnBebidas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBebidas.Name = "btnBebidas"
        Me.btnBebidas.Size = New System.Drawing.Size(252, 87)
        Me.btnBebidas.TabIndex = 28
        Me.btnBebidas.Text = "      Bebidas"
        Me.btnBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBebidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBebidas.UseVisualStyleBackColor = True
        '
        'btnComida
        '
        Me.btnComida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnComida.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnComida.FlatAppearance.BorderSize = 0
        Me.btnComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComida.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComida.ForeColor = System.Drawing.Color.Black
        Me.btnComida.Image = CType(resources.GetObject("btnComida.Image"), System.Drawing.Image)
        Me.btnComida.Location = New System.Drawing.Point(374, 377)
        Me.btnComida.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComida.Name = "btnComida"
        Me.btnComida.Size = New System.Drawing.Size(265, 94)
        Me.btnComida.TabIndex = 27
        Me.btnComida.Text = "     Comidas"
        Me.btnComida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnComida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnComida.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.gusto)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(300, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(795, 145)
        Me.Panel2.TabIndex = 25
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(619, 30)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(87, 66)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(128, 30)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'gusto
        '
        Me.gusto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gusto.AutoSize = True
        Me.gusto.BackColor = System.Drawing.Color.Red
        Me.gusto.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gusto.ForeColor = System.Drawing.Color.White
        Me.gusto.Location = New System.Drawing.Point(275, 41)
        Me.gusto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.gusto.Name = "gusto"
        Me.gusto.Size = New System.Drawing.Size(211, 59)
        Me.gusto.TabIndex = 4
        Me.gusto.Text = "Fast Food "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ContactoCbtn)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 669)
        Me.Panel1.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Freestyle Script", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(63, 410)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 52)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Instantánea!"
        '
        'ContactoCbtn
        '
        Me.ContactoCbtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ContactoCbtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ContactoCbtn.FlatAppearance.BorderSize = 0
        Me.ContactoCbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContactoCbtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactoCbtn.ForeColor = System.Drawing.Color.Black
        Me.ContactoCbtn.Image = CType(resources.GetObject("ContactoCbtn.Image"), System.Drawing.Image)
        Me.ContactoCbtn.Location = New System.Drawing.Point(21, 501)
        Me.ContactoCbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ContactoCbtn.Name = "ContactoCbtn"
        Me.ContactoCbtn.Size = New System.Drawing.Size(252, 85)
        Me.ContactoCbtn.TabIndex = 22
        Me.ContactoCbtn.Text = "       Contacto"
        Me.ContactoCbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ContactoCbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ContactoCbtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Freestyle Script", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(76, 309)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 52)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Felicidad"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(52, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 29)
        Me.Label1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Freestyle Script", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(48, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 52)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "¡Comida rápida,"
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 669)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnPromociones)
        Me.Controls.Add(Me.btnCarrito)
        Me.Controls.Add(Me.btnPostres)
        Me.Controls.Add(Me.btnBebidas)
        Me.Controls.Add(Me.btnComida)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCategoria"
        Me.Text = "Categoria"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnPromociones As Button
    Friend WithEvents btnCarrito As Button
    Friend WithEvents btnPostres As Button
    Friend WithEvents btnBebidas As Button
    Friend WithEvents btnComida As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gusto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents ContactoCbtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
