   M S B A M L   `   `   `  ����  WPF_Project"    WPF_Project.Views.RibbonMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Y UPrism.Unity.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59S OPrism.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . .��5
      � .+�5   
   +  %System.Windows.Controls.Ribbon.Ribbon   �� SelectedIndex$ 0��6      HelpPaneContent 5      1  +System.Windows.Controls.Ribbon.RibbonButton  5         SmallImageSource$ Images\help.png��6      QuickAccessToolBar 5      =  7System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  5      .@�5        -   5          Name$
 Save��5   #   $ Images\save.png��62   6  0System.Windows.Controls.Ribbon.RibbonSplitButton  5      -   5          Name$
 Undo��5   (   5  /System.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$ Images\undo.png��67   .@�5      8  2System.Windows.Controls.Ribbon.RibbonSplitMenuItem  $��Undo 1��6.     5      $��Undo 2��6.     5      $��Undo 3��6.   5        5      -   5        $
 Redo��5   (   $ Images\redo.png��66   .@�5        $��Redo 1��6.     5      $��Redo 2��6.   5      5         ApplicationMenu 5!      :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5"      	   KeyTip$	 F��6(   .@�5#      >	  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem	  $��Options��60   3
  -System.Windows.Controls.Ribbon.RibbonMenuItem
 
  ImageSource$
 Images\options.png��6A   	  5$      $
��Exit��60   $
 Images\quit.png��6>   5%      .@�5)      .  (System.Windows.Controls.Ribbon.RibbonTab  $
��Home��6      KeyTip$ H��6&   .@�5+      0  *System.Windows.Controls.Ribbon.RibbonGroup  -   5          Name$ ClipboardGroup��5+      $
��Home��66   .@�5,           LargeImageSource$ Images\paste.png��6'      Label$ Paste��6K   $	 V��6Y   .@�5-      
  $
 Images\paste.png��6)   $��Keep Text Only��6H    
  KeyTip$ T��6`   
  5.      $
 Images\paste.png��6)   $��Paste Special...��6H   $ S��6b   5/        50      $ Images\cut.png��6#      Label$	 Cut��6E      KeyTip$ X��6Q     51      $ Images\copy.png��6#   $
 Copy��6F   $ C��6S     52      $ Images\format_painter.png��6#   $ Format Painter��6P   $ FP��6g   53        56      -   5        $ Employee��56      $��Employee And Payroll��60   .@�57        $ Images\personal.png��6'   $ Employee��6N   $	 V��6_   .@�58      
  $
 Images\paste.png��6)   $��Keep Text Only��6H   $ T��6`   
  59      $
 Images\paste.png��6)   $��Paste Special...��6H   $ S��6b   5:        5;      $ Images\save.png��6#   $
 Save��6F   $ X��6S     5<      $ Images\add.png��6#   $ Send Message to Module��6E   $ C��6d   ��6o   �� *ClickCommand+5=      5?        5B      $��Employee��6   $ E��6*   .@�5C        -   5        $ EmployeeGroup��5C      $��Employee��65   .@�5D        $ Images\cut.png��6#   $ Employee��6E   $ X��6V   ��6b   �� *ClickOnEmployeeCommand+  5E      $ Images\copy.png��6#   $ Print��6F   $ C��6T   5F      5G        5I      $��Student��6   $ S��6)   .@�5J        -   5        $ StudentGroup��5J      $��Student��64   .@�5K        $ Images\cut.png��6#   $ Student��6E   $ X��6U   ��6a   �� *ClickOnStudentCommand+  5L      $ Images\copy.png��6#   $ Print��6F   $ C��6T   5M      5N      5O      5P      5Q      