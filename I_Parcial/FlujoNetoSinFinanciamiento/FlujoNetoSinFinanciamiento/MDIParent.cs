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
    public partial class MDIParent : Form
    {
        FNE fne = new FNE();

        Fne flujo = new Fne();

        private FneRepository fneRepository;
        public MDIParent()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNE formFne = new FNE();
            formFne.MdiParent = this;
            formFne.Show();
        }

        public void loadData(Fne flujo, string valores)
        {
            
        }
        private void SaveProyectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Comentado
            //Fne fneElements = new Fne();
            //decimal inversion = fne.formInversion;
            //decimal ingresos = fne.formIngresos;
            //decimal egresos = fne.formEgresos;
            //int plazo = fne.formPlazo;
            //decimal tasa = fne.formTasa;
            //decimal inflacion = fne.formInflacion;
            //decimal valorSalvamento = fne.formValorSalvamento;

            //Fne fneElement = new Fne()
            //{
            //    Inversion = inversion,
            //    Ingresos = ingresos,
            //    Egresos = egresos,
            //    Plazo = plazo,
            //    Tasa = tasa,
            //    Inflacion = inflacion,
            //    ValorSalvamento = valorSalvamento
            //};

            //fneRepository.Create(flujo);
            #endregion

            fne.sendidngData();

            MessageBox.Show("Proyecto Guardado, Cambios Guardados :)");
        }

        private void DeleteProyectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
