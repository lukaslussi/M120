   M S B A M L   `   `   `  ����D  @KinoModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:KinoModel	KinoModel  5   	       KinoModel.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:KinoModel     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��5 �6   �� 5      $��* �6   �� 5      $��5 �6   �� 5      $
��Auto �6   �� 5      $��5 �6   .+�5   
   � $��1��6   $��0��6    5      �� 5      $��5 �6    �� 5      $
��Auto �6    �� 5      $��5 �6     � ColumnDefinitions 5      �� 5      $��10 �6#   �� 5      $
��auto �6#   �� 5      $��3 �6#   �� 5      $
��1.5* �6#   �� 5       $��10 �6#   �� 5!      $
��auto �6#   �� 5"      $��3 �6#   �� 5#      $
��1.5* �6#   �� 5$      $��10 �6#   �� 5%      $��* �6#   �� 5&      $��3 �6#   .+�5)      �� $��1��6   $��1��6$   $��	Film Name��62   �� 5*      -   5         ��Name$ tbFilm��5*      $��3��6'   $��1��67   ��6D   �� *
FilmName+�� 5+      -   5         ��Name$ Suchen��5+      $��7��6%   $��1��65   $��Suchen��6C   ��6T   �� *SuchenCommand+5,      �� 50   
   $��3��6   $��0��6   ���	#FF656CF1$��1q�6H    �� CornerRadius$ 8,8,3,3��6\   ._�52      �  53      �� 54      $��5 �6$   �� 55      $
��Auto �6$   �� 56      $��3 �6$   �� 57      $��* �6$    59      �� 5:      $��* �6'   �� 5;      $��* �6'   �� 5<      $��* �6'   .+�5>      �� $��1��6   $��0��6%   $��3��65   $��Gefundene Filme:��6I   &   System.Windows.Controls.DataGrid  5?      -   5        $��gridBuchungsliste��5?   =   $��3��6   $��3��6)      CanUserAddRows .     SelectionMode$ Single=�6�      
IsReadOnly . 
���   �	   GridLinesVisibility$
	 None=�5@   $   $��0q�6?   
   RowHeaderWidth$
 0Q�6S      AutoGenerateColumns .     AlternatingRowBackground
 �������5?   X   �� *CurrentFilm+   Columns 5B      0  *System.Windows.Controls.DataGridTextColumn  5C      ,  &System.Windows.Controls.DataGridColumn   Header$ Titel��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Title+  5D      $ 	Kategprie��6-    6A   �� *Categorie.Desc+  5E      $ 
Spieldauer��6-    6A   �� *Dauer+  5F      $) #Zeitangaben aktueller Vorstellungen��6-    6Z   �� *Spielzeiten+5K      5L      5O      � 5R   
   $��5��6   $��Right=�6    5S      �� 5T      $��* �6#   �� 5U      $
��Auto �6#   �� 5V      $��20 �6#   �� 5W      $
��Auto �6#   �� 5X      $��20 �6#   �� 5Y      $
��Auto �6#   �� 5Z      $��20 �6#   .+�5\      �� -   5        $ btBestellung��5\   &   $��1��6   $��Bestellung...��6<   $��80��6U   ��6`   �� *BestellenCommand+��6�   ��  �� ElementName$ gridBuchungsliste�� �� Path$ SelectedItem�5_      5`      5a      