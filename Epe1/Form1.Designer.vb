<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'Limpiar recursos
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Diseño del formulario
    Private Sub InitializeComponent()
        cmbProductos = New ComboBox()
        btnCargar = New Button()
        txtDescripcion = New TextBox()
        txtPrecio = New TextBox()
        txtStock = New TextBox()
        lblProducto = New Label()
        lblDescripcion = New Label()
        lblPrecio = New Label()
        lblStock = New Label()
        Label1 = New Label()
        Label2 = New Label()
        detalleProducto = New Label()
        SuspendLayout()
        ' 
        ' cmbProductos
        ' 
        cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(199, 96)
        cmbProductos.Margin = New Padding(4, 3, 4, 3)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(233, 23)
        cmbProductos.TabIndex = 0
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(199, 34)
        btnCargar.Margin = New Padding(4, 3, 4, 3)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(175, 27)
        btnCargar.TabIndex = 1
        btnCargar.Text = "Cargar datos al combo"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(22, 260)
        txtDescripcion.Margin = New Padding(4, 3, 4, 3)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.ReadOnly = True
        txtDescripcion.Size = New Size(156, 23)
        txtDescripcion.TabIndex = 2
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(199, 260)
        txtPrecio.Margin = New Padding(4, 3, 4, 3)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.ReadOnly = True
        txtPrecio.Size = New Size(116, 23)
        txtPrecio.TabIndex = 3
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(351, 260)
        txtStock.Margin = New Padding(4, 3, 4, 3)
        txtStock.Name = "txtStock"
        txtStock.ReadOnly = True
        txtStock.Size = New Size(119, 23)
        txtStock.TabIndex = 4
        ' 
        ' lblProducto
        ' 
        lblProducto.AutoSize = True
        lblProducto.Location = New Point(22, 99)
        lblProducto.Margin = New Padding(4, 0, 4, 0)
        lblProducto.Name = "lblProducto"
        lblProducto.Size = New Size(169, 15)
        lblProducto.TabIndex = 5
        lblProducto.Text = "Selecc. el codigo del producto "
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Location = New Point(22, 227)
        lblDescripcion.Margin = New Padding(4, 0, 4, 0)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(122, 15)
        lblDescripcion.TabIndex = 6
        lblDescripcion.Text = "Nombre del producto"
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Location = New Point(199, 227)
        lblPrecio.Margin = New Padding(4, 0, 4, 0)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(111, 15)
        lblPrecio.TabIndex = 7
        lblPrecio.Text = "Precio del producto"
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.Location = New Point(351, 227)
        lblStock.Margin = New Padding(4, 0, 4, 0)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(107, 15)
        lblStock.TabIndex = 8
        lblStock.Text = "Stock del Producto"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 40)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 15)
        Label1.TabIndex = 9
        Label1.Text = "Boton de cargar C.Box"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 15)
        Label2.TabIndex = 10
        Label2.Text = "Detalle Producto"
        ' 
        ' detalleProducto
        ' 
        detalleProducto.AutoSize = True
        detalleProducto.Location = New Point(192, 157)
        detalleProducto.Name = "detalleProducto"
        detalleProducto.Size = New Size(0, 15)
        detalleProducto.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(544, 328)
        Controls.Add(detalleProducto)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblStock)
        Controls.Add(lblPrecio)
        Controls.Add(lblDescripcion)
        Controls.Add(lblProducto)
        Controls.Add(txtStock)
        Controls.Add(txtPrecio)
        Controls.Add(txtDescripcion)
        Controls.Add(btnCargar)
        Controls.Add(cmbProductos)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "EPE1 - Inventario Supermercado"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents detalleProducto As Label
End Class
