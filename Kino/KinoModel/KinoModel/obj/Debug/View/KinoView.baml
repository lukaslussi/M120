   M S B A M L   `   `   `  ����D  @KinoModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:KinoModel	KinoModel  5   	       KinoModel.View.KinoView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:KinoModel     5   	   -   5          �Name$  
kinoWindow��5   	    � Title$ KinoView��5
   	   $	��450��6   $	��800��6'   .��5      �  � ColumnDefinitions 5   
   �� 5      $��5 �6   �� 5      $
��Auto �6   �� 5      $��5 �6   �� 5      $��* �6   �� 5      $��5 �6   �� 5      $
��Auto �6   �� 5      $��5 �6   �� 5      $��* �6   �� 5      $��5 �6    � RowDefinitions 5   
   �� 5      $��5 �6   �� 5      $
��Auto �6   �� 5      $��5 �6   �� 5      $
��Auto �6   �� 5      $��5 �6   �� 5      $
��Auto �6   �� 5      $��5 �6   �� 5       $
��Auto �6   �� 5!      $��5 �6   �� 5"      $
��Auto �6   �� 5#      $��5 �6   .+�5'   
   �� -   5         ��Name$ lblTitel��5'   -   $��1��6   $��1��6    $��Titel��6?   �� 5(   
   -   5         ��Name$ txtTitel��5(   /   $��3��6   $��1��6"    �� 
IsReadOnly . ��6S   �� *Titel+�� 5*   
   -   5        $ lblKategorie��5*   -   $��5��6   $��1��6    $��	Kategorie��6C   �� 5+   
   -   5        $ txtKategorie��5+   /   $��7��6   $��1��6"    . ��6X   �� *	Kategorie+ �� Mode$ OneWay=��� 5.   
   -   5        $ lblDauer��5.   -   $��1��6   $��3��6    $��Dauer��6?   �� 5/   
   -   5        $ txtDauer��5/   /   $��3��6   $��3��6"    . ��6T   �� *Dauer+$ OneWay=��� 52   
   -   5        $ lblEmail��52   -   $��1��6   $��5��6    $��Zeit der Vorstellung��6?   �� 53   
   -	   5         ��Name$ CmbVerfuegbar��53   D   $��3��6   $��5��6#   $��4��60   	 �� SelectedIndex$	 0��6~   $��Center=�6�   ��6[   �� *
Verfuegbar+��54      �� 55      .R�56      �� 
 �� Orientation$
 
Horizontal=�6!   .+�58      �� $��0,0,15,0q�6$   ��66   �� *	Spielzeit+6S   �� 59      $��0,0,5,0q�6%   Verfuegbare Sitze:6M   �� 5:      ��6$   �� *AnzfreiePlaetze+6G   5<      5=      5?      �� 5B   
   -
   5        $ 	lblAnzahl��5B   -   $��5��6   $��3��6    $��Anzahl Tickets��6@   �� 5C   
   -   5        $ 	txtAnzahl��5C   /   $��7��6   $��3��6"   ��6B   �� *Anzahl+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated . �� 5E   
   -   5        $ lblPreis��5E   -   $��1��6   $��7��6    $��Gesamter Preis��6?   �� 5F   
   -   5        $ txtPreis��5F   /   $��3��6   $��7��6"    . ��6T   �� *Kosten+$ TwoWay=�$ PropertyChanged=� . �� 5I   
   $��3��6   $��9��6$   �� 5J      -   5        ��5J      ��  �� Path$ Trailer�.�6l   	Trailer5L      5M      �� 5R   
   $��5��6   $��7��6!   ��6.   �� *KaufenCommand+��6P   ��  �� ElementName$ 
kinoWindow��.��6�   Kaufen6�   �� 5S   
   $��5��6   $��9��6!    �� IsCancel . .��6?   Cancel6G   5V      5W      