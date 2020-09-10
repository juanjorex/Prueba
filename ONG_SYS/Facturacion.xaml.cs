using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Capa_de_Negocios_ONG_SYS;
namespace ONG_SYS
{
    /// <summary>
    /// Lógica de interacción para Facturacion.xaml
    /// </summary>
    public partial class Facturacion : Window
    {
        public bool variableCF = false;
        public bool esProducto = false;
        public string  idF= null;
        public string idCliente = null;
        CN_facturacion factura = new CN_facturacion();
        CN_Clientes clientes = new CN_Clientes();
        FRM_Buscar_Producto buscarProducto;
        FRM_Buscar_Servicios buscar_Servicio;
        FRM_NuevoCliente nuevoCliente;
        DataTable detalleFactura;
        public Facturacion()
        {
            InitializeComponent();
            buscarProducto = new FRM_Buscar_Producto(this);
            buscar_Servicio = new FRM_Buscar_Servicios(this);
            InicializarDetalle();
        }

        private void InicializarDetalle()
        {
            detalleFactura = new DataTable();
            detalleFactura.Columns.Add(new DataColumn("Tipo", typeof(string)));
            detalleFactura.Columns.Add(new DataColumn("Nombre", typeof(string)));
            detalleFactura.Columns.Add(new DataColumn("Cantidad", typeof(string)));
        }
        
        private void MostrarDetalle()
        {

            DT_Facturacion.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = factura.MostrarDetalle() });

        }
        //private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        //{
        //    MostrarDetalle();
        //}

        private void btnSel_Click_1(object sender, RoutedEventArgs e)
        {
            ListaClientesFactura listaC = new ListaClientesFactura(this);

            listaC.ShowDialog();
        }

        private void btnRs_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FRM_MENU_PRINCIPAL paginaanteriorP = new FRM_MENU_PRINCIPAL();
            paginaanteriorP.ShowDialog();
            this.Close();
        }




        //private void btnCF_Click(object sender, RoutedEventArgs e)
        //{
            
        //    if (variableCF == false)
        //    {
        //        FMR_AUTENTICACION au = new FMR_AUTENTICACION();
        //        try
        //        {
        //            objecF.CrearFactura(idF, au.valorid);
        //            MessageBox.Show("Se ha creado una factura");



        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("No es posible crear la factura por :" + ex);

        //        }



        //    }
        //    else { MessageBox.Show("Verifique sus datos"); }

        //}

        private void btnCF_Click_1(object sender, RoutedEventArgs e)
        {
            var idUsuario = FMR_AUTENTICACION.GetInstancia();
            int id = factura.CrearFactura(idCliente, idUsuario.valorid);
            MessageBox.Show("" + id);
        }

        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            string identificacion = txtCedula.Text;
            bool esCedula = identificacion.Length == 10;
            if (esCedula)
            {
                identificacion = identificacion + "001";
            }
            if (VERIFICA_IDENTIFICACION.VerificaIdentificacion(identificacion) == false || identificacion.Length < 13)
            {
                MessageBox.Show("Verifique identificación del cliente");
                return;
            }
            else {
                DataTable respuesta = clientes.BuscarPorCedula(txtCedula.Text);
                if (respuesta.Rows.Count > 0)
                {
                    var fila = respuesta.Rows[0].ItemArray;
                    idCliente = fila[0].ToString();
                    txtNombre.Text = fila[1].ToString();
                    txtTelefono.Text = fila[3].ToString();
                    txtDireccion.Text = fila[4].ToString();
                    txtCorreo.Text = fila[5].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente no registrado, proceda a ingresar sus datos");
                    nuevoCliente = new FRM_NuevoCliente(this);
                    if (esCedula) {
                        nuevoCliente.cmb_tipocliente.SelectedIndex = 0;
                    }
                    else
                    {
                        nuevoCliente.cmb_tipocliente.SelectedIndex = 1;
                    }
                    nuevoCliente.TXT_IDENTIFICACION_CLIENTE.Text = txtCedula.Text;
                    nuevoCliente.ShowDialog();
                }
            }
        }

        private void txtCedula_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void txtTelefono_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void txtNombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z]"))
            {
                e.Handled = true;
            }
        }

        private void btn_AgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            buscarProducto = new FRM_Buscar_Producto(this);
            buscarProducto.ShowDialog();
        }

        private void btn_agregarServicio_Click(object sender, RoutedEventArgs e)
        {
            buscar_Servicio = new FRM_Buscar_Servicios(this);
            buscar_Servicio.ShowDialog();
        }

        private void txt_cantidad_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void btn_agregarDetalle_Click(object sender, RoutedEventArgs e)
        {
            DataRow nuevoDetalle = detalleFactura.NewRow();
            if (esProducto)
            {
                nuevoDetalle["Tipo"] = "Producto";
            }
            else
            {
                nuevoDetalle["Tipo"] = "Servicio";
            }
            nuevoDetalle["Nombre"] = txt_producto.Text;
            nuevoDetalle["Cantidad"] = txt_cantidad.Text;
            detalleFactura.Rows.Add(nuevoDetalle);
            DT_Facturacion.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = detalleFactura });
        }
    }
}
