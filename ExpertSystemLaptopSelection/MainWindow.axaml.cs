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
        InitializeGroupsRadioButtonAndRoute();
    }
    private void StartButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Goal);
    private void BackGreetingButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Start);
    private void BackGoalButtonClicked(object sender, RoutedEventArgs args) => SwitchTabItem(Goal);
    private void BackDimensionButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Dimension);
    private void BackCountPlayer2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CountPlayer2);
    private void BackGenre4ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Genre4);
    private void BackGenre3ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Genre3);
    private void BackCountPlayer1ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CountPlayer1);
    private void BackGenre2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Genre2);
    private void BackActionButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Action);
    private void BackSimulatorButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Simulator);
    private void BackTypeSimulatorButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(TypeSimulator);
    private void BackTypeArcadeButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(TypeArcade);
    private void BackGenre1ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Genre1);
    private void BackTypeStrategyButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(TypeStrategy);
    private void BackTypeRPGButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(TypeRPG);
    private void BackLearnButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Learn);
    private void BackLearnTargetButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(LearnTarget);
    private void BackJobButtonClicked(object sender, RoutedEventArgs args) => SwitchTabItem(Job);
    private void BackBackAreaWork3ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AreaWork3);
    private void BackBackAreaWork2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AreaWork2);
    private void BackBackAreaWork1ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AreaWork1);
}