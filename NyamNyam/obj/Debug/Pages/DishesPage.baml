   M S B A M L   `   `   `  ����C  ?NyamNyam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:NyamNyam.PagesNyamNyam.Pages  5          NyamNyam.Pages.DishesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:NyamNyam.Pages     5        N� Title$  
DishesPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��List of Dishes��5         TitleTextStyle#��[  5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� $��Category��6   �� 5      -   5         ��Name$ 
CategoryCB��5       �� DisplayMemberPath$
 Name��5      5      5      �� 5!      $ 
Horizontal=�6   $��1��62   $��1��6?   .+�5"      �� $��Name:��6   �� 5#      -   5         ��Name$ FilterTB��5#      $��25��6,   $	��Top=�68   6P   5$      �� 5&   
   $ 
Horizontal=�6   $��2��6.   .+�5'      �� -   5         ��Name$ IngredientCB��5'      $��Center=�6r   �� 5(      $1��+Show only dishes with available ingredients��5)      5*      �� 5,   
   $ 
Horizontal=�6   $��2��6.   $��1��6;   .+�5-      �� $��Center=�6   $��Price:��63   �� 5.      -   5         ��Name$ PriceSlider��5.      $��Center=�6*   $	��200��5/      50   :   51      �� 53   
   -   5        	 ��Name$	 DishesLV��53      ���#fed7c1$��2��57      $��3��58      $��Disabled=�59      $��Center=�5:      ��55      �� *Dish+��5;      �� 5<      .R�5=      � $	��400��6   $	��300��5>      .+�5?      �� $
��Fill=�6    
 �� BitmapScalingMode$

 Fant=�5@      ��5A      !� 5B   "    !� Source 68   �� *Image+ !� DestinationFormat 5C   !   �� *OpacityDish+5E      �� 5F      ���#d5c847 J� Opacity$	 0.7Q�5G   !   $	��100��5H   !   $	��400��5I   !   $��Bottom=�5J   !   �� 5K      $��Bottom=�6%   .+�5L      �� $��0 10 0 0q�6(   $��25(�5M   )   $
��Wrap=�5O   )    �� TextAlignment$ Center=�5P   )   ��5N   )   �� *Name+5P   )   �� 5Q      $��0 10 0 0q�6(   $
��Wrap=�5R   %   $��20(�5S   %   $ Center=�5U   %   ��5T   %   �� *FinalDishPriceDollar+ �� StringFormat$ 1 portion = ${0}��5U   %   5V      5W      5X      ��5Z      �� 5[      .R�5\      �  � Orientation$ 
Horizontal=�6    5]      5_      5`      5a      