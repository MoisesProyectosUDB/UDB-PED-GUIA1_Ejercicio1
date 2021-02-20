using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiaPractica1
{
    public partial class Form1 : Form
    {
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.White);

            Random rdn = new Random(); //Instancia de Random    
            int ValoraDibujar = rdn.Next(0, 8); //obtenemos el valor y el rango de los mismos
            // Console.WriteLine("Valor Random" + ValoraDibujar);
            int index = listBox1.Items.Count;
            if (index <= ValoraDibujar)
                //MessageBox.Show("Item is not available in ListBox2");
                Console.WriteLine("Valor Random no Encontrado" + ValoraDibujar);
               else
               listBox1.SetSelected(ValoraDibujar, true);//Truco , seteamos el valor de la lsita para poder hacer la comparacnion

            if (listBox1.SelectedIndex == ValoraDibujar)
            {
                //string textoLista = listBox1.Items[ValoraDibujar].ToString();
                //Console.WriteLine("Valor Random" + ValoraBuscar + "Texto Lista" + textoLista);


                if (listBox1.SelectedIndex == 0)
                {
                    SolidBrush sb = new SolidBrush(Color.Aqua);//Color
                    g.DrawEllipse(lapiz, x - 50, y - 50, 250, 250);//Marco
                    g.FillEllipse(sb, x - 50, y - 50, 250, 250);//Relleno


                }
                if (listBox1.SelectedIndex == 1)
                {
                    SolidBrush sb = new SolidBrush(Color.Brown);
                    g.DrawRectangle(lapiz, x - 50, y - 50, 150, 150);
                    g.FillRectangle(sb, x - 50, y - 50, 150, 150);

                }
                if (listBox1.SelectedIndex == 2)
                {
                    
                    Point[] punto = { new Point(x-10, x-25), new Point(x - 10, x - 500), new Point(x - 80, x-75) };// se establecen los puntos  e igual que los demas se  toma como base el clic del mouse
                    g.DrawCurve(Pens.Red , punto);
                    
                    

                }
                if (listBox1.SelectedIndex == 3)
                {
                   
                    Point[] punto1 = { new Point(x - 30, x-45), new Point(x - 150, x - 400), new Point(x - 45, x - 40) };// se establecen los puntos  e igual que los demas se  toma como base el clic del mouse
                    g.DrawPolygon(Pens.BlueViolet, punto1);
                   

                }


            }
          

          



        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = punto.X;//Posicion de X
            y = punto.Y;//Posicion de Y
            panel1.Invalidate();
        }
    }
}
