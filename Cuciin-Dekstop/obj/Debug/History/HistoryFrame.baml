   M S B A M L   `   `   `  ����B  >Velacro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullT7clr-namespace:Velacro.UIElements.Basic;assembly=VelacroVelacro.UIElements.Basic  5      I ECuciin-Dekstop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Cuciin_Dekstop.HistoryCuciin_Dekstop.History 5      )   #Cuciin_Dekstop.History.HistoryFrame   5      Abasic7clr-namespace:Velacro.UIElements.Basic;assembly=Velacro  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Cuciin_Dekstop.History     5        N� Title$  history��5      $
��1080��6   $
��1920��6%    N� FontSize$ 36(�62   .��5
      � .+�5   
   �� $
��1340��6   
���   �$	��Top=�61   $��-570,-87,1625,-173q�6I   $��Right=�6e   $	��865��6�   ��5      �� 5       �� ImageSource$$ ../Drawable/background_nav.png��6   5      �� 5   
   $
��Left=�6   $��	86,78,0,0q�6/   $
��Wrap=�6B   $��CUCI-IN��6V   $	��Top=�6e   $��36(�6}   $	��152��6�   
�������6�   �� 5   
   -   5         ��Name$ dashboard_btn��5      $��	DASHBOARD��6(   $
��Left=�6<   $	��Top=�6W   $	��238��6o   $��
26,155,0,0q�6{   $��63��6�   $��30(�6�   
�������
������ 
������ 6�   �� 5   
   -   5        $ history_btn��5      $��HISTORY��6&   $
��Left=�68   $	��Top=�6S   $	��238��6k   $��
26,238,0,0q�6w   $��63��6�   $��30(�6�   
�������
������ 
������ 6�   �� 5   
   -   5        $ 
logout_btn��5      $��LOGOUT��6%   $
��Left=�66   $	��Top=�6Q   $	��238��6i   $��
26,321,0,0q�6u   $��63��6�   $��30(�6�   
�������
������ 
������ 6�   �� 5   
   $
��Left=�6   $��80��6/   $��
344,76,0,0q�6;   $
��Wrap=�6O   $��History��6c   $	��Top=�6r   $	��441��6�   $��48(�6�   �� 5   
   $
��Left=�6   $��1121,1107,0,-106q�6/   $
��Wrap=�6I   $��	TextBlock��6]   $	��Top=�6n   �� 5   
   $
��Left=�6   $��50��6/   $��344,155,0,0q�6;   $
��Wrap=�6P   $��All Transaction History��6d   $	��Top=�6�   $	��390��6�   $��32(�6�   �� 5   
   $
��Left=�6   $��50��6+   $��	18,76,0,0q�67   $	��Top=�6J   $��50��6b   $!��../Drawable/logo_cuciin.png��6m   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ data_grid_transaction��5      
���   �$
��Left=�5      $	��708��5      $��344,253,0,0q�5      $	��Top=�5      $
��1496��6%      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         MinRowHeight$ 90Q�5       ��. $
��Auto=�5"      $
��Auto=�5#      ��5$      �� 5%       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5&      -   5        5'      5)      5*      5+      