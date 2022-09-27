using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace WindowsService6
{
    public partial class Service1 : ServiceBase

    {
        public System.Timers.Timer TimerServicio = new System.Timers.Timer();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Día-Hora.txt");
            string dia = lines[0];
            string hora = lines[1];
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            String horaAct = DateTime.Now.ToString("HH:mm");

            TimerServicio = new System.Timers.Timer();
            TimerServicio.Elapsed += (_, __) => EjecutaUnaAccion();

            switch (dia)
            {
                case "Lunes":
                    if (wk == DayOfWeek.Monday)
                        do
                        {
                            horaAct = DateTime.Now.ToString("HH:mm");
                            TimerServicio.Interval = 5000;
                        } while (horaAct != hora);
                    TimerServicio.Start();
                    break;
                case "Martes":
                    if (wk == DayOfWeek.Tuesday)
                        do
                        {
                            horaAct = DateTime.Now.ToString("HH:mm");
                            TimerServicio.Interval = 5000;
                        } while (horaAct != hora);
                    TimerServicio.Start();
                    break;
                case "Miercoles":
                    if (wk == DayOfWeek.Wednesday)
                        do
                        {
                            horaAct = DateTime.Now.ToString("HH:mm");
                            TimerServicio.Interval = 5000;
                        } while (horaAct != hora);
                    TimerServicio.Start();
                    break;
                case "Jueves":
                    if (wk == DayOfWeek.Thursday)
                        do
                        {
                            horaAct = DateTime.Now.ToString("HH:mm");
                            TimerServicio.Interval = 5000;
                        } while (horaAct != hora);
                    TimerServicio.Start();
                    break;
                case "Viernes":
                    if (wk == DayOfWeek.Friday)
                        do
                        {
                            horaAct = DateTime.Now.ToString("HH:mm");
                            TimerServicio.Interval = 5000;
                        } while (horaAct != hora);
                    TimerServicio.Start();
                    break;
                case "Sábado":
                    if (wk == DayOfWeek.Saturday)
                        do
                        {
                            horaAct = DateTime.Now.ToString("HH:mm");
                            TimerServicio.Interval = 5000;
                        } while (horaAct != hora);
                    TimerServicio.Start();
                    break;
                case "Domingo":
                    if (wk == DayOfWeek.Sunday)
                        do
                        {
                            horaAct = DateTime.Now.ToString("HH:mm");
                            TimerServicio.Interval = 5000;
                        } while (horaAct != hora);
                    TimerServicio.Start();
                    break;
            }
        }
        public void EjecutaUnaAccion()
        {
            int i;
            for (i = 1; i <= 15; i++)
            {
                File.AppendAllText(@"C:\WindowsService6\bin\Debug\InformeC#.TXT", "Línea C# N° " + i + System.Environment.NewLine);
            }
            TimerServicio.Close();
        }
        protected override void OnStop()
        {
            TimerServicio.Close();
        }
        protected override void OnPause()
        {
            TimerServicio.Stop();
        }
        protected override void OnContinue()
        {
            TimerServicio.Start();
        }
    }
}
