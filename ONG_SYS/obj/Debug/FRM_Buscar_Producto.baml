   M S B A M L   `   `   `  ����B  >ONG_SYS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ONG_SYSONG_SYS  5      !    ONG_SYS.FRM_Buscar_Producto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:ONG_SYS     5        � Title$  FRM_Buscar_Producto��5      $��493.284��5	      $	��800��5
      
���   � � Icon$ 	Logo.jpeg��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��100* �6#   �� 5      $
��603* �6#   �� 5      $
��100* �6#   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgv_productos��5      $	��265��6.   $��10.333,101,9.667,0q�6;   $	��Top=�6W   $��1��6o      
IsReadOnly . 6�   �� 5      -   5         ��Name$ lbl_buscar_por_nombre��5      $��NOMBRE DEL PRODUCTO��63   $��1��6Q   $��30.333,41,409.667,0q�6a   $	��Top=�6~   $��28��6�   
�������6�   �� 5      -   5         ��Name$ txt_nombreProducto��5      $��1��62   $
��Left=�6B   $��28��6]   $��252.333,41,0,0q�6i    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��198��6�   �� 5      -   5         ��Name$ 
btn_buscar��5      $��Buscar��6)   $	��Top=�6:   $��1��6R   $��492.333,41,35.667,0q�6b   $��28��6   6�   �� 5      -   5        $ btn_aceptar��5      $��Aceptar��6*   $��1��6<   $
��Left=�6L   $��56.667,391,0,0q�6g   $	��Top=�6   $	��130��6�   $��44��6�   �� 5      -   5        $ btn_cancelar��5      $��Cancelar��6+   $��1��6>   $��0,391,56.667,0q�6N   $	��Top=�6f   $��44��6~   $	��130��6�   $��Right=�6�   �� 5   
   -   5        	 ��Name$
	 Logo��5      $
��Left=�6   $��89��69   $��10,177,0,176q�6D   $��2��6Z   $��	Logo.jpeg��6n   
 � Cursor$
  ��6�   5      5      