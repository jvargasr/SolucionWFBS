   M S B A M L   `   `   `  ����L  HWFBS.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MasterPages.MasterMasterPages.Master  5      $    MasterPages.Page.ReporteGrupal   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .m clr-namespace:MasterPages.Master     5        N� Title$  ReporteGrupal��5       N� 
Background �#2E5E79.��5         MasterPages.Master.Master     UserInfo 5   
   �� 5      -   5        $��lblUserInfo��5   '   
�������6<      Title$U OListado Evaluaciones de todos los funcionarios, agrupados por perfiles de cargo��5         Content 5   
   �� 5      $��Center=�6   .+�5      �� -   5         ��Name$ TabControl1��5      $��0q�62   $��50��6g   ��5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value 67   �� *Id_PC+�� 5       � �� 68   �� *descripcion+5      5      � 5      -   5        $��MainGrid��5      	 � RowDefinitions	 5      �� 5      $	��150 �6(   
 � ColumnDefinitions
 5      �� 5      $
��1000 �6+   .+�5       &   System.Windows.Controls.DataGrid  -   5          Name$ dgEvaluaciones��5       $
��Left=�67   $	��Top=�5!         CanUserAddRows .     
IsReadOnly .    AutoGenerateColumns . ��. $
��Auto=�5&      $
��Auto=�5'      $	��550��5(       �� SelectedItem 5#      ��  �� Path$ SelectedCustomer� �� Mode$ TwoWay=�5)      5*      � 5+       � Orientation$ 
Horizontal=�6   $
��Left=�65   .+�5,      �� -   5        $��btnDecargar��5,      .��6K   Descargar Excel6\   �� 5-      -   5        $��btnBajoNivel��5-      .��6M   (&Filtrar listado Bajo el nivel esperado6u   �� 5.      -   5        $��btnTodas��5.      .��6E   	Ver todas6P   �� 5/      -   5        $��	btnVolver��5/      $
��Left=�6G   .��6b   Volver a Inicio6s   50      51      54      55      