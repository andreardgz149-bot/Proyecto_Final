using System;
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

private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    //Piedra
    private void BtnPiedra_Click(object sender, RoutedEventArgs e)
    {
        Jugada = new Piedra();
        MessageBox.Show(juego.Jugar(Jugada));
    }

    //Papel
    private void BtnPapel_Click(object sender, RoutedEventArgs e)
    {
        Jugada = new Papel();
        MessageBox.Show(juego.Jugar(Jugada));
    }

    //Tijera
    private void BtnTijera_Click(object sender, RoutedEventArgs e)
    {
        Jugada = new Tijera();
        MessageBox.Show(juego.Jugar(Jugada));
    }

    //Lagarto
    private void BtnLagarto_Click(object sender, RoutedEventArgs e)
    {
        Jugada = new Lagarto();
        MessageBox.Show(juego.Jugar(Jugada));
    }

    //Spock
    private void BtnSpock_Click(object sender, RoutedEventArgs e)
    {
        Jugada = new Spock();
        MessageBox.Show(juego.Jugar(Jugada));
    }

}