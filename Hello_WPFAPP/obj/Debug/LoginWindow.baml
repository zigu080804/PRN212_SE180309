   M S B A M L   `   `   `  ����G  CHello_WPFAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Hello_WPFAPPHello_WPFAPP  5   	       Hello_WPFAPP.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Hello_WPFAPP     5   	     � Title$  LoginWindow��5   	   $	��450��6   $	��800��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $
��133* �6   �� 5      $
��267* �6   .+�5   
   �� $��Màn Hình đăng nhập��6   $��0,124,314,0q�6-   $	��Top=�6B   $��3��6Z   $��26��6j   ���	#FF4E5B3C���	#FFB9B2B26�   �� 5   
   -   5         ��Name$ btnLogin��5      $��3��6#   $��Đăng nhập��63   $
��Left=�6G   $��	1,252,0,0q�6b   $	��Top=�6u    J� RenderTransformOrigin$ 
0.52,0.539&�6�   $	��119��6�   $��30��6�   $��20(�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$
 0.17Q�6&   T� 5       T� X$ 0.015Q�6)    T� Y$ -0.033Q�63   5      5      �� 5   
   -   5        $ btnThoat��5      $��3��6#   $��Thoát��63   $
��Left=�6C   $��154,252,0,0q�6^   $	��Top=�6s   $��66��6�   $��29��6�   $��20(�6�   6�   �� 5   
   -   5         ��Name$ txtUsername��5      $��3��6'   $
��Left=�67   $��100,176,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   $��3��6   $��Username��6    $
��Left=�63   $��	0,168,0,0q�6N   $	��Top=�6a   �� 5   
   $��3��6   $��Password��6    $
��Left=�63   $��	0,200,0,0q�6N   $	��Top=�6a   G� 5   
   -   5        	 G�Name$	 txtPassword��5      $��3��6+   $
��Left=�6;   $��	100,0,0,0q�6V   $��Center=�6i   $	��120��6�   �� 5    
   $��3��6   5"      5#      