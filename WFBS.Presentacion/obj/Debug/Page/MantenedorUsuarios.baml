   M S B A M L   `   `   `  ����L  HWFBS.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MasterPages.MasterMasterPages.Master  5      )    #MasterPages.Page.MantenedorUsuarios   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .m clr-namespace:MasterPages.Master     5        N� Title$  MantenedorUsuarios��5       N� 
Background �#2E5E79.��5         MasterPages.Master.Master     UserInfo 5   
   �� 5      -   5        $��lblUserInfo��5   '   
�������6<      Title$9 3Listado de Usuarios disponibles en la Base de Datos��5         Content 5   
   �� 5      $��Center=�6   .+�5      �� .��6   )'Para crear un nuevo usuario de clic en:6A   �� 5      -   5        $��btnAgregarUsuario��5      $
��Left=�6V   .��6q   Agregar Usuario6�   � 5       � RowDefinitions 5      �� 5      $	��100 �6(    � ColumnDefinitions 5      �� 5      $
��1000 �6+   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgUsuarios��5      $
��Left=�63   $	��Top=�5         CanUserAddRows .  	   
IsReadOnly	 . 
   SelectionMode$
 Single=�5         AutoGenerateColumns . ��. $
��Auto=�5       $
��Auto=�5!      $	��600��5"       �� SelectedItem 5      ��  �� Path$ SelectedCustomer� �� Mode$ TwoWay=�5#      5$      �� 5%      .��6   ECSi desea Modificar o Desactivar el usuario seleccionado de clic en:6]   � 5&       � Orientation$ 
Horizontal=�6   .+�5'      �� -   5        $��btnModificarUsuario��5'      .��6[   	Modificar6f   �� 5(      -   5        $��btnEliminarUsuario��5(      .��6Y   
Desactivar6e   5)      � 5*      $ Vertical=�6   .+�5+      �� -   5        $��	btnVolver��5+      .��6G   Volver a Inicio6X   5,      5-      50      51      