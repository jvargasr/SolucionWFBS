   M S B A M L   `   `   `  ����L  HWFBS.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MasterPages.MasterMasterPages.Master  5      ,    &MasterPages.Page.IngresarPerfildeCargo   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .m clr-namespace:MasterPages.Master     5        N� Title$  IngresarPerfildeCargo��5       N� 
Background �#2E5E79.��5         MasterPages.Master.Master     UserInfo 5   
   �� 5      -   5        $��lblUserInfo��5   '   
�������6<      Title$ Ingresar Perfil de Cargo��5         Content 5   
   �� 5      $��Center=�6   .+�5      �� $��0��6   $��1��6%   $K��ESeleccione la(s) área(s) correspondientes para el Perfil a ingresar:��65   � 5       � Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��lbArea��5      $	��210��6,   $	��100��68   5      �� 5      -   5        $��lbAreaSeleccionadas��5      $	��210��69   $	��100��6E   $��Right=�6U   5      5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��
btnToRight��5      .��6H   	Agregar6Q   �� 5      -   5        $��	btnToLeft��5      .��6G   	Remover6P   5      � 5      $
��Left=�6    � RowDefinitions 5      �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5       $
��Auto �6(   �� 5!      $
��Auto �6(    � ColumnDefinitions 5#      �� 5$      $
��Auto �6+   �� 5%      $	��400 �6+   �� 5&      $
��Auto �6+   .+�5(      �� $��0��6   $��1��6)   .��69   31Escriba una breve descripción del Perfil a crear6k   �� 5)      $��1��6   $��0��6)   $��Descripción:��69   �� 5*      $��2��6   $��0��6)   $��	Obsoleto:��69   �� 5+      -   5        $��txtDescripcion��5+   ;   $��1��6   $��1��6+   $��2q�6Q   �� 5,      -   5        	 ��Name$	 radioButtonsObs��5,      $��1��68   $��2��6H   $��3q�6U   .��5-      �� .+�5.      	� -   5        $��rbNoObsoleto��5.   7   $��No��6*   6K   	� 5/      -	   5        $��rbSiObsoleto��5/   7   $��Si��6*   6K   50      51      52      � 53      $ Vertical=�6   .+�54      �� -
   5        $��btnAgregarPerfildeCargo��54   9   $��Right=�6   .��6~   Agregar Perfil de Cargo6�   �� 55      -   5        $��	btnVolver��55      .��6G   Volver6O   56      57      59      5:      