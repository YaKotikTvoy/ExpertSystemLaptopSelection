using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ExpertSystemLaptopSelection;

public partial class MainWindow : Window
{
    /// <summary>
    /// Отражает какому TabItem соответсвует набор радиокнопок 
    /// </summary>
    private Dictionary<TabItem, List<RadioButton>> GroupsRadioButton = new();
    /// <summary>
    /// Показывает на какой странице сейчас находимся
    /// </summary>
    private TabItem CurrentItem;

    /// <summary>
    /// Необходим для того, чтобы определить какой радиокнопке соответствует какой маршрут
    /// </summary>
    private Dictionary<RadioButton, TabItem> Route = new ();
    private void SwitchTabItem(TabItem tabItem){
        MainTabControl.Items.Clear();
        MainTabControl.Items.Add(tabItem);
        CurrentItem = tabItem;
    }
    private void SwitchTabItemWithRadioButton(object sender, RoutedEventArgs args){
        foreach(var KV in Route){
            if(CurrentItem.Equals(KV.Key)){
                
            }
        }
    }
}
