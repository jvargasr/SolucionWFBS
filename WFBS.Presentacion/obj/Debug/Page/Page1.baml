   M S B A M L   `   `   `  ����L  HWFBS.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MasterPages.MasterMasterPages.Master  5          MasterPages.Page.Page1   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .m clr-namespace:MasterPages.Master     5        N� Title$  Page1��5       N� 
Background �#2E5E79.��5      � 
�������$	��500��6   $	��300��6*   $��Center=�67   $��Center=�6T   .+�5   
   � $
��Left=�6   $	��269��6*   $��0,6,0,0q�67   $	��Top=�6H   $	��502��6`    � ColumnDefinitions 5	      �� 5
      $	��13* �6#   �� 5      $
��489* �6#   .+�5      �� -   5         ��Name$ label��5      $ ��Bienvenido al Sistema WFBS��6#   $
��Left=�6H   $��	10,36,0,0q�6c   $	��Top=�6v   $	��356��6�   $
��Bold"�6�   $��24(�6�   $��2��6�   �� 5      -   5        $ label1��5      $Q��KInicie sesión con su rut y contraseña proporcionada por el administrador.��6$   $
��Left=�6x   $��	10,78,0,0q�6�   $	��Top=�6�   $	��492��6�   $��2��6�   �� 5      -   5        $ label2��5      $
��RUT:��6$   $
��Left=�63   $��107,133,0,0q�6N   $	��Top=�6c   $��1��6{   �� 5      -   5        $ label3��5      $��Contraseña:��6$   $
��Left=�6:   $��
69,173,0,0q�6U   $	��Top=�6i    J� RenderTransformOrigin$ 0.319,-1.808&�6�   $��1��6�   �� 5      -   5         ��Name$ txtUser��5      $
��Left=�6)   $��23��6D   $��171,133,0,0q�6P    �� TextWrapping$
 Wrap=�6e   $	��Top=�6z   $	��160��6�   $��1��6�   G� 5      -   5         G�Name$ txtPass��5       G� PasswordChar$ *��6+   $
��Left=�6<   $��23��6W   $��171,173,0,0q�6c   $	��Top=�6y   $	��160��6�   $��1��6�   �� 5      -   5        	 ��Name$	 btnIniciarSesion��5      $��Iniciar sesión��6/   $
��Left=�6H   $��171,213,0,0q�6c   $	��Top=�6x   $	��160��6�   ���#0073AB
�������$
��Bold"�6�   $��1��6�   �� 5      -   5        $ 
lblMensaje��5      $
��Left=�6)   $��171,130,0,0q�6D   $	��Top=�6Y   $	��160��6q   $��1��6}   5      � 5   
   $
��Left=�6   $��36��6*   $	��Top=�66   $	��500��6N   $��0,0,0,0q�6Z   ���#d1dee46k   �� 5   
   -	   5        $ label4��5      $"��Inicio de sesión al sistema��6    $
��Left=�6F   $��0,10,0,0q�6a   $	��Top=�6s   $	��176��6�   $
��Bold"�6�   ���#1B548D6�   5      5      