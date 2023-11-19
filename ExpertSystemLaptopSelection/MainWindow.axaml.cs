using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ExpertSystemLaptopSelection;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        SwitchTabItem(Start);

        //1 - Goal
        Route.Add(Goal2, Dimension);
        Route.Add(Goal35, Learn);
        Route.Add(Goal41, Job);
        GroupsRadioButton.Add(Goal, new List<RadioButton>{Goal2, Goal35, Goal41});

        //2 - Dimension
        Route.Add(Dimension3,CountPlayer2);
        Route.Add(Dimension12,CountPlayer1);
        GroupsRadioButton.Add(Dimension, new List<RadioButton>{Dimension3, Dimension12});

        //3 - CountPlayer2
        Route.Add(CountPlayer2_4, Genre3);
        Route.Add(CountPlayer2_5, Genre4);
        GroupsRadioButton.Add(CountPlayer2, new List<RadioButton>{CountPlayer2_4, CountPlayer2_5});

        //4 - Genre3
        Route.Add(Genre3_10, Platformer);
        Route.Add(Genre3_11, TowerDefence);
        Route.Add(Genre3_7, Economic);
        GroupsRadioButton.Add(Genre3, new List<RadioButton>{Genre3_10, Genre3_11, Genre3_7});

    }
    private void StartButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Goal);
    private void BackGreetingButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Start);
    private void BackGoalButtonClicked(object sender, RoutedEventArgs args) => SwitchTabItem(Goal);
    private void BackDimensionButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Dimension);
    private void BackCountPlayer2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CountPlayer2);
}