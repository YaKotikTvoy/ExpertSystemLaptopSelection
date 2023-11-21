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
        if(!GroupsRadioButton.ContainsKey(CurrentItem))
            return;
        foreach(RadioButton selectRadioButton in GroupsRadioButton[CurrentItem])
            if((bool)selectRadioButton.IsChecked)
                SwitchTabItem(Route[selectRadioButton]);
    }
    private void InitializeGroupsRadioButtonAndRoute(){
        //1 - Goal
        Route.Add(Goal2, Dimension);
        Route.Add(Goal35, Learn);        //Добавляем пары Радиокнопка-TabItem, на которую ведет радиокнопка
        Route.Add(Goal41, Job);
        GroupsRadioButton.Add(Goal, new List<RadioButton>{Goal2, Goal35, Goal41});//TabItem и радиокнопки, которые расположены на TabItem

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

        //5 - Genre4
        Route.Add(Genre4_6, Strategic);
        Route.Add(Genre4_8, Card);
        Route.Add(Genre4_9, Puzzle);
        GroupsRadioButton.Add(Genre4, new List<RadioButton>{Genre4_6, Genre4_8, Genre4_9});

        //6 - Strategic

        //7 - Economic

        //8 - Card

        //10 - Platformer

        //12 - CountPlayer1
        Route.Add( CountPlayer1_13, Genre2);
        Route.Add(CountPlayer1_28, Genre1);
        GroupsRadioButton.Add(CountPlayer1, new List<RadioButton>{CountPlayer1_13, CountPlayer1_28});

        //13 - Genre2
        Route.Add(Genre2_14, TypeArcade);
        Route.Add(Genre2_15, Survival);
        Route.Add(Genre2_16, Action);
        GroupsRadioButton.Add(Genre2, new List<RadioButton>{Genre2_14, Genre2_15, Genre2_16});

        //14 - TypeArcade
        Route.Add(TypeArcade25, Scroller);
        Route.Add(TypeArcade26, Room);
        Route.Add(TypeArcade27, Tyr);
        GroupsRadioButton.Add(TypeArcade, new List<RadioButton>{TypeArcade25, TypeArcade26, TypeArcade27});

        //15 - Survival

        //16 - Action
        Route.Add(Action17, Fighter);
        Route.Add(Action18, Simulator);
        Route.Add(Action19, Quest);
        GroupsRadioButton.Add(Action, new List<RadioButton>{Action17, Action18, Action19});

        //17 - Fighter

        //18 - Simulator
        Route.Add(Simulator20, CityBuilderSimulator);
        Route.Add(Simulator21, TypeSimulator);
        Route.Add(Simulator22, LifeSimulator);
        GroupsRadioButton.Add(Simulator, new List<RadioButton>{Simulator20, Simulator21, Simulator22});

        //19 - Quest

        //20 - CityBuilderSimulator

        //21 - TypeSimulator
        Route.Add(TypeSimulator23, DrivingSimulator);
        Route.Add(TypeSimulator24, AirplanSimulator);
        GroupsRadioButton.Add(TypeSimulator, new List<RadioButton>{TypeSimulator23, TypeSimulator24});

        //22 - LifeSimulator

        //23 - DrivingSimulator

        //24 - AirplanSimulator

        //25 - Scroller

        //26 - Room

        //27 - Tyr

        //28 - Genre1
        Route.Add(Genre1_29, TypeStrategy);
        Route.Add(Genre1_30, TypeRPG);
        GroupsRadioButton.Add(Genre1, new List<RadioButton>{Genre1_29, Genre1_30});

        //29 - TypeStrategy
        Route.Add(TypeStrategy31, RTS);
        Route.Add(TypeStrategy32, StepByStepStrategy);
        GroupsRadioButton.Add(TypeStrategy, new List<RadioButton>{TypeStrategy31, TypeStrategy32});

        //30 - TypeRPG
        Route.Add(TypeRPG33, ActionRPG);
        Route.Add(TypeRPG34, Moba);
        GroupsRadioButton.Add(TypeRPG, new List<RadioButton>{TypeRPG33, TypeRPG34});

        //31 - RTS

        //32 - StepByStepStrategy

        //33 - ActionRPG

        //34 - Moba

        //35 - Learn
        Route.Add(Learn36, Programming);
        Route.Add(Learn37, LearnHardware);
        Route.Add(Learn38, LearnTarget);
        GroupsRadioButton.Add(Learn, new List<RadioButton>{Learn36, Learn37, Learn38});

        //36 - Programming

        //37 - LearnHardware

        //38 - LearnTarget
        Route.Add(LearnTarget39, LearnOS);
        Route.Add(LearnTarget40, LearnIS);
        GroupsRadioButton.Add(LearnTarget, new List<RadioButton>{LearnTarget39, LearnTarget40});

        //39 - LearnOS
        
        //40 - LearnIS

        //41 - Job
        Route.Add(Job42, AreaWork1);
        Route.Add(Job43, AreaWork2);
        Route.Add(Job44, AreaWork3);
        GroupsRadioButton.Add(Job, new List<RadioButton>{Job42, Job43, Job44});

        //42 - AreaWork1
        Route.Add(AreaWork1_51, Modeling3D);
        Route.Add(AreaWork1_52, Montage);
        Route.Add(AreaWork1_53, Photoshop);
        GroupsRadioButton.Add(AreaWork1, new List<RadioButton>{AreaWork1_51, AreaWork1_52, AreaWork1_53});

        //43 - AreaWork2
        Route.Add(AreaWork2_48, Testing);
        Route.Add(AreaWork2_49, Backend);
        Route.Add(AreaWork2_50, Frontend);
        GroupsRadioButton.Add(AreaWork2, new List<RadioButton>{AreaWork2_48, AreaWork2_49, AreaWork2_50});

        //44 - AreaWork3
        Route.Add(AreaWork3_45, DockerKubernetis);
        Route.Add(AreaWork3_46, VirtualBox);
        Route.Add(AreaWork3_47, DMS);
        GroupsRadioButton.Add(AreaWork3, new List<RadioButton>{AreaWork3_45, AreaWork3_46, AreaWork3_47});

        //45 - DockerKubernetis

        //46 - VirtualBox

        //47 - DMS

        //48 - Testing

        //49 - Backend

        //50 - Frontend

        //51 - Modeling3D

        //52 - Montage

        //53 - Photoshop
    }
    
}
