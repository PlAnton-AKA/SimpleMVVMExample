   M S B A M L   `   `   `  ���� L  HSimpleMVVMExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SimpleMVVMExampleSimpleMVVMExample  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 	  test1  �� 
TargetType �� Property �� Value �� 
TargetType-   'System.Windows.Input.KeyboardNavigation    TabNavigation � RowDefinitions K� ZIndex K� IsItemsHost    TabIndex	 �� CornerRadius
    DirectionalNavigation �� Triggers P� Property P� Value  firstTab ��Name �� 
TargetName   tabItemGeneralHeaderTemplate �� TextAlignment �� Triggers �� Value �� Binding �� Path �� RelativeSource  tabItemSiteHeaderTemplate  tabItemErpHeaderTemplate # tabItemOperationsHeaderTemplate  CloseButton �� 	Resources  Key  ExitButtonImage T� Y 	 ThemedWindowStyle �� Color �Name � ColumnDefinitions ��Name 
 CaptionBackgroundBrush �� Orientation ��Name ��Name �� Padding  ��Name! � Icon" J� SnapsToDevicePixels# �� EdgeMode$ �� BaselineAlignment% � Title  CaptionForegroundBrush& P� 
SourceName�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     )localclr-namespace:SimpleMVVMExample  %X  &	        &	 Q    &	 �    &	 #    &	 E    &	 n    &	 �    7  &		 �	    7  �� "  ��.���  �@�OverridesDefaultStyle . ��  �@J�SnapsToDevicePixels . ��  � �� �� " ��.R�� $ Local=� �� $
��Auto ��� $��* �.+��� $��HeaderPanel��$��0��$ 1��$��0,0,4,-1q� . $ 1��
������ �� $��Border��$��1�����#FFF���#888$��1q�$	 2��$ Local=�$
 	Contained=�$ 2��._��� $��PART_SelectedContentHost��$��4q�$��SelectedContent������ *Name+ P�  � {� .  . ���  � ��
 � �����  � ��
 �  ��P�  � {� . . ���  � ��
 � � ���  � ��
 ������ "  ��.���  � ��
 ���� ��  � �� �� " ��.R��� $��Border��
������ ._��� $ ContentSite��$��Stretch=�$��Stretch=�$��Header�� P�  �@��
IsSelected . . ��� $ Border�� � ��
 �����P�  �@��
IsSelected .  . ��� $ Border�� � ��
 � � �P�  � {� .  . ���  � ��
 �  ��P�  � {� . . ���  � ��
 ������ .R��� $��40��$��40��.+�]� $��10,10,10,10q�.+��� $��tabGeneralImg��$	��Top=�$��img/general_w.png��$��0,0,0,10q��� $��Bottom=�$ Center=�$��15(�	General �� $
 True�� �� $ 
IsSelected� �� *TemplatedParent+.a��� $ tabGeneralImg�� � ��$ img/general_b.png���� .R��� .+�]� $��10,10,10,10q�.+��� $��tabSitelImg��$	��Top=�$��img/sitel_w.png��$��0,0,0,10q��� $��Bottom=�$ Center=�$��15(�Site �� $
 True�� �� $ 
IsSelected� �� *TemplatedParent+.a��� $ tabSitelImg�� � ��$ img/sitel_b.png���� .R��� .+�]� $��10,10,10,10q�.+��� $��	tabErpImg��$	��Top=�$��img/erp options_w.png��$��0,0,0,10q��� $��Bottom=�$ Center=�$��15(�ERP �� $
 True�� �� $ 
IsSelected� �� *TemplatedParent+.a��� $ 	tabErpImg�� � ��$ img/erp options_b.png���� .R��� .+�]� $��10,10,10,10q�.+��� $��tabOperationsImg��$	��Top=�$��img/operations_w.png��$��0,0,0,10q��� $��Bottom=�$ Center=�$��15(�
Operations �� $
 True�� �� $ 
IsSelected� �� *TemplatedParent+.a��� $ tabOperationsImg�� � ��$ img/operations_b.png���� "  �� ���� ExitButtonImage $��img/exit_icon.png��.���  �@�OverridesDefaultStyle . ��  � ��$ 2q���  � ��8   ��  � �� �� " ��.R��� $��border��
������ ._�� .+��� $��content��$��Center=�$��Center=� P�  � �� . . ��� $ content�� � z� T� $	 1.0Q��� "  � ���� BorderBrush $ #ECECEC���� CaptionBackgroundBrush $ Black���� CaptionForegroundBrush $ White��.���  � ��
 �������  �@�AllowsTransparency . ��  � ��$	 100����  � ��$	 100����  �@�WindowStyle$
 None=���  � �� �� " �PART_WindowTemplate��.R�� $ PART_WindowFrame�� �� $��4 ��� $��* ��� $��4 � �� $
��Auto ��� $��* ��� $
��Auto �.+��� $ PART_WindowCaption��$��1��$��0��#��� 
 ._�]� ��. .+��� $��Right=�$ 
Horizontal=�$��Center=�.+��� $# PART_WindowCaptionCloseButton��8��  �� $ PART_WindowCaptionText��$
��Left=�$��6,0,0,0q�$ 0q��� $  PART_WindowCaptionIcon��$��16��$��16��$��0,0,6,0q�#��z! " . $# Aliased=� �� $$ Center=�#�z% #���  ]� $��1��$��1��.+���  P� $& PART_WindowCaptionIcon�� Z�  � ��. ��� $ PART_WindowCaptionIcon�� � y�$ 	Collapsed=��� $ PART_WindowCaptionText�� � ��$ 0q�