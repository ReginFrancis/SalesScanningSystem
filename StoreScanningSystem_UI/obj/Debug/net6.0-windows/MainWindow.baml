   M S B A M L   `   `   `  ����Q  MStoreScanningSystem_UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:StoreScanningSystem_UIStoreScanningSystem_UI  5   	   '    !StoreScanningSystem_UI.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:StoreScanningSystem_UI     5   	     � Title$  
MainWindow��5   	   $	��800��6   $	��800��6)   .��5	      � ��5
   
   �� 5       �� ImageSource$N HC:\MyLearnings\SalesScanningSystem\StoreScanningSystem_UI\sainsburys.jpg��6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $!��Sainsbury's Scanning System��6   $��Center=�67   $��0��6T   $��50(�6b   
��� ���$��Center=�6�   $��6��6�   $	��100��6�   �� 5   
   $��Product Code��6   $��Right=�6(   $��1��6D   $��Center=�6Q   $��20(�6l   $��1��6z   $��50��6�   
�������6�   �� 5   
   -   5        $��txt_productCode��5      $��Center=�6*   $��80��6G   $��1��6R   $��2��6_   $��50��6o   $��Center=�6{   �� 5    
   -   5        $��btn_cart��5    H   
����·�$��Center=�6+   $	��100��6X   $��1��6d   $��3��6q   $��Add to Cart��6�   $��50��6�   $��Center=�6�   6�   �� 5"   
   -   5        $��btn_checkout��5"   +   
����·�$��Right=�6?   $	��150��6[   $��2��6g   $��1��6t   $��	Check Out��6�   $��50��6�   $��Center=�6�   6�   � 5#   
   -   5        $��gridProductList��5#   @   $��2��6   $��2��6#   $��2��63   $y�Hidden=�6W   .+�5$      �� -   5        $��ProductList��5$   #   $��10q�6    �� View 5%      �� 5&      .P�5'      �� $��ProductCode��6)    �� Width$	 120��6>    �� DisplayMemberBinding 6J   �� *Product_Code+�� 5(      $��	UnitPrice��6)   $	 100��6<    6H   �� *
Unit_Price+5)      5+      5,      �� 5.   
   -   5        $��txt_totalPrice��5.      ${�False��6(   $y�Hidden=�6:   $��Center=�6N   $	��120��6k   $��2��6w   $��4��6�   $��50��6�   $��Center=�6�   �� 5/   
   -   5        $��btn_newCustomer��5/   +   
����·�$��Center=�6B   $	��100��6_   $��1��6k   $��4��6x   $��New Customer��6�   $��50��6�   $��Center=�6�   6�   51      52      