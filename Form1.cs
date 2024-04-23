using NNPG2_2024_Uloha_06_Bajer_Lukas;
using NNPG2_2024_Uloha_06_Bajer_Lukas.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNPG2_2024_Uloha_06_Bajer_Lukas
{
    public partial class Form1 : Form
    {
        List<MovableIntercativeAnimatedImageObject> objects = new List<MovableIntercativeAnimatedImageObject>();
        Point MouseCoordinates = Point.Empty;
        Timer timer = new Timer();
        Random rand = new Random();
        Image backgroundImage = Image.FromFile("MOCAL.JPG");
        MosquitoImagesInicializator MosImgInit = new MosquitoImagesInicializator();
        bool doubleBuffering = false;
        bool HQInterpolation = false;
        Stopwatch drawTimer = new Stopwatch();



        public Form1()
        {
            InitializeComponent();
            objects.Add(new Mosquito(MosImgInit.aliveImages, MosImgInit.deadFallingImages, MosImgInit.deadOnTheGroundImages, panel1, rand.Next(0, panel1.Width), rand.Next(0, panel1.Height), 100));
            objects.Add(new Mosquito(MosImgInit.aliveImages, MosImgInit.deadFallingImages, MosImgInit.deadOnTheGroundImages, panel1, rand.Next(0, panel1.Width), rand.Next(0, panel1.Height), 100));

            panel1.Paint += Form1_Paint;
            panel1.MouseMove += Form1_MouseMove;
            panel1.MouseClick += Form1_MouseClick;

            timer.Interval = 16; 
            timer.Tick += (sender, e) => panel1.Invalidate(); 
            timer.Start();

            UseDoubleBuffering.Checked = !doubleBuffering;
            useHQInterpolation.Checked = !HQInterpolation;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var obj in objects)
            {
                if (obj.Contains(MouseCoordinates))
                {
                    if (obj is Mosquito mosquito)
                    {
                        mosquito.ChangeState("deadFaling");
                    }
                    return;
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseCoordinates = new Point(e.X, e.Y);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawTimer.Restart();

            if (HQInterpolation)
            {
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            }
            else
            {
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            }
            e.Graphics.DrawImage(backgroundImage, 0, 0, panel1.Width, panel1.Height);

            foreach (var obj in objects)
            {
                obj.Update();
                obj.Draw(e.Graphics);
            }

            drawTimer.Stop();

            TimerLabel.Text = $"Čas Vykreslení: {drawTimer.ElapsedMilliseconds} ms";
            AliveLabel.Text = "Celkem živých: " + objects.OfType<Mosquito>().Where(m => m.state == "alive").ToList().Count();
            DeadLabel.Text = "Celkem mrtvých: " + objects.OfType<Mosquito>().Where(m => m.state == "deadOnTheGround").ToList().Count(); ;
        }

        private void SpawnNext_Click(object sender, EventArgs e)
        {
            objects.Add(new Mosquito(MosImgInit.aliveImages, MosImgInit.deadFallingImages, MosImgInit.deadOnTheGroundImages, panel1, rand.Next(0, panel1.Width), rand.Next(0, panel1.Height), 100));
        }

        private void CleanDead_Click(object sender, EventArgs e)
        {
            var deadMosquitoes = objects.OfType<Mosquito>().Where(m => m.state == "deadOnTheGround").ToList();

            foreach (var deadMosquito in deadMosquitoes)
            {
                objects.Remove(deadMosquito);
            }
        }

        private void UseDoubleBuffering_CheckedChanged(object sender, EventArgs e)
        {
            doubleBuffering = !doubleBuffering;

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
             | BindingFlags.Instance | BindingFlags.NonPublic, null,
             panel1, new object[] { doubleBuffering });
        }

        private void useHQInterpolation_CheckedChanged(object sender, EventArgs e)
        {
            HQInterpolation = !HQInterpolation;
        }

        private void SpawnHundered_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                objects.Add(new Mosquito(MosImgInit.aliveImages, MosImgInit.deadFallingImages, MosImgInit.deadOnTheGroundImages, panel1, rand.Next(0, panel1.Width), rand.Next(0, panel1.Height), 100));
            }
        }
    }
}
