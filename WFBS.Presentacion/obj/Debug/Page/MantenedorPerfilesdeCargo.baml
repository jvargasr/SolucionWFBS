   M S B A M L   `   `   `  ����L  HWFBS.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MasterPages.MasterMasterPages.Master  5      0    *MasterPages.Page.MantenedorPerfilesdeCargo   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .m clr-namespace:MasterPages.Master     5        N� Title$  MantenedorPerfilesdeCargo��5       N� 
Background �#2E5E79.��5         MasterPages.Master.Master     UserInfo 5   
   �� 5      -   5        $��lblUserInfo��5   '   
�������6<      Title$B <Listado de Perfiles de Cargo disponibles en la Base de Datos��5         Content 5   
   �� 5      $��Center=�6   .+�5      �� .��6   (&Para crear un nuevo perfil de clic en:6@   �� 5      -   5        $��btnAgregarPerfildeCargo��5      $
��Left=�6]   .��6x   Agregar Perfil6�   � 5       � RowDefinitions 5      �� 5      $	��100 �6(    � ColumnDefinitions 5      �� 5      $
��1000 �6+   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgPerfildeCargo��5      $
��Left=�68   $	��Top=�5         CanUserAddRows .  	   
IsReadOnly	 . 
   SelectionMode$
 Single=�5         AutoGenerateColumns . ��. $
��Auto=�5       $
��Auto=�5!      $	��600��5"       �� SelectedItem 5      ��  �� Path$ SelectedCustomer� �� Mode$ TwoWay=�5#      5$      �� 5%      .��6   DBSi desea Modificar o Desactivar el perfil seleccionado de clic en:6\   � 5&       � Orientation$ 
Horizontal=�6   .+�5'      �� -   5        $��btnModificarPerfildeCargo��5'      .��6g   Modificar Perfil6y   �� 5(      -   5        $��btnEliminarPerfildeCargo��5(      .��6e   Desactivar Perfil6x   5)      � 5*      $ Vertical=�6   .+�5+      �� -   5        $��	btnVolver��5+      .��6G   Volver a Inicio6X   5,      5-      50      51      