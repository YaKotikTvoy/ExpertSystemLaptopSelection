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

        //Goal
        Route.Add(Goal2, Dimension);
        Route.Add(Goal35, Learn);
        Route.Add(Goal41, Job);
        GroupsRadioButton.Add(Goal, new List<RadioButton>{Goal2, Goal35, Goal41});

        //


    }
    private void StartButtonClick(object sender, RoutedEventArgs args){
        SwitchTabItem(Goal);
    }
    private void BackGreetingButton(object sender, RoutedEventArgs args){
        SwitchTabItem(Start);
    }
}