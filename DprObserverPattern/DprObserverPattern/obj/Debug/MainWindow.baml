   M S B A M L   `   `   `  ����  DprObserverPattern#    DprObserverPattern.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
My weather��5   	   $	��350��6   $	��525��6)    � Icon$' !Resources/Images/Umbrella-100.png��65   .��5
      � ��5   
   �� 5       �� ImageSource$< 6Resources/Images/aring-pound-129-ccedil-ordm-cedil.jpg��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ CitySearchTextBox��5       � ToolTip$ Please add a city name��62   $��30,10,30,10q�6S   
���   �
������  �� 
IsReadOnly .  6�   �� 5      -   5        $��Right=�5      $��0,0,30,0q�61   $��19��6C   $ Search��6N   $��19��6_   
������ 
������ .��5      �� $%��Resources/Images/Search-100.png��6   6C   5      5      � 5   
   $��1��6   $��30,10,30,10q�6    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5"      .+�5%      �� -   5         ��Name$ 	CityLabel��5%   !   $��0��6   $��25(�6�    � DataContext 6M   �� *WeatherDataUi+��6s   �� *	City.Name+6�   �� 5'      $��1��6   	 �� Orientation$	 
Horizontal=�6&   .+�5(      �� -   5        $ TemperatureLabel��5(      $��50(�6�   $��Right=�6�   $��Center=�6�    6L   �� *WeatherDataUi+��6r   �� *Temperature.Value+6�   �� 5)      $	��°C��6   $��50(�6%   $��Right=�63   $��Center=�6O   6l   �� 5*      $"��Resources/Images/Sun-100.png��6   $��Right=�6>   $��Center=�6Z   6x   5+      �� 5,      -   5        $ 	InfoLabel��5,   !   $��2��6   $��25(�6�    6M   �� *WeatherDataUi+��6s   �� *Clouds.Name+6�   � 5/      $��3��6    50      �� 51      �� 52      .+�55      �� $��0��6   $	 
Horizontal=�6*   .+�56      �� $��Sun rises at:��6   66   �� 57      -   5        $ SunRiseLabel��57       6K   �� *WeatherDataUi+��6q   �� *City.Sun.Rise+6�   58      �� 5:      $��1��6   $	 
Horizontal=�6*   .+�5;      �� $��Sun sets at:��6   65   �� 5<      -   5        $ SunSetLabel��5<       6J   �� *WeatherDataUi+��6p   �� *City.Sun.Set+6�   5=      5@      5A      5G      5H      