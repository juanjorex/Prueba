   M S B A M L   `   `   `  ����B  >ONG_SYS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ONG_SYSONG_SYS  5   	   "    ONG_SYS.FRM_Buscar_Proveedor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ONG_SYS     5   	     � Title$  PROVEEDORES��5   	   $��493.284��6   $	��800��6.   
���   � � Icon$ 	Logo.jpeg��6M   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��100* �6   �� 5      $
��603* �6   �� 5      $
��100* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgvResultado��5      $	��265��6)   $��10.333,101,9.667,0q�66   $	��Top=�6R   $��1��6j      
IsReadOnly . 6�   �� 5   
   -   5         ��Name$ lbl_buscar_por_nombre��5      $��NOMBRE DEL PROVEEDOR��6/   $��1��6N   $��30.333,41,409.667,0q�6^   $	��Top=�6{   $��28��6�   
�������6�   �� 5   
   -   5         ��Name$ TXT_Buscar_por_nombre_pro��5      $��1��65   $
��Left=�6E   $��28��6`   $��252.333,41,0,0q�6l    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��198��6�   �� 5   
   -   5         ��Name$ btn_Buscar_Proveedor��5      $��Buscar��6/   $	��Top=�6@   $��1��6X   $��492.333,41,35.667,0q�6h   $��28��6�   �� 5   
   -   5        $ btn_Aceptar��5      $��Aceptar��6&   $��1��68   $
��Left=�6H   $��56.667,391,0,0q�6c   $	��Top=�6{   $	��130��6�   $��44��6�   6�   �� 5   
   -   5        $ btn_Cancelar��5      $��Cancelar��6'   $��1��6:   $��0,391,56.667,0q�6J   $	��Top=�6b   $��44��6z   $	��130��6�   $��Right=�6�   �� 5   
   -   5        	 ��Name$
	 Logo��5      $
��Left=�6   $��89��69   $��10,177,0,176q�6D   $��2��6Z   $��	Logo.jpeg��6n   
 � Cursor$
  ��6�   5      5      