   M S B A M L   `   `   `  ����  DprStrategyPattern#    DprStrategyPattern.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   R NOxyPlot.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0"charthttp://oxyplot.org/wpf  5   	     � Title$   Operating System Algorithm��5	   	   $��494.2��6,   $��678.6��6;    � Icon$$ Images/icon_diskscheduling.png��6I   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      $	��200 �6   .+�5   
   � $��0��6   
������� 5      �� 5      �� 5      .+�5      � $��0��6   $��0,5,0,5q�6     � ColumnDefinitions 5      �� 5      6)   �� 5      $
��Auto �6'   66   .+�5      �� $��0��6   $��3,0,0,0q�5       $��Center=�6%   $
��left=�6@   ��5   (   �� *List+5    ]   �� 5!       �� Orientation$ 
Horizontal=�6   $��1��66   $��Center=�6F   $��Right=�6a   .+�5"      �� $��Add manually��6   $
��24.8��6c   $��90��6q   $��Right=�6|    � ToolTip$ Add requests manually��6�   ��64   �� *AddRequestsManuallyCommand+{�6�   �� *IsAddRequestsManuallyCommand+6�   �� 5#      $��Random��6   $
��24.8��6S   $��70��6a   $��Right=�6l   $��5,0,5,0q�6�   $  Generate requests randomly��6�   ��6.   �� *AddRandomCommand+{�6�   �� *IsAddRandomCommandEnabled+6�   5$      5&      � 5(      $��1��6   $��0,5,0,5q�6U   y�6    �� *AddRequestsManuallyVisibility+ 5)      �� 5*      $
��Auto �6'   66   �� 5+      $��* �6'   63   �� 5,      $
��Auto �6'   66   .+�5.      �� $��0��6   $��Queue: ��6(   $��	3,0,0.2,0q�5/      $��25��6'   $	��Top=�63   6M   �� 50      -   5        $��1��50      $��5,0,5,0q�6C   $/ )Enter numbers separated by space or comas��6T   ��6*   �� *	NewList+6�   �� 51      $��2��6   $ 
Horizontal=�6-   .+�52      �� $	��Add��6   $��75��6N   ��6+   �� *AddListCommand+{�6Y   �� *IsAddListCommandEnabled+6�   �� 53      $��Cancel��6   $��75��6P   $��5,0,5,0q�6[   ��6.   �� *CancelCommand+{�6l   �� *IsCancelCommandEnabled+6�   54      55      56      � 58   
   $��1��6    59      �� 5:      6%   �� 5;      $	��100 �6#   61   .+�5>        OxyPlot.Wpf.PlotView  $��0��6   $��	-20,0,0,0q�6I      Model 6-   �� *	PlotModel+6^   � 5@      $��1��6   $��0,50,0,0q�6#    5B      �� 5C      $��40 �6$   �� 5D      $��40 �6$   �� 5E      $��40 �6$   .+�5H      �� -   5         ��Name$ BtnRun��5H      $��Center=�6)   $��0��6F   $��Center=�6S   $��80��6n   $��0,5,0,5q�6�   ��6y   �� *
RunCommand+{�6�   �� *IsStartButtonEnabled+.��5I      �� $ 
Horizontal=�6!   $��Center=�6:   $��Center=�6U   .+�5J      �� $��Images/play.png��6    $��Center=�69   $��Center=�6T   6s   �� 5K      $	��Run��6$   $��Center=�6/   $��Center=�6J   6i   5L      5M      �� 5N      -   5        $ BtnStop��5N      $��Center=�6*   $��1��6H   $��Center=�6U   $��80��6p   $��0,5,0,5q�6�   ��6{   �� *StopCommand+{�6�   �� *IsStopButtonEnabled+.��5O      �� $ 
Horizontal=�6!   $��Center=�6:   $��Center=�6U   .+�5P      �� $��Images/stop.png��6    $��Center=�6:   $��Center=�6U   6t   �� 5Q      $	��Run��6$   $��Center=�60   $��Center=�6K   6j   5R      5S      �� 5T      -   5        $ BtnExportPicture��5T      $��Center=�63   $��2��6Q   $��Center=�6^   $��80��6y   $y�	Collapsed=�6�   $��0,5,0,5q�6�   ��6�   �� *ExportPngCommand+{�6�   �� *IsExportPngCommandEnabled+.��5U      �� $ 
Horizontal=�6!   $��Center=�6:   $��Center=�6U   .+�5V      �� $��Images/image.png��6    $��Center=�6;   $��Center=�6V   6u   �� 5W      $��Export��6$   $��Center=�63   $��Center=�6N   6m   5X      5Y      5a      5b      � 5d   
   $��2��6   
������� 5e      �� 5f      6%   �� 5g      6%   �� 5h      6%   �� 5i      6%   .+�5k      �� $��Strategies: ��6   $��0��6,   $��3,5,0,0q�6=   6P   �� 5l      -   5        $
 Fifo��5l      $
��FIFO��6#   $��1��62   $	��Top=�6B   $
��Left=�6Z   $��75��6u   $��30��6�   $��0,5,0,5q�6�   ��6�   �� *FifoCommand+{�6�   �� *IsFifoButtonEnabled+6�   �� 5m      -   5        $ 
SstfButton��5m      $
��SSTF��6)   $��2��68   $	��Top=�6H   $
��Left=�6`   $��75��6{   $��30��6�   $��0,5,0,5q�6�   ��6�   �� *SstfCommand+{�6�   �� *IsSstfButtonEnabled+6�   �� 5n      -   5        $ 
ScanButton��5n      $
��SCAN��6)   $��3��68   $	��Top=�6H   $
��Left=�6`   $��75��6{   $��30��6�   $��0,5,0,5q�6�   ��6�   �� *ScanCommand+{�6�   �� *IsScanButtonEnabled+6�   5o      � 5q   
   $��3��6   
�������.+�5r      �� -   5        $��ListBoxOutput��5r   E   $��10,0,9.6,20q�6Z   ��6   �� *CurrectRunningProceses+6r   5s      5u      5v      