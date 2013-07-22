<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.opf_selec = New System.Windows.Forms.OpenFileDialog()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.lbl_seleccionar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAlto = New System.Windows.Forms.TextBox()
        Me.txtAncho = New System.Windows.Forms.TextBox()
        Me.gb_titulo = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gb_titulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'opf_selec
        '
        Me.opf_selec.Multiselect = True
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.Location = New System.Drawing.Point(182, 32)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btn_seleccionar.TabIndex = 0
        Me.btn_seleccionar.Text = "Seleccionar"
        Me.btn_seleccionar.UseVisualStyleBackColor = True
        '
        'lbl_seleccionar
        '
        Me.lbl_seleccionar.AutoSize = True
        Me.lbl_seleccionar.Location = New System.Drawing.Point(12, 37)
        Me.lbl_seleccionar.Name = "lbl_seleccionar"
        Me.lbl_seleccionar.Size = New System.Drawing.Size(112, 13)
        Me.lbl_seleccionar.TabIndex = 1
        Me.lbl_seleccionar.Text = "Seleccionar Imagenes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(109, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ancho"
        '
        'txtAlto
        '
        Me.txtAlto.Location = New System.Drawing.Point(37, 33)
        Me.txtAlto.Name = "txtAlto"
        Me.txtAlto.Size = New System.Drawing.Size(61, 20)
        Me.txtAlto.TabIndex = 4
        '
        'txtAncho
        '
        Me.txtAncho.Location = New System.Drawing.Point(153, 33)
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.Size = New System.Drawing.Size(61, 20)
        Me.txtAncho.TabIndex = 6
        '
        'gb_titulo
        '
        Me.gb_titulo.Controls.Add(Me.Label5)
        Me.gb_titulo.Controls.Add(Me.txtAlto)
        Me.gb_titulo.Controls.Add(Me.txtAncho)
        Me.gb_titulo.Controls.Add(Me.Label2)
        Me.gb_titulo.Controls.Add(Me.Label3)
        Me.gb_titulo.ForeColor = System.Drawing.Color.Blue
        Me.gb_titulo.Location = New System.Drawing.Point(15, 113)
        Me.gb_titulo.Name = "gb_titulo"
        Me.gb_titulo.Size = New System.Drawing.Size(242, 100)
        Me.gb_titulo.TabIndex = 7
        Me.gb_titulo.TabStop = False
        Me.gb_titulo.Text = "Redimensionar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(37, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 7
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(96, 219)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 8
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(52, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.gb_titulo)
        Me.Controls.Add(Me.lbl_seleccionar)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResizeImage"
        Me.gb_titulo.ResumeLayout(False)
        Me.gb_titulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opf_selec As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_seleccionar As System.Windows.Forms.Button
    Friend WithEvents lbl_seleccionar As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAlto As System.Windows.Forms.TextBox
    Friend WithEvents txtAncho As System.Windows.Forms.TextBox
    Friend WithEvents gb_titulo As System.Windows.Forms.GroupBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
