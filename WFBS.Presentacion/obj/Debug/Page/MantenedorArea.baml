   M S B A M L   `   `   `  ����L  HWFBS.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MasterPages.MasterMasterPages.Master  5      %    MasterPages.Page.MantenedorArea   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .m clr-namespace:MasterPages.Master     5        N� Title$  MantenedorArea��5       N� 
Background �#2E5E79.��5         MasterPages.Master.Master     UserInfo 5   
   �� 5      -   5        $��lblUserInfo��5   '   
�������6<      Title$; 5Listado de las Áreas disponibles en la Base de Datos��5         Content 5   
   �� 5      $��Center=�6   .+�5      �� .��6   (&Para crear una nueva área de clic en:6?   �� 5      -   5        $��btnAgregarArea��5      $
��Left=�6L   .��6g   Agregar Área6u   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgArea��5      $
��Left=�6+   $	��Top=�5         CanUserAddRows .     
IsReadOnly .    SelectionMode$ Single=�5      	   AutoGenerateColumns	 . 
 �� SelectedItem
 5      ��  �� Path$ SelectedCustomer� �� Mode$ TwoWay=�5      �� 5      .��6   ?=Para Modificar o Desactivar el área seleccionada de clic en:6V   � 5       � Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��btnModificarArea��5      .��6U   	Modificar6`   �� 5      -   5        $��btnEliminarArea��5      .��6S   
Desactivar6_   5      � 5      $ Vertical=�6   .+�5      �� -   5        $��	btnVolver��5      .��6G   Volver a Inicio6X   5       5!      5#      5$      