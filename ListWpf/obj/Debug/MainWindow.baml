   M S B A M L   `   `   `  ����B  >ListWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ListWpfListWpf  5   	       ListWpf.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ListWpf     5   	     � Title$  Thao tác trên List��5   	   $	��380��6$   $	��310��61   .��5	      � .+�5
   
   �� -   5         ��Name$ btnThem��5
      $��Thêm vào List��6"   $
��Left=�6:   $��
145,31,0,0q�6U   $	��Top=�6i   $	��135��6�   6�   �� 5   
   -   5        $ btnXoanhieuphantu��5      $��Xóa nhiều phần tử ��6,   $
��Left=�6I   $��145,281,0,0q�6d   $	��Top=�6y   $	��135��6�   6�   �� 5   
   -   5        $ btnXoatoanbophantu��5      $"��Xóa toàn bộ phần tử ��6-   $
��Left=�6L   $��145,314,0,0q�6g   $	��Top=�6|   $	��136��6�   6�   �� 5   
   -   5        $ btnXoa1phantu��5      $��Xóa 1 phần tử��6(   $
��Left=�6@   $��145,248,0,0q�6[   $	��Top=�6p   $	��135��6�   6�   �� 5   
   -   5        $ btnSapXepTang��5      $��Sắp xếp tăng��6(   $
��Left=�6?   $��145,177,0,0q�6Z   $	��Top=�6o   $	��135��6�   6�   �� 5   
   -   5        $ btnSapXepGiam��5      $��Sắp xếp giảm��6(   $
��Left=�6?   $��145,215,0,0q�6Z   $	��Top=�6o   $	��135��6�   6�   �� 5   
   -   5        $ btnChen��5      $��Chèn��6"   $
��Left=�61   $��220,147,0,0q�6L   $	��Top=�6a   $��60��6y   6�   �� 5   
   -   5         ��Name$ txtGiaTriChen��5      $
��Left=�6)   $��
185,79,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $��95��6�   $��20��6�   �� 5   
   -	   5        $ txtVitriChen��5      $
��Left=�6(   $��185,114,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $��95��6�   �� 5   
   -
   5        $ 	txtGiatri��5      $
��Left=�6%   $��	11,26,0,0q�6@   $
 Wrap=�6S   $	��Top=�6g   $	��111��6   $��25��6�   �� 5   
   $��
Vị trí:��6   $��Center=�6"   $��	0,110,0,0q�6?   $	��Top=�6R    J� RenderTransformOrigin$ 
0.42,0.541&�6j   �� 5   
   $��Giá trị:��6   $��Center=�6#   $��0,76,0,0q�6@   $	��Top=�6R   �� 5   
   -   5         ��Name$ 	lstDuLieu��5       �� SelectionMode$ Multiple=�6%   $
��Left=�5      $	��278��6'   $��	11,56,0,0q�5      $	��Top=�6   $	��110��5      5      5      