   M S B A M L   `   `   `  ����B  >ONG_SYS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ONG_SYSONG_SYS  5          ONG_SYS.FMR_AUTENTICACION   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:ONG_SYS     5        � Title$  FMR_AUTENTICACION��5       � WindowState$ 	Maximized=�5	      $��Microsoft JhengHei)�6!   $��14(�6A   $
��Bold"�6O    � WindowStyle$ ThreeDBorderWindow=�6a   $y�Visible=�6�   
���   �$��730.085��6�   $��1373.362��6�    � Icon$ 	Logo.jpeg��6�   .��5      �  � RowDefinitions 5   
   �� 5      $
��142* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6    � ColumnDefinitions 5   
   �� 5      $
��342* �6   �� 5      $
��342* �6   �� 5      $
��303* �6   �� 5      $
��380* �6   .+�5   
   �� $��LOGIN��6   $��2��6    $
��Left=�60   $��	0,110,0,0q�6K   $	��Top=�6^   $��93��6v   $	��167��6�   
�������$��48(�6�    J� RenderTransformOrigin$ 0.858,0.495&�6�   �� 5   
   $��3��6   $��1��6%   $��113,275,379.667,0q�65   $��3��6P   .+�5      �� $��Usuario��6   $
��Left=�6&   $	��Top=�6A   
�������$��22(�6l   $��45��6z   $	��156��6�   �� 5       $��Contraseña��6   $
��Left=�6)   $	��Top=�6D   
�������$��22(�6o   $	��156��6}   $��45��6�   
 �� Top$	 113��6�   �� 5!      -   5         ��Name$ 
txtUsuario��5!      $
��Left=�6*   	 �� TextWrapping$
	 Wrap=�6E   $	��Top=�6Y   $��45��6q   $	��349��6}   
 �� Left$	
 183��6�   G� 5"      -   5         G�Name$ 
txtcontraU��5"      $
��Left=�6.   $	��Top=�6I   $��45��6a   $	��356��6m    G� 	MaxLength$ 25��6y    G� PasswordChar$ *��6�   $	
 176��6�   $	 113��6�   �� 5#      -   5         ��Name$ btnIn��5#      $��Ingresar��6$   $
��Left=�67   $	��Top=�6R   $	��128��6j   ���	#FFFFFBFB
���  �����	#FF252323$��45��6�   $	 229��6�   �� 5$      -   5        $ btncn��5$      $��Cancelar��6$   $
��Left=�67   $	��Top=�6R   $	��128��6j   ���	#FFFFFBFB
���  �����	#FF252323$��45��6�   $	
 404��6�   $	 229��6�   5&      �� 5(   
   $
��Left=�6   $	��281��6+   $	��Top=�68   $	��254��6P   $��	Logo.jpeg��6\   $��
88,255,0,0q�6o   $��3��6�   5,      5-      