using FlujoNetoSinFinanciamiento.core;
using FlujoNetoSinFinanciamiento.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlujoNetoSinFinanciamiento
{
    public partial class FNE : Form
    {
        DataTable dt = new DataTable();

        private FneRepository fneRepository;

        private int onePoint = 0;
        
        public FNE()
        {
            InitializeComponent();
            fneRepository = new FneRepository();
        }


        private System.Data.DataTable CreateTable(int count)
        {

            #region Validando los campos
            validarCampos(out decimal inversion, out int plazo, out decimal tasa, out decimal inflacion, out decimal vs, out decimal egresos, out decimal ingresos);
            #endregion

            #region Añadir Columnas
            /*
            dt.Columns.Add(" ", typeof(string));
            for (int i = 0; i <= count; i++)
            {
                dt.Columns.Add("" + i);
            }

            dgvFNE.DataSource = dt;
            */
            #endregion
            DataTable dt = new DataTable();
            dt.Columns.Add(" ");
            for (int i = 0; i <= plazo; i++)
            {
                dt.Columns.Add("" + i);
            }


            #region Agregando la Fila Inversion
            decimal[] fne = new decimal[plazo + 1];
            fne[0] = inversion;

            DataRow rowInversion = dt.NewRow();
            rowInversion[" "] = "Inversion";
            rowInversion["0"] = inversion;
            
            for (int k = 1; k <= plazo; k++)
            {
                rowInversion["" + k ] = "";
            }

            dt.Rows.Add(rowInversion);
            #endregion

            #region Agregando la fila de Ingresos
            DataRow rowIngresos = dt.NewRow();
            rowIngresos[" "] = "Ingresos";
            rowIngresos["1"] = ingresos;


            fne[1] = ingresos;
            decimal[] ingresosXAnio = new decimal[plazo];
            ingresosXAnio[0] = ingresos;

            for (int k = 2; k <= plazo; k++)
                {
                    rowIngresos["" + k] = ingresos * (decimal)(Math.Pow(1 + (double)inflacion / 100, k - 1));
                    fne[k] = ingresos * (decimal)(Math.Pow(1 + (double)inflacion / 100, k - 1));
                    ingresosXAnio[k - 1] = ingresos * (decimal)(Math.Pow(1 + (double)inflacion / 100, k - 1));
                }

            dt.Rows.Add(rowIngresos);
            #endregion

            #region Agregando la fila de Egresos
            DataRow rowEgresos = dt.NewRow();
            rowEgresos[" "] = "Egresos";
            rowEgresos["1"] = egresos;

            fne[1] -= egresos;
            for (int k = 2; k <= plazo; k++)
            {
                rowEgresos["" + k] = egresos * (decimal)(Math.Pow(1 + (double)inflacion / 100, k - 1));
                fne[k] -= egresos * (decimal)(Math.Pow(1 + (double)inflacion / 100, k - 1));
            }

            dt.Rows.Add(rowEgresos);
            #endregion

            #region Agregando la fila de Depreciacion (Negativa)
            DataRow rowDepreciacionNegativa = dt.NewRow();
            rowDepreciacionNegativa[" "] = "Depreciacion";

            decimal gastoDepreciacion = (inversion - vs) / plazo;
            for (int k = 1; k <= plazo; k++)
            {
                rowDepreciacionNegativa["" + k] = gastoDepreciacion;
                fne[k] -= gastoDepreciacion;
            }

            dt.Rows.Add(rowDepreciacionNegativa);
            #endregion

            #region Agregando la fila de Valor de Salvamento
            DataRow rowVSalvamento = dt.NewRow();
            rowVSalvamento[" "] = "V.SALVAMENTO";

            for (int k = 1; k <= plazo; k++)
            {
                if (k == plazo)
                {
                    rowVSalvamento["" + k] = vs;
                    fne[k] += vs;
                }
                else
                {
                    rowVSalvamento["" + 1] = "-";
                }
            }

            dt.Rows.Add(rowVSalvamento);
            #endregion

            #region Agregando la fila de la Utilidad Antes de Impuesto
            DataRow rowUtilidadAI = dt.NewRow();
            rowUtilidadAI[" "] = "U.A.I";
            dt.Rows.Add(rowUtilidadAI);
            rowUtilidadAI["0"] = "-";

            for (int k = 1; k < plazo; k++)
            {
                rowUtilidadAI["" + k] = fne[k];
            }
            #endregion

            #region Agregando la fila del IR
            DataRow rowIR = dt.NewRow();
            rowIR[" "] = "IR";

            double[] ir = new double[plazo];
            for (int k = 1; k < plazo; k++)
            {
                if (fne[k] > 0)
                {
                    rowIR["" + k] = (double)fne[k] * 0.3;
                    ir[k - 1] = (double)fne[k] * 0.3;
                }
                else
                {
                    rowIR["" + 1] = 0;
                    ir[k - 1] = 0;
                }
            }

            dt.Rows.Add(rowIR);
            #endregion

            #region Agregando la fila de la Utilidad Despues de Impuestos
            DataRow rowUtilidadDI = dt.NewRow();
            rowUtilidadDI[" "] = "U.D.I";

            for (int k = 1; k < plazo; k++)
            {
                rowUtilidadDI["" + k] = fne[k] - (decimal)ir[k - 1];
                fne[k] -= (decimal)ir[k - 1];
            }

            dt.Rows.Add(rowUtilidadDI);
            #endregion

            #region Agregando la fila de Depreciacion (Positiva)
            DataRow rowDepreciacionPositiva = dt.NewRow();
            rowDepreciacionPositiva[" "] = "Depreciacion";

            for (int k = 1; k <= plazo; k++)
            {
                rowDepreciacionPositiva["" + k] = gastoDepreciacion;
                fne[k] += gastoDepreciacion;
            }

            dt.Rows.Add(rowDepreciacionPositiva);
            #endregion

            #region Agregando la fila del FNE
            DataRow rowFNE = dt.NewRow();
            rowFNE[" "] = "FNE";
            rowFNE["0"] = inversion;

            for (int k = 1; k < plazo; k++)
            {
                rowFNE["" + k] = fne[k];
            }

            dt.Rows.Add(rowFNE);
            #endregion

            dgvFNE.DataSource = dt;

            #region Agregando la funcion del VPN
            double sumaIngresos = 0;

            for (int anio = 1; anio <= plazo; anio++)
            {
                decimal ing = fne[anio];
                Console.WriteLine(ing);
                sumaIngresos += (double)ing * Math.Pow(1 + (double)tasa / 100, -anio);
            }

            txtVPN.Text = (sumaIngresos - (double)inversion) + "";

            #endregion

            return dt;
        }


        private void BtnCrear_Click(object sender, EventArgs e)
        {

            int count = dt.Columns.Count;
            CreateTable(count);


            this.dgvFNE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFNE.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void sendidngData()
        {
            decimal inversion = Convert.ToDecimal(txtInversion.Text);
            decimal ingresos = Convert.ToDecimal(txtIngresos.Text);
            decimal egresos = Convert.ToDecimal(txtEgresos.Text);
            decimal plazo = Convert.ToDecimal(txtPlazo.Text);
            int tasa = Convert.ToInt32(txtTasa.Text);
            decimal inflacion = Convert.ToDecimal(txtInflacion.Text);
            decimal vSalvamento = Convert.ToDecimal(txtVS.Text);

            Fne fneElements = new Fne()
            {
                Inversion = inversion,
                Ingresos = ingresos,
                Egresos = egresos,
                Plazo = (int)plazo,
                Tasa = tasa,
                Inflacion = inflacion,
                ValorSalvamento = vSalvamento
            };

            fneRepository.Create(fneElements);

        }

        #region Sending Data to the MDIPARENT
        public decimal formInversion;
        public decimal formIngresos;
        public decimal formEgresos;
        public int formPlazo;
        public decimal formTasa;
        public decimal formInflacion;
        public decimal formValorSalvamento;
        public void SendDataToMdiParent()
        {
            formInversion = Convert.ToDecimal(txtInversion.Text);
            formIngresos = Convert.ToDecimal(txtIngresos.Text);
            formEgresos = Convert.ToDecimal(txtEgresos.Text);
            formPlazo = Convert.ToInt32(txtPlazo.Text);
            formTasa = Convert.ToDecimal(txtTasa.Text);
            formInflacion = Convert.ToDecimal(txtInflacion.Text);
            formValorSalvamento = Convert.ToDecimal(txtVS.Text);
        }

        #endregion

        #region Validando CampoMientras with keyDown
        public void ValidateTextFields(KeyPressEventArgs e, int validate)
        {
            
            if (validate == 0)
            {
                if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    MessageBox.Show("Solo números", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void TxtInversion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextFields(e,0);
            if (e.KeyChar == 46)
            {
                onePoint++;
                if (onePoint == 0 || onePoint > 1)
                {
                    MessageBox.Show("No mas de un punto '.'", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void TxtIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextFields(e,0);
            if (e.KeyChar == 46)
            {
                onePoint++;
                if (onePoint == 0 || onePoint > 1)
                {
                    MessageBox.Show("No mas de un punto '.'", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void TxtEgresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextFields(e, 0);
            if (e.KeyChar == 46)
            {
                onePoint++;
                if (onePoint == 0 || onePoint > 1)
                {
                    MessageBox.Show("No mas de un punto '.'", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void TxtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextFields(e, 0);
            if (e.KeyChar == 46)
            {
                onePoint++;
                if (onePoint == 0 || onePoint > 1)
                {
                    MessageBox.Show("No mas de un punto '.'", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void TxtTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextFields(e, 0);
            if (e.KeyChar == 46)
            {
                onePoint++;
                if (onePoint == 0 || onePoint > 1)
                {
                    MessageBox.Show("No mas de un punto '.'", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void TxtInflacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextFields(e, 0);
            if (e.KeyChar == 46)
            {
                onePoint++;
                if (onePoint == 0 || onePoint > 1)
                {
                    MessageBox.Show("No mas de un punto '.'", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void TxtVS_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextFields(e, 0);
            if (e.KeyChar == 46)
            {
                onePoint++;
                if (onePoint == 0 || onePoint > 1)
                {
                    MessageBox.Show("No mas de un punto '.'", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        #endregion

        private void validarCampos(out decimal inversion, out int plazo, out decimal tasa, out decimal inflacion, out decimal vs, out decimal egresos, out decimal ingresos)
        {
            if (!decimal.TryParse(txtInversion.Text, out decimal inv))
                MessageBox.Show($"El valor {txtInversion.Text} es invalido");
            inversion = inv;

            if (!int.TryParse(txtPlazo.Text, out int plaz))
                MessageBox.Show($"El valor {txtPlazo.Text} es invalido");
            plazo = plaz;

            if (!decimal.TryParse(txtTasa.Text, out decimal tas))
                MessageBox.Show($"El valor {txtTasa.Text} es invalido");
            tasa = tas;

            if (!decimal.TryParse(txtInflacion.Text, out decimal inf))
                MessageBox.Show($"El valor {txtInflacion.Text} es invalido");
            inflacion = inf;

            if (!decimal.TryParse(txtVS.Text, out decimal vr))
                MessageBox.Show($"El valor {txtVS.Text} es invalido");
            vs = vr;

            if (!decimal.TryParse(txtEgresos.Text, out decimal eg))
                MessageBox.Show($"El valor {txtEgresos.Text} es invalido");
            egresos = eg;
            if (!decimal.TryParse(txtIngresos.Text, out decimal ig))
                MessageBox.Show($"El valor {txtIngresos.Text} es invalido");
            ingresos = ig;
        }
    }
}
