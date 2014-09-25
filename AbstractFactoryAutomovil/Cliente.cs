using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbstractFactoryAutomovil.mundo.clases;
using AbstractFactoryAutomovil.mundo.fabricas;
using AbstractFactoryAutomovil.mundo.interfaces;

namespace AbstractFactoryAutomovil
{
    public partial class Cliente : Form
    {
        private IFabricaPartes fabrica;
        private IAuto auto;
        private IMotor motor;
        private ICarroceria carroceria;

        public Cliente()
        {
            InitializeComponent();
            lst_partes.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (rad_mazda.Checked)
                fabrica = new FabricaMazda();
            else if (rad_renault.Checked)
                fabrica = new FabricaRenault();
            else if (radKia.Checked)
                fabrica = new FabricaKia();


            auto = fabrica.crearAuto();
            motor = fabrica.crearMotor();
            carroceria = fabrica.crearCarroceria();
            if (lst_partes.SelectedIndex == 0)
                MessageBox.Show(auto.darNombre());
            else if (lst_partes.SelectedIndex == 1)
                MessageBox.Show(motor.darNombre());
            else if (lst_partes.SelectedIndex == 2)
                MessageBox.Show(carroceria.darNombre());


        }
    }
}
