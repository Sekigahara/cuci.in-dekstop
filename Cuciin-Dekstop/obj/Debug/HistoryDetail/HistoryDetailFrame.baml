   M S B A M L   `   `   `  ����B  >Velacro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullT7clr-namespace:Velacro.UIElements.Basic;assembly=VelacroVelacro.UIElements.Basic  5      I ECuciin-Dekstop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Cuciin_Dekstop.HistoryDetailCuciin_Dekstop.HistoryDetail 5      5   /Cuciin_Dekstop.HistoryDetail.HistoryDetailFrame   5      Abasic7clr-namespace:Velacro.UIElements.Basic;assembly=Velacro  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Cuciin_Dekstop.HistoryDetail     5        N� Title$  HistoryDetail��5      $
��1080��6   $
��1920��6-   $��Stretch=�5	      $��Stretch=�5
      .��5      �  J� RenderTransformOrigin$ 
0.502,0.56&�6   .+�5   
   �� $
��Left=�6   $��448,177,0,0q�6/   $
��Wrap=�6D   $��Detail Transaksi��6X   $	��Top=�6p   $��45(�6�   $��Roboto)�6�   $
��Bold"�6�   �� 5   
   $
��1332��6   
���   �$	��Top=�61   $��-541,-87,1593,-165q�6I   $��Right=�6e   $	��868��6�   ��5      �� 5       �� ImageSource$$ ../Drawable/background_nav.png��6   5      �� 5   
   $
��Left=�6   $��452,272,0,0q�6/   $
��Wrap=�6D   $��ID Transaksi��6X   $	��Top=�6l   $��25(�6�   $��Roboto)�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��750,272,0,0q�6/   $
��Wrap=�6D   $��Nama Pembeli��6X   $	��Top=�6l   $��25(�6�   $��Roboto)�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��1036,272,0,0q�6/   $
��Wrap=�6E   $��Alamat Pembeli��6Y   $	��Top=�6o   $��25(�6�   $��Roboto)�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��452,409,0,0q�6/   $
��Wrap=�6D   $��ID Transaksi��6X   $	��Top=�6l   $��25(�6�   $��Roboto)�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��452,452,0,0q�6/   $
��Wrap=�6D   $��ID Transaksi��6X   $	��Top=�6l   $��25(�6�   $��Roboto)�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��685,452,0,0q�6/   $
��Wrap=�6D   $��Berat��6X   $	��Top=�6e   $��25(�6}   $��Roboto)�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��836,452,0,0q�6/   $
��Wrap=�6D   $��Harga Satuan��6X   $	��Top=�6l   $��25(�6�   $��Roboto)�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��1131,452,0,0q�6/   $
��Wrap=�6E   $��Jumlah��6Y   $	��Top=�6g   $��25(�6   $��Roboto)�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��50��6+   $��	62,69,0,0q�67   $	��Top=�6J   $��50��6b   $!��../Drawable/logo_cuciin.png��6m   �� 5   
   -   5         ��Name$ dashboard_btn��5      $��	DASHBOARD��6(   $
��Left=�6<   $	��Top=�6W   $	��238��6o   $��
26,155,0,0q�6{   $��63��6�   $��30(�6�   
�������
������ 
������ 6�   �� 5   
   -   5        $ history_btn��5      $��HISTORY��6&   $
��Left=�68   $	��Top=�6S   $	��238��6k   $��
26,238,0,0q�6w   $��63��6�   $��30(�6�   
�������
������ 
������ 6�   �� 5   
   -   5        $ 
logout_btn��5      $��LOGOUT��6%   $
��Left=�66   $	��Top=�6Q   $	��238��6i   $��
26,321,0,0q�6u   $��63��6�   $��30(�6�   
�������
������ 
������ 6�   �� 5   
   $
��Left=�6   $��
132,73,0,0q�6/   $
��Wrap=�6C   $��CUCI-IN��6W   $	��Top=�6f   $��40(�6~   $
��Lato)�6�   
�������6�   &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ dataGridTransaksi��5!      $
��Left=�5"      $��451,495,0,159q�5#      $	��806��5$      5%      �� 5&   
   $
��Left=�6   $��24��6/   $��452,928,0,0q�6;   $
��Wrap=�6P   $����-------------------------------------------------------------------------------------------------------------------------------------------------------------------------��6d   $	��Top=�6  $	��805��6-  $��25(�69  $��Roboto)�6G  �� 5'   
   $��36��6   $��452,964,624,0q�6    $
��Wrap=�67   $��Total Pembayaran��6K   $	��Top=�6c   $��Roboto)�6{   $��25(�6�   �� 5(   
   -   5         ��Name$ id_transaksi��5(      $
��Left=�6(   $��451,310,0,0q�6C    �� TextWrapping$ WrapWithOverflow=�6X   $��TextBox��6x   $	��Top=�6�   $��25(�6�   $��Roboto)�6�    �� TextAlignment$
 Left=�6�   $	��300��6�   $	��100��6  
������ 6  �� 5)   
   -   5        $ nama_pembeli��5)      $
��Left=�6(   $��750,310,0,0q�6C   $ WrapWithOverflow=�6X   $��TextBox��6x   $	��Top=�6�   $��25(�6�   $��Roboto)�6�   $
 Left=�6�   $	��200��6�   $	��100��6  
������ 6  �� 5*   
   -   5        $ alamat_pembeli��5*      $
��Left=�6*   $��1036,310,0,0q�6E   $ WrapWithOverflow=�6[   $��TextBox��6{   $	��Top=�6�   $��25(�6�   $��Roboto)�6�   $
 Left=�6�   $	��200��6�   $	��100��6  
������ 6  �� 5+   
   -   5        $ 
totalPrice��5+      $��Right=�6&   $��0,964,663,0q�6B   $ WrapWithOverflow=�6W   $	��Top=�6w   $��36��6�   $��Harga��6�   $��25(�6�   $��Roboto)�6�   $ Right=�6�   $	��200��6�   
������ 6  5,      5-      