   M S B A M L   `   `   `  ����J  FUiFIS_Prototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:UiFIS_Prototype.ViewsUiFIS_Prototype.Views  5   	   E'clr-namespace:UiFIS_Prototype.ViewModelUiFIS_Prototype.ViewModel  6;   ,    &UiFIS_Prototype.Views.MainDoctorWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:UiFIS_Prototype.Views     5   	   =	viewmodel'clr-namespace:UiFIS_Prototype.ViewModel     6;     � Title$  MainDoctorWindow��5   	   $	��550��6"   $	��860��6/   .��5	      � ���#1C1C1C � ColumnDefinitions 5
   
   �� 5      6!    � RowDefinitions 5   
   �� 5      $��8* �6   6*   �� 5      $��* �6   6)   .+�5   
    � -   5          �Name$ DoctorMainFrame��5        � Source$  ?�5        � NavigationUIVisibility$ Hidden=�5      $��0��5      $��0��5      �� 5   
   ���#464544$��1��5      .+�5      �� $
��Menu��5      $
��Left=�5      $��16(�5      $��DemiBold"�5      
�������
������ $��0q�5!      $��15q�5"      ��5#      �� *MenuCommand+5$      �� 5%   
   $��1��5&      ���#464544 �� Orientation$ 
Horizontal=�5(      $��Center=�5)      .+�5*      �� $��Center=�5+      $��Center=�5,      $
��Info��5-      
������ 
���   �$��16(�50      $��DemiBold"�51      
�������$��5q�53      $	��110��54      ��55      �� *InfoCommand+�� 57      $��Center=�58      $��Center=�59      $��Records��5:      
������ 
���   �$��16(�5=      $��DemiBold"�5>      
�������$��	20 0 20 0q�5@      $��5q�5A      $	��110��5B      ��5C      �� *RecordCommand+�� 5E      $��Center=�5F      $��Center=�5G      $��Appointment��5H      
������ 
���   �$��16(�5K      $��DemiBold"�5L      $��0 0 20 0q�5M      
�������$��5q�5O      $	��110��5P      ��5Q      �� *RetryCommand+�� 5S      -   5        $��ReportButton��5^      $��Center=�5T      $��Center=�5U      $��Report��5V      
������ 
���   �$��16(�5Y      $��DemiBold"�5Z      
�������$��5q�5\      $	��110��5]      ��5_      �� *ReportCommand+5a      5b      5c      