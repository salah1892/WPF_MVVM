   M S B A M L   `   `   `  ����  VendorMachine_APP"    VendorMachine_APP.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  
MainWindow��5      $	��500��6-   $	��800��6:    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   
������ .��5      ��    BorderStyle#��[  6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #462AD8��6    � Offset$ 0Q�6/   � 5      $ #DA34AE��6   $
 0.75Q�6/   � 5      $ #8A16C1��6   $ 1Q�6/   5      ��5   
   �� 5      $	 0,1&�6"   $	 1,0&�63   .��5      � $ #060531��6   $ 0Q�6/   � 5      $ #1B1448��6   $ 1Q�6/   5      ._�5   
   �   MainGrid#��[ 6   	 � RowDefinitions	 5      �� 5      $��30 �6    �� 5      
 � ColumnDefinitions
 5!      �� 5"      �� 5#      $��25 �6#   �� 5$      $��25 �6#   �� 5%      $��5 �6#   .+�5'      �� -   5        $��1��5(      $��-��5)        BtnMinimize#��[ 5+      5@      �� 5A      -   5        $��2��5B      $��X��5C        BtnClose#��[ 5E      5Z      �� 5[      $��1��6   ��6*   �� *Navigation.CurrentView+5]      5^      5_      