using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

        //SHEEETTT CODE!!!!!!!
        //Необходимо перевести на LINQ!!!!!!!!!
        //Необходимо найти активную радиокнопку, которую выбрал пользователь на TabItem-ах
        //Делаем для неё ссылочну переменную
        RadioButton CurrentActiveRadioButton = null;

        //Был заведен словарь GroupsRadioButton, который хранит TabItem-ы всего приложения
        //TabItem - это ключ, а значения - это радиокнопки, находящиеся на Item-ах,
        //Пройдемся по словарику и найдем TabItem, который открыт сейчас(CurrentItem - хранит как раз его)
        bool isActiveRadioButton = false; 
        foreach(var KV in GroupsRadioButton){        
            if(CurrentItem.Equals(KV.Key))//прямо сейчас в приложении.
            //Equals сравнивает по ссылке
                foreach(RadioButton value in KV.Value)
                    if((bool)value.IsChecked){//Когда нашли текущий TabItem, попробуем найти активную радиокнопку
                        CurrentActiveRadioButton=value;
                        //Если нашли то всё выходим из всех циклов.
                        isActiveRadioButton = true;
                        break;
                    }
            if(isActiveRadioButton)//Выходим если нашли
                break;
        }
        //Если активная кнопка не найдена, то просто прекращаем выполнение, и не переключаем страницу
        if (CurrentActiveRadioButton is null)
            return;
        //иначе если активная радиокнопка, прожатая пользователем, то с помощью словаря Route,
        //благодаря которому можно определить, какая радиокнопка должна открыть какой-либо TabItem,
        //открываем новый TabItem и рекомендуем пользователю ноут
        foreach(var kv in Route)
            if(kv.Key.Equals(CurrentActiveRadioButton)){
                SwitchTabItem(kv.Value);
                break;
            }


                
            
        
    }
}
