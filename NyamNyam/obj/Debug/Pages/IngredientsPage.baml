   M S B A M L   `   `   `  ����C  ?NyamNyam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:NyamNyam.PagesNyamNyam.Pages  5      $    NyamNyam.Pages.IngredientsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:NyamNyam.Pages     5        N� Title$  IngredientsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��List of Ingredients��5         TitleTextStyle#��[  5      �� 5   
   $��Right=�6   $��1��61    �� Orientation$ 
Horizontal=�6>   .+�5      �� $(��"Total available for the amount ($)��5      �� 5      -   5         ��Name$ TotalIngredientsCostTB��5      $��75��5      5      �� 5   
   -   5         ��Name$ IngredientLV��5      ���#fed7c1$
��auto��5      $��2��5"      $��Disabled=�5#      $��2��5$      ��5       �� *
ingredient+��5%      �� 5&      .R�5'      �� $��1q�6   
���   �._�5)      �� $ 
Horizontal=�6%   $��5 5 5 5q�6>   .+�5*      �� $	��200��6)   .+�5+   "   �� ��6-   �� *Name+�� 5,   "   ��6-   �� *CostInDollars+ �� StringFormat$ Price = ${0}���� 5-   "   $ Delete��6-   -   5        �� 5/   "   
���  ��.�6A   Delete51   #   52   #   53      �� 54      $ 
Horizontal=�6)   $	��180��6B   .+�55   "   ��  ��Name$ CountTB��56   !   -   5         �� TextAlignment$ Center=�5:   !   $��0 3 0 0q�5;   !   $��30 0 0 0q�5<   !   $��30��5=   !   $��30��5>   !   ��59   !   �� *AvailableCount+5>   !   �� 5?   "    �� TextAlignment$ Center=�5A   !   $��5 0 0 0q�5B   !   $��30��5C   !   ��5@   !   �� *	Unit.Name+5C   !   5D      �� 5E      .+�5F   "   �� 	 ��Name$	 PlusBT��5G   %   -   5        $��+��5F   )   $��30 0 0 0q�5I   %   $��30��5J   %   $��30��5K   %   ���#eed4fe5L   %   �� 5M   "   $	 MinusBT��5N   %   -   5        $��-��5M   )   $��	30 15 0 0q�5P   %   $��30��5Q   %   $��30��5R   %   ���#eed4fe5S   %   5T      5U      5V      5W      ��5Y      �� 5Z      .R�5[      � 
 � Orientation$
 
Horizontal=�6    5\      5^      5`      5a      