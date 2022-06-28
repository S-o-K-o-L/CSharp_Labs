﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Lab_5
{
    class ModelDrawer
    {
        private readonly Bitmap bitmap;
        private readonly Graphics graphics;
        private readonly Timer timer;

        public ModelDrawer(PictureBox pictureBox, Image backgroundImage, List<Object> objects, object objectsLocker, List<ViewModel> models, object modelsLocker)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            timer = new Timer
            {
                Interval = 30
            };
            timer.Tick += new EventHandler((obj, e) =>
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(backgroundImage, 0, 0);

                lock (objectsLocker)
                {
                    foreach (Object ob in objects)
                    {
                        Draw(ob);
                    }
                }

                lock (modelsLocker)
                {
                    foreach (ViewModel mo in models)
                    {
                        Draw(mo);
                    }
                }

                pictureBox.Image = bitmap;
            });
        }

        private void Draw(Object obj) => graphics.DrawImage(obj.Image, (float)obj.X - obj.Image.Width / 2, (float)obj.Y - obj.Image.Height / 2);

        public void Start() => timer.Start();

        public void Stop() => timer.Stop();
    }
}
