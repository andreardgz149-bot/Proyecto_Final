using System;
using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Proyectof.Models;
using Proyectof.Strategies;

namespace Proyectof;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    IJugada Jugada;
    private Juego juego;
    
    public MainWindow()
    {
        InitializeComponent();

        juego = new Juego();
    }

    //Gif

   private void MostrarVideo(string archivo)
{
    string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Videos", archivo);
    GifMediaElement.Source = new Uri(path);
    GifMediaElement.LoadedBehavior = MediaState.Manual;
    GifMediaElement.UnloadedBehavior = MediaState.Manual;
    GifMediaElement.Stop();
    GifMediaElement.Play();
}

    private void MostrarResultadoVideo(string resultado)
    {
        if (resultado.Contains("Gana"))
            {MostrarVideo("ganar.mp4");}
        else 
        if (resultado.Contains("Pierde"))
            {MostrarVideo("perder.mp4");}
        else
           {MostrarVideo("empate.mp4");}
    }




    //Piedra
    private void BtnPiedra_Click(object sender, RoutedEventArgs e)
    {
       Jugada = new Piedra();

    string resultado = juego.Jugar(Jugada);

    MessageBox.Show(resultado);

    MostrarResultadoVideo(resultado);
    }

    //Papel
    private void BtnPapel_Click(object sender, RoutedEventArgs e)
    {
        Jugada = new Papel();
        string resultado = juego.Jugar(Jugada);
        MessageBox.Show(resultado);
        MostrarResultadoVideo(resultado);
    }

    //Tijera
    private void BtnTijera_Click(object sender, RoutedEventArgs e)
    {
        Jugada = new Tijera();
        string resultado = juego.Jugar(Jugada);
        MessageBox.Show(resultado);
        MostrarResultadoVideo(resultado);
    }

    //Lagarto
    private void BtnLagarto_Click(object sender, RoutedEventArgs e)
    {
        Jugada = new Lagarto();
        string resultado = juego.Jugar(Jugada);
        MessageBox.Show(resultado);
        MostrarResultadoVideo(resultado);
    }

    //Spock
    private void BtnSpock_Click(object sender, RoutedEventArgs e)
    {
        Jugada = new Spock();
        string resultado = juego.Jugar(Jugada);
        MessageBox.Show(resultado);
        MostrarResultadoVideo(resultado);
    }

}