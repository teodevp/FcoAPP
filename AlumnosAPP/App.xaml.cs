﻿using AlumnosAPP.Vistas;
using Microsoft.Maui.Controls;

namespace AlumnosAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListarAlumnos());
        }
    }
}