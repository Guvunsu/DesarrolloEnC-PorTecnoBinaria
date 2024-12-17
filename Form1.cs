using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void btn_Ok_Click(object sender, EventArgs e) {
            //video numero 12 https://www.youtube.com/watch?v=CrDqrwlOvxk&list=PL8gxzfBmzgexdFa0XZZSZZn2Ogx3j-Qd5&index=12

            //string textoDelTextbox = textBox1.Text; 
            //txt_Welcome.Text = textoDelTextbox;

            // video numero 13 https://www.youtube.com/watch?v=tg2MbXQQ_tc&list=PL8gxzfBmzgexdFa0XZZSZZn2Ogx3j-Qd5&index=14

            //try {
            //    byte textBox = Convert.ToByte(textBox1);
            //    txt_Welcome.Text = textBox.ToString();
            //} catch (OverflowException ex) {
            //    MessageBox.Show("Error en el tamaño del numero " + ex);
            //} catch (FormatException exx) {
            //    MessageBox.Show("Error en el formato " + exx);
            //}

            // video numero 14 https://www.youtube.com/watch?v=tg2MbXQQ_tc&list=PL8gxzfBmzgexdFa0XZZSZZn2Ogx3j-Qd5&index=14

            //try {
            //    string bienvenido = "bienvenido al curso C#";
            //    string texto = "hola" + textBox1.Text + bienvenido;
            //    txt_Welcome.Text = texto;
            //} catch (Exception x) {
            //    MessageBox.Show("Error : " + x);
            //}

            //Modifique el Form para que dejara de tener el Welcome en el label y le puse usuario, para luego
            // hacer el textbox2 y label2 usando ahora un texto lamado contraseña para que sirva el codigo de abajo
            // video numero 15 https://www.youtube.com/watch?v=sqv3Rg0G-DQ&list=PL8gxzfBmzgexdFa0XZZSZZn2Ogx3j-Qd5&index=15

            //    try {
            //        if (txt_usuario.Text == "Eduardo" & txt_contraseña.Text == "1234") {
            //            MessageBox.Show("Correcto,puedes pasar");
            //        } else {
            //            MessageBox.Show("Incorrecto,No puedes pasar");
            //        }
            //    } catch (Exception x) {
            //        MessageBox.Show("Error" + 1);
            //    }

            //video numero 16 https://www.youtube.com/watch?v=P1_MMS_IKjg&list=PL8gxzfBmzgexdFa0XZZSZZn2Ogx3j-Qd5&index=16

            string var_Usuario = txt_usuario.Text;
            string var_Contraseña = txt_contraseña.Text;

            try {
                if (var_Usuario != "Eduardo" & Convert.ToInt32(var_Contraseña) + 50 == 100) {
                    MessageBox.Show("Correcto,puedes pasar");
                } else {
                    MessageBox.Show("Incorrecto,No puedes pasar");
                }
            } catch (Exception x) {
                MessageBox.Show("Error" + 1);
            }

        }
    }
}

