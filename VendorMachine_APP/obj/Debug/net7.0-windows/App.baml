   M S B A M L   `   `   `  ����L  HVendorMachine_APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:VendorMachine_APP.ViewModelVendorMachine_APP.ViewModel  5      ?$clr-namespace:VendorMachine_APP.ViewVendorMachine_APP.View  5          VendorMachine_APP.App   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ?	viewModel)clr-namespace:VendorMachine_APP.ViewModel     5      5view$clr-namespace:VendorMachine_APP.View     5        �� 	Resources  5         TemplateColor  clrSecondary �� DataType1   +VendorMachine_APP.ViewModel.TicketViewModel#   VendorMachine_APP.View.Ticket2   ,VendorMachine_APP.ViewModel.AbonneeViewModel$   VendorMachine_APP.View.Abonnee2   ,VendorMachine_APP.ViewModel.AcceuilViewModel$   VendorMachine_APP.View.Acceuil7   1VendorMachine_APP.ViewModel.CheckAbonneeViewModel)   #VendorMachine_APP.View.CheckAbonnee  Main �� 
TargetType �� Property �� Value  BorderStyle  MainGrid  TitleWindow  	TitleText  BtnMinimize �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value  BtnClose 	 
BtnAcceuil 
 	ImageRfid
 �� ImageSource j� Stretch  ImageQrCode��%  &	        &	      (�� >     5      *, +)(�� p     5      *, +)(�� �     5      *, +)(�� �     5      *, +)&	     &	 S    &	 �    7   &	 =    &	     &	 F    &	 �    &		 	    &	
 �	    &	 �	    ��5
   
   #fbe5e5��69   ��5   
   #20558a��6.   �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   " ��6   .�5      ��  � ��$ 2 0 2 2q�6'   5      �� 5    
   " ��6$   .�5!      ��  �@��CornerRadius$ 10��6-   �� 5"       � ��$ 2q�60   �� 5#       �@J�Opacity$
 0.95Q�6(   5$      �� 5%   
   " �6!   .�5&      ��  � ��8   6+   5'      �� 5(   
   " ��6$   .�5)      ��  � ��$ 30(�6)   �� 5*       � ��$ 0 0 0 50q�6'   �� 5+       � ��$ 	ExtraBold"�6+   �� 5,       �@��TextAlignment$ Center=�6.   5-      �� 5.   
   " ��6   .�5/      ��  � ��
 �����6+   �� 50       � ��$	 Top=�6/   �� 51       � ��$ 14(�6)   �� 52       � �� �#4E87D46+   �� 53       � ��$ Tahoma)�6+   �� 54       � ��$ 
50,50,50,0q�6'   �� 55       � ��$	 300��6&   56      �� 58   
   " ��6   .�59      ��  � ��$ 0q�60   �� 5;       � ��
 �����6+   �� 5<       � ��$ 16(�6)   �� 5=       � ��$ 
Montserrat)�6+   �� 5>       �@�Cursor$
 Hand��6'   �� 5?       � �� �#278BEF6+   �� 5@       � �� 5A      �� 5B      " ��6&   .R�5C      �� $��18��6!   $��18��6,   $ 9��5D   !   #��z��5E   !   ._�5F      �� $��Center=�6/   $��Center=�5G   /   5H      5I      5K       5L      P� 5M       �@J�IsMouseOver$
	 True��61   . �5N      ��  � �� �#C62DAE63   5O      5Q      �� 5R   
   " ��6   .�5S      ��  � ��$ 0q�60   �� 5U       � ��
 �����6+   �� 5V       � ��$ 16(�6)   �� 5W       � ��$ 
Montserrat)�6+   �� 5X       �@�Cursor$
 Hand��6'   �� 5Y       � �� �#DA34AE6+   �� 5Z       � �� 5[      �� 5\      " ��6&   .R�5]      �� $��18��6!   $��18��6,   $ 9��5^   !   #��z��5_   !   ._�5`      �� $��Center=�6/   $��Center=�5a   /   5b      5c      5e       5f      P� 5g       �@J�IsMouseOver$
	 True��61   . �5h      ��  � �� �#C62DAE63   5i      5k      �� 5m   
   " ��6   .�5n      ��  � ��$ 23(�6)   �� 5o       � ��$	 200��6'   �� 5p       � ��$	 200��6&   5s      �� 5u   
   $
 Ressources/Image/RFID.png��6'   $ UniformToFill=�6O   �� 5v   
   $!
 Ressources/Image/QRCode.jpg��6)   $ UniformToFill=�6S   5y      5z      