   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35N;clr-namespace:System.Windows;assembly=PresentationFrameworkSystem.Windows  5   	   F BWPF_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPF_Project.ViewsWPF_Project.Views 5	   	      WPF_Project.Shell   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   	   @d2http://schemas.microsoft.com/expression/blend/2008      5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5   	   Kvsm;clr-namespace:System.Windows;assembly=PresentationFramework      5   	   Y UPrism.Unity.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59S OPrism.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	   .local1clr-namespace:WPF_Project.Views   5	   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  .  � Title$ PRISM Project��5   	   $	��450��6   $	��800��6,    � 	Resources 5         NoticeBoardOpen �� 
TargetName �� TargetProperty O� KeyTime O� Value  NoticeBoardClose + 'MessageInboxHeaderBorderBackgroundBrush �� EndPoint �� 
StartPoint	 � Color
 � Offset  NoticeBoardCloseArrowButton �� 
TargetType �� Property �� Value �� 
TargetType'   !System.Windows.VisualStateManager   VisualStateGroups%   System.Windows.VisualStateGroup   Transitions%   System.Windows.VisualTransition   GeneratedDuration	   To   States    System.Windows.VisualState   
Storyboard9  3System.Windows.Media.Animation.EasingDoubleKeyFrame F�Name �� Stretch J� Opacity J� RenderTransformOrigin �� ScaleY �� Triggers P� Property P� Value��%*  &	        &	 �     &	 �    &	 F    7���� 5   
   .��5      U� $ MessageInboxGrid��6,   $ (FrameworkElement.Height)�6U   .\�5      �� $ 0��6'   $ 0Q�63   �� 5      $ 0:0:0.3��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ MessageInboxGrid��6,   $ (FrameworkElement.Height)�6U   .\�5      �� $ 0��6'   $	 200Q�63   �� 5      $ 0:0:0.3��6'   $ 0Q�69   5      5      �� 5   
   $ 0.5,1&�5      $ 0.5,0&�5      .��5      � $	 	AliceBlue��6   $
 0Q�5      � 5      $	 	LightBlue��6   $
 1Q�5      5       �� 5"   
   " d�5#      .�5$      ��  � ��$ 1q�5%      �� 5&       � ��8   5'      �� 5(       � ��$ Center=�5)      �� 5*       � ��$ Center=�5+      �� 5,       � ��$ 1q�5-      �� 5.       � �� 5/      �� 50      " d�6&   .R�51      � $	��7,5q�6    52        53   "   CheckStates�� 54   &     55   *   $ 0:0:0.5D�6?   $ Checked��56   ;     57   *   $ 0:0:0.5D�6?   $ 	Unchecked��58   ;   . 5:   &     Checked��. 5;   *   �� .��5<   .   U� $
 path��6L   $ (UIElement.Opacity)�5=   H   .\�5>   2     $ 0��6G   $ 0Q�5?   C   5@   /   U� 5A   .   $ path1��6L   $ (UIElement.Opacity)�5B   H   .\�5C   2     $ 0��6G   $ 0Q�5D   C     5E   2   $ 0:0:0.4��6G   $ 1Q�5F   C   5G   /   5H   +   5I   '     5J   &   	Unchecked��. 5K   *   �� .��5L   .   U� $ path1��6L   $ (UIElement.Opacity)�5M   H   .\�5N   2     $ 0��6G   $ 1Q�5O   C     5P   2   $ 0:0:0.5��6G   $ 0Q�5Q   C   5R   /   U� 5S   .   $
 path��6L   $ (UIElement.Opacity)�5T   H   .\�5U   2     $ 0��6G   $ 0Q�5V   C     5W   2   $ 0:0:0.5��6G   $ 1Q�5X   C   5Y   /   5Z   +   5[   '     5\   &   Indeterminate��66   5]   #   .+�5_      F� $
 path��6#   $��8��5`      $��0q�5a      $��16��5b      ;���0�����@ﴐۊ�@Q�n��T��@�`��0@'y�)�ÿ	
���   �$��Center=�5e      $
 Fill=�5f      $��0��5g      $��Center=�5h      F� 5i      $ path1��6#   $��8��5j      $��0q�5k      $��16��5l      ;���0�����@ﴐۊ�@Q�n��T��@�`��0@'y�)�ÿ	
���   �$��Center=�5o      $ 0Q�5p      $ 0.5,0.5&�5q      $
 Fill=�5r      $��0��5s      $��Center=�5t      z�5u   "   V� 5v   &   .~�5w   *   �� $ -1Q�69   �� 5x   *   �� 5y   *   T� 5z   *   5{   '   5}      5~       5      P� 5�       �@J�IsKeyboardFocused . 5�   "   P� 5�       �@d�	IsChecked$
 trueY�5�   "   P� 5�       � {� .  . �5�   "   ��  � �� �#ADADAD5�   %   5�      5�      5�      �� 5�       �@�Cursor$
 Hand��5�      5�      5�      .��5�      � -   5         �Name$ OuterMainGrid��5�       � RowDefinitions 5�   
   �� 5�      $
��Auto �6   �� 5�      $��* �6   �� 5�      $��20 �6   .+�5�   
   � -   5        $ MenuGrid��5�      $��0��6!   .+�5�      "  WPF_Project.Views.RibbonMenu  5�      � 5�   
   -   5        $ InnerMainGrid��5�      $��1��6&   .+�5�      �� -   5        $��
MainRegion��5�   4   $��0��5�      $	��5,0q�5�      
��� ���!  Prism.Regions.RegionManager   
RegionName$ 
MainRegion��5�   F   5�      5�      �� 5�   
   $��2��6   $��0q�6     �� CornerRadius$  0��6)   $��18��6:   
����ح�$��1q�6a   #���  5�      ._�5�      � .+�5�      d� #���  6   $��18��6U   $��30��6a   $��Button��6l   $��Center=�6}   5�      5�      5�      5�      5�      