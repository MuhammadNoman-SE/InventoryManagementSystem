   M S B A M L   `   `   `  ����`  \InventoryManagementSystem.PrismClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:InventoryManagementSystem.PrismClient.Control-InventoryManagementSystem.PrismClient.Control  5   	   ?    9InventoryManagementSystem.PrismClient.Control.ShellWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Mlocal;clr-namespace:InventoryManagementSystem.PrismClient.Control     5   	   S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Z VPrism.DryIoc.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	     � Title$  ShellWindow��5	   	   $	��800��6   $	��800��6*    � 	Resources 5
       �� 
TargetType �� Property �� Value��%h   '��       �� 5   
   " ��6   .�5      ��  � �� 6'   �� *DataContext.Title+5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� .+�5      �� $��Publish��6   $��
PersonList��6D   ��6'   �� *
Navigate+6D   �� 5      $��Listen��6   $��PersonDetail��6C   ��6&   �� *
Navigate+6C   5      �� 5   
   $��1��6   !  Prism.Regions.RegionManager   
RegionName$ PublisherRegion��6&   �� 5   
   $��2��6   $ ListenerRegion��6&   �� 5   
   $��3��6   $ ContentRegion��6&   5      5      