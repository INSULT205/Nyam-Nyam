   M S B A M L   `   `   `  ����C  ?NyamNyam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:NyamNyam.PagesNyamNyam.Pages  5      "    NyamNyam.Pages.RecipeForDish   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:NyamNyam.Pages     5        N� Title$  RecipeForDish��5	      .��5      � ���#fed7c1 � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Recipe for ��5         TitleTextStyle#��[  5      �� 5      -   5         ��Name$ DishRecipeTB��5      #��[  5      5      �� 5    
   $��1��6   .+�5!      �� $ 
Horizontal=�6   .+�5"      �� $��
Category: ��5#      �� 5$      -   5        $ 
CategoryTB��5$      5%      �� 5&      $ 
Horizontal=�6   .+�5'      �� $��Cooking time: ��5(      �� 5)      -   5        $ CookingTimeTB��5)      5*      5+      �� 5-   
   $��1��6   $��1��6"   .+�5.      �� $ 
Horizontal=�6   .+�5/      �� $��
Servings: ��50      �� 51      -   5         ��Name$ MinusBT��51      $��-��52      $��25��6%   ���#eed4fe54      �� 55      -   5        $ 
ServingsTB��55      $��50��56       �� TextAlignment$ Center=�57      �� 58      -   5        $ PlusBT��58      $��+��59      $��25��5:      ���#eed4fe5<      5=      �� 5>      $ 
Horizontal=�6   .+�5?      �� $��Total cost: ��5@      �� 5A      -   5        $ TotalCostTB��5A      5B      5C      �� 5E   
   $��2��6   $��2��6"   $ 
Horizontal=�66   .+�5F      �� $��Short description: ��6   �� 5G      -   5        $ DescriptionTB��5G      $
��Wrap=�5H      $
��1000��5I      $
��auto��5J      5K      �� 5M   
   $��3��6   .+�5N      �� $��20(�5O      $ Center=�5P      $��Ingredients:��5Q      &   System.Windows.Controls.DataGrid  5R      -	   5        $��IngredientsLv��5R         AutoGenerateColumns .     CanUserAddRows .  	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 5U      
   
IsReadOnly
 .    Columns 5W      4  .System.Windows.Controls.DataGridTemplateColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Width$ 20 6-      CellTemplate 5Y      �� 5Z      .R�5[   "   �� $��Border��5\   0    �� CornerRadius$ 20��5[   )   $��15��5]   0   $��15��5^   0   $��1q�5_   0   
���   ���5a   &   �� 5b   *    �� 
TargetType" ��60    �� Triggers 5c   .   �� 5d   2    �� Binding 6>   �� *IndicatorColor+ �� Value	 False5e   A   .a�5f   6   ��  �� Property � �� �� Value
 �  ��5g   A   5h   3   �� 5i   2    6?   �� *IndicatorColor+ True5j   =   .a�5k   6   ��  � ��
 � � �5l   =   5m   3   5o   +   5q   #   5r      5t      0  *System.Windows.Controls.DataGridTextColumn  5u         Header$
 Name��6)      FontSize$ 18Q�5w         
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5v      �� *Ingredient.Name+   ElementStyle 5y      �� 5z      .�5{   "   ��  � ��$
 Wrap=�6K   �� 5|   "    �@��TextAlignment$ Center=�6L   5}      5        5�      $ Quantity��6)   $ 18Q�5�       .  5�      �� *TotalQuantity+5�        5�      $
 Unit��6)   $ 18Q�5�       .  5�      �� *Ingredient.Unit.Name+5�        5�      $
 Cost��6)   $ 18Q�5�       .  5�      �� *	TotalCost+5�      5�      5�      �� 5�   
   $��3��6   $��2��6"   $��Center=�62   .+�5�      �� $��20(�5�      $��Cooking Process:��5�      �� 5�      -
   5         ��Name$ 	LVRecipes��5�      $��Disabled=�5�      $��0q�5�      ��5�      �� 5�      .R�5�      �� $
��Wrap=�5�      $��18(�5�      ��5�   $   �� *Steps+5�      5�      5�      5�      �� 5�   
   $��4��6   $��2��6"   $��Center=�5�      .+�5�      �� -   5        $ BackBT��5�      $
��Back��5�      $	��100��5�      $��	0 10 0 10q�5�      ���#eed4fe5�      5�      5�      5�      