Imports System.Data.OleDb

Public Class Form1
    ' Estructura para almacenar los datos del producto
    Private Structure Producto
        Dim Nombre As String
        Dim Precio As Decimal
        Dim Stock As Integer
    End Structure

    ' Diccionario para almacenar los productos usando IdProducto como clave
    Private productos As New Dictionary(Of String, Producto)

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim rutaExcel As String = "C:\Users\alumnos.republica\Desktop\Archivo\Lista.xls"
            If Not IO.File.Exists(rutaExcel) Then
                MessageBox.Show("El archivo Excel no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim conexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & rutaExcel & ";Extended Properties='Excel 8.0;HDR=Yes'"
            Using conn As New OleDbConnection(conexion)
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT * FROM [listado de productos$]", conn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                cmbProductos.Items.Clear()
                productos.Clear()
                While reader.Read()
                    Dim idProducto As String = reader(0).ToString() ' Columna A: IdProducto
                    Dim nombreProducto As String = reader(1).ToString() ' Columna B: NombreProducto
                    Dim precio As Decimal = Convert.ToDecimal(reader(5)) ' Columna F: PrecioUnidad
                    Dim stock As Integer = Convert.ToInt32(reader(6)) ' Columna G: UnidadesEnExistencia
                    productos.Add(idProducto, New Producto With {.Nombre = nombreProducto, .Precio = precio, .Stock = stock})
                    cmbProductos.Items.Add(idProducto)
                End While
            End Using
            btnCargar.Enabled = False ' Bloquear el botón después de cargar
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        If cmbProductos.SelectedItem IsNot Nothing Then
            Dim idProducto As String = cmbProductos.SelectedItem.ToString()
            If productos.ContainsKey(idProducto) Then
                Dim prod = productos(idProducto)
                detalleProducto.Text = prod.Nombre ' Label para mostrar el nombre del producto
                txtDescripcion.Text = prod.Nombre
                txtPrecio.Text = "$" & prod.Precio.ToString("N0")
                txtStock.Text = prod.Stock.ToString()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        txtDescripcion.ReadOnly = True
        txtPrecio.ReadOnly = True
        txtStock.ReadOnly = True
    End Sub
End Class
