   M S B A M L   `   `   `  ����J  FUiFIS_Prototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:UiFIS_Prototype.Views.Pages.Doctor"UiFIS_Prototype.Views.Pages.Doctor  5      E'clr-namespace:UiFIS_Prototype.ViewModelUiFIS_Prototype.ViewModel  6F   1    +UiFIS_Prototype.Views.Pages.Doctor.MenuPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:UiFIS_Prototype.Views.Pages.Doctor     5      =	viewmodel'clr-namespace:UiFIS_Prototype.ViewModel     6F     N� Title$  MenuPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��5      
������ $��Center=�5      $��Center=�5      $��0q�5       �� SelectionMode$ Extended=�5      ��5      �� *ListOfRecordsOld+ �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5      .R�5      �� $��5q�6!   .+�5      ��  �� Orientation$ 
Horizontal=�5      $��Center=�5      .+�5      �� 
�������$��14(�5    !   $��DemiBold"�5!   !   ��5"   !   �� *PatientNavigation.SecondName+�� 5#      $�� ��6(   �� 5$      
�������$��DemiBold"�5&   !   $��14(�5'   !   ��5(   !   �� *PatientNavigation.FirstName+�� 5)      $�� ��6(   �� 5*      
�������$��DemiBold"�5,   !   $��14(�5-   !   ��5.   !   �� *PatientNavigation.LastName+5/      �� 50      $ 
Horizontal=�51      $��Center=�52      .+�53      �� 
�������$��DemiBold"�55   !   $��14(�56   !   ��57   !   �� * PatientNavigation.BirthdayDate+�� 58      
�������$��DemiBold"�5:   !   $��14(�5;   !   ��5<   !   �� *PatientNavigation.Polices+5=      5>      5?      5A      �� 5B   
   $��1��5C      
������ $��Center=�5F      $��Center=�5G      $��0q�5H      $ Single=�5I      ��5E      �� *ListOfRecords+$ PropertyChanged=� �� SelectedItem 5J      �� *SelectedRecord+��5K      �� 5L      .R�5M      �� $��5q�6!   .+�5N      �� $ 
Horizontal=�5O      $��Center=�5P      .+�5Q      �� 
�������$��14(�5S   !   $��DemiBold"�5T   !   ��5U   !   �� *PatientNavigation.SecondName+�� 5V      $�� ��6(   �� 5W      
�������$��DemiBold"�5Y   !   $��14(�5Z   !   ��5[   !   �� *PatientNavigation.FirstName+�� 5\      $�� ��6(   �� 5]      
�������$��DemiBold"�5_   !   $��14(�5`   !   ��5a   !   �� *PatientNavigation.LastName+5b      �� 5c      $ 
Horizontal=�5d      $��Center=�5e      .+�5f      �� 
�������$��DemiBold"�5h   !   $��14(�5i   !   ��5j   !   �� * PatientNavigation.BirthdayDate+�� 5k      
�������$��DemiBold"�5m   !   $��14(�5n   !   ��5o   !   �� *PatientNavigation.Polices+5p      �� 5q      
�������$��DemiBold"�5t      $��14(�5u      $��Center=�5v      ��5r      �� *
RecordTime+5v      5w      5x      5z      5{      5|      