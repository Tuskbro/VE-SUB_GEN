   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   	   R NAxInterop.TimelineAxLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullR>clr-namespace:AxTimelineAxLib;assembly=AxInterop.TimelineAxLibAxTimelineAxLib 5   	   B >Preview, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PreviewPreview 5	   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5
   
      Preview.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V	 RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes 	 5   	   Iwf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms 	 5   	   Gax>clr-namespace:AxTimelineAxLib;assembly=AxInterop.TimelineAxLib 	 5   	   !localclr-namespace:Preview 	 5	   	   7dragablz(clr-namespace:Dragablz;assembly=Dragablz 	 5
   
   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   ���#0D0D0D.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��1.8* �6   �� 5      $
��Auto �6   �� 5      $��1* �6   .+�5   
   o� $��0��6   $��24��6   $	��Top=�6(   .@�5      m� $
��File��6   .@�5      m� $
��Open��6   m� 5      $��New project��6   m� 5      $
��Save��6   m� 5      $��Save As��6   m� 5      -   5        $��Import��5   +   $��Import��6   69   m� 5      -   5        $��Export��5   +   $��Export��6   69   m� 5       m� 5!      $
��Exit��6   5"      m� 5#      $��Window��6   5%      m� 5&      $
��Help��6   5(      5)      � 5+   
   $��1��6    � ColumnDefinitions 5,      �� 5-      $��1* �6#   �� 5.      $
��Auto �6#   �� 5/      $��1* �6#   �� 50      $
��Auto �6#   �� 51      $��2* �6#   $	��400��6.   .+�58      ]� $��0��6   .+�59      &   System.Windows.Controls.DataGrid  -   5        $��FileList��59   0   $	��Top=�6      Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      -   5        Name��,  &System.Windows.Controls.DataGridColumn   Header$
 Name��5;   ;     5<      -   5        
Format��$ Format��5<   =     5=      -   5        Size��$
 Size��5=   ;     5>      -   5        Path��$
 Path��5>   ;   5@      5C      ]� 5E      $��4��6   .+�5F      ]� $	��Top=�6   .+�5G      7  1System.Windows.Forms.Integration.WindowsFormsHost  $��Stretch=�6$   $	��200��6B   $��Stretch=�6O      Child. 5H      %   System.Windows.Forms.PictureBox  -	   5        
PictureBox��"   System.Windows.Forms.Control   Dock$
 Fill=�5H   9      SizeMode$ AutoSize=�6E   5I      5J      �� 5K      -
   5        $��RecognitionText��5K   n    �� TextAlignment$ Center=�6   
���   �
�������$	��Top=�6W   $��1��6�   	 �� 	MaxLength$	 50��6�   .��6�   5M      � 5N      $	��Top=�6   $	��400��61   $��Center=�6@   $��40��6]   $	��Top=�6i   .+�5O      �� -   5        $��BackPriviewBtn��5O      $	����6u   $��3q�6�   $��60��6�   $��25��6�   6�   �� 5P      -   5        $��StopPriViewBtn��5P      $��3q�6P   $	����6[   $��60��6g   $��25��6r   6�   �� 5Q      -   5        $��PlayPriviewBtn��5Q      $��3q�6P   $	����6[   $��60��6g   $��25��6r   6�   �� 5R      -   5        $��PausePriviewBtn��5R      $��3q�6S   $	����6^   $��60��6j   $��25��6u   6�   �� 5S      -   5        $��NextPriviewBtn��5S      $��3q�6u   $	����6�   $��60��6�   $��25��6�   6�   �� 5T      -   5        $��MutePriviewBtn��5T      $��3q�6Q   $	����6\   $��60��6h   $��25��6s   6�   5U      5X      �� 5Y      
����� �$��1��61   
 �� ShowsPreview
 .  $��3��6V   $��Center=�5Z   	   $��Stretch=�6&   �� 5[      
����� �$��3��6-   
 .  $��3��6R   $��Center=�5\   	   $��Stretch=�6&   5_        5`   
   -   5        $	��wfh��5`      $��3��6&   . 5a      '  !AxTimelineAxLib.AxTimelineControl  -   5        
axTimeLine��5a   #   5b      �� 5c   
   $��1��6   
 .  $��3��69   $��Stretch=�5d   	   $��Center=�6'   5e      5f      