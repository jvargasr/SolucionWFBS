   M S B A M L   `   `   `  ����L  HWFBS.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MasterPages.MasterMasterPages.Master  5      $    MasterPages.Page.ModificarArea   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .m clr-namespace:MasterPages.Master     5        N� Title$  ModificarArea��5       N� 
Background �#2E5E79.��5         MasterPages.Master.Master     UserInfo 5   
   �� 5      -   5        $��lblUserInfo��5   '   
�������6<      Title$ Modificar Área��5         Content 5   
   � 5      $��Center=�6    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $	��300 �6'   .+�5      �� $��0��6   $��0��6%   $��Id Area:��65   �� 5      $��1��6   $��0��6%   $��Nombre:��65   �� 5      $��2��6   $��0��6%   $��Abreviación:��65   �� 5      $��3��6   $��0��6%   $��	Obsoleta:��65   �� 5      -   5        $��	txtIdArea��5   B   $��1��6   $��0��6*   $��3q�67   {�.   �� 
IsReadOnly . 6f   �� 5       -   5        $��	txtNombre��5    B   $��1��6   $��1��6*   $��3q�67   6B   �� 5!      -   5        $��txtAbreviacion��5!   B   $��1��6   $��2��6*   $��3q�67   6B   �� 5"      -   5         ��Name$ radioButtons��5"      $��1��61   $��3��6A   $��3q�6N   .��5#      �� .+�5$      	� -   5        $
��rbNo��5$   3   $��No��6&   6?   	� 5%      -   5        $
��rbSi��5%   3   $��Si��6&   6?   5&      5'      � 5(      	 � Orientation$	 
Horizontal=�6   $��0��65   $��4��6E   $��3q�6R   $
��Left=�6]   .+�5)      �� -   5        $��
btnLimpiar��5)      $	��100��6H   $��Limpiar��6W   5*      � 5+      $	 
Horizontal=�6   $��1��65   $��4��6E   $��3q�6R   $��Right=�6]   .+�5,      �� -	   5        $��btnModificar��5,      $	��100��6L   $��	Modificar��6[   �� 5-      -
   5        $��	btnVolver��5-      .��6G   Volver6O   5.      5/      51      52      