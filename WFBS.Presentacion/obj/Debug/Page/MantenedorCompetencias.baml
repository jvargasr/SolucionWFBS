   M S B A M L   `   `   `  ����L  HWFBS.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MasterPages.MasterMasterPages.Master  5      -    'MasterPages.Page.MantenedorCompetencias   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .m clr-namespace:MasterPages.Master     5        N� Title$  MantenedorCompetencias��5       N� 
Background �#2E5E79.��5         MasterPages.Master.Master     UserInfo 5   
   �� 5      -   5        $��lblUserInfo��5   '   
�������6<      Title$= 7Listado de Competencias disponibles en la Base de Datos��5         Content 5   
   �� 5      $��Center=�6   .+�5      �� .��6   .,Para crear una nueva competencia de clic en:6F   �� 5      -   5        $��btnAgregarCompetencia��5   %   $	��210��6   $
��Left=�6f   .��6�   Agregar Competencia6�   � 5       � RowDefinitions 5      �� 5      $
��auto �6(    � ColumnDefinitions 5      �� 5      $
��1000 �6+   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgCompetencias��5      $
��Left=�67   ��. $
��Auto=�5      $
��Auto=�5      $	��Top=�5         CanUserAddRows .  	   
IsReadOnly	 . 
   SelectionMode$
 Single=�5       �� SelectedItem 5      ��  �� Path$ SelectedCustomer� �� Mode$ TwoWay=�5       5!      � 5"       � Orientation$ 
Horizontal=�6   .+�5#      �� .��6   ECPara Modificar o Desactivar la competencia seleccionada de clic en:6a   �� 5$      -   5        $��btnModificarCompetencia��5$      .��6c   	Modificar6n   �� 5%      -   5        $��btnEliminarCompetencia��5%      .��6a   
Desactivar6m   �� 5&      .��6   LJSi desea ver que habilidades posee la competencia seleccionada de clic en:6h   �� 5'      -   5        $��btnMantenerHabilidad��5'      .��6]   Habilidades por Competencia6z   5(      � 5)      $ Vertical=�6   .+�5*      �� -   5        $��	btnVolver��5*      .��6G   Volver a Inicio6X   5+      5,      5.      5/      