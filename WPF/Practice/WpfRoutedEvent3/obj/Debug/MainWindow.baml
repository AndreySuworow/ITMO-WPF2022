   M S B A M L   `   `   `  ����^  ZWPF.Practice03.Ex03.WpfRoutedEvent3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:WPF.Practice03.Ex03.WpfRoutedEvent3#WPF.Practice03.Ex03.WpfRoutedEvent3  5   	   4    .WPF.Practice03.Ex03.WpfRoutedEvent3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:WPF.Practice03.Ex03.WpfRoutedEvent3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ]� .+�5
   
   o� $	��Top=�6   $
��Left=�6$   .@�5      m� $
��File��6   .@�5      m� -   5        $
��Exit��5      6)   5      �� 5      $��	ПУСК!��6   $��Center=�6$   $	��Top=�6A   �� 5      -   5         ��Name$	 stb��5      $��Bottom=�6%   .@�5      �� -   5         ��Name$
 stb1��5       .��5      �� !Статусная панель62   5      �� 5      �� 5      -   5        $
 stb2��5       .��5      �� Online6(   5      �� 5      -   5        $
 stb3��5       .��5      �� 6"   5      5      5      � 5   
   -   5         � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#    � RowDefinitions 5!      �� 5"      $��* �6    �� 5#      $��* �6    �� 5$      $��* �6    .+�5&      �� -   5         ��Name$ SetBut��5&      $��0��6%   $��0��65   $��	Set Name ��6B   $
��Left=�6V   $��10,15q�6q   $	��Top=�6�   $��75��6�   �� 5'      -   5        $ RetBut��5'      $��0��6&   $��1��66   $��	Ret Name ��6C   $
��Left=�6W   $��10,15q�6r   $	��Top=�6�   $��75��6�   �� 5(      -	   5         ��Name$ SetText��5(      $��1��6'   $��0��67   $��Stretch=�6D   $��10,15,10,15q�6b   6w   �� 5)      -
   5         ��Name$ RetLabel��5)      $��1��6&   $��1��66   $��Label��6C   $
��Left=�6S   $��10,15q�6n   $	��Top=�6}   �� 5*      -   5        $ New_Win��5*      $��0��6&   $��2��66   $��New Win��6C   $
��Left=�6U   $��10,15q�6p   $	��Top=�6   $��75��6�   6�   �� 5+      -   5         ��Name$ TxtBlock��5+      $��1��6*   $��2��6:   $��10,15,10,15q�6G   $
��Wrap=�6\   5,      5-      5.      