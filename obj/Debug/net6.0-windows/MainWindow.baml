   M S B A M L   `   `   `  ????J  FAWP_jewerlyshop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AWP_jewerlyshopAWP_jewerlyshop  5   	        AWP_jewerlyshop.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AWP_jewerlyshop     5   	     ? Title$N  HАРМ оператора продаж ювелирных изделий??5   	   $	??450??68   $	??800??6E    ? Icon$ 	/Logo.png??6Q    ? WindowStartupLocation$ CenterScreen=?6b   .??5	      ? ???	#FF1E2946 ? RowDefinitions 5
   
   ?? 5      $	??28* ?6   ?? 5      $
??231* ?6   ?? 5      $	??28* ?6   ?? 5      $	??54* ?6   ?? 5      $	??44* ?6   ?? 5      $	??49* ?6    ? ColumnDefinitions 5   
   ?? 5      $	??27* ?6   ?? 5      $
??141* ?6   ?? 5      $
??338* ?6   ?? 5      $	??81* ?6   ?? 5      $	??26* ?6   ?? 5      $
??136* ?6   ?? 5      $	??28* ?6   ?? 5      $	??23* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 shop??5   8      
IsReadOnly$
 True??6   $??	4,28,6,10q?6%   $??SemiBold"?6F   $??0,0,1,2q?6\   
??????    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6?      FrozenColumnCount$ 12??6?   	   MinColumnWidth$	 5Q?6?   
???   ?$??1??6  $??6??6  $??2??6/  ??6v   ?? ??6?   Z? 
 ? 	Resources
 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType ?? Property ?? Value??%Z   '        ?? 5      "  6   .?5      ??  ? ?? ?	#FFFFDD0063   5       5!      5"      ?? 5#   
   $??1??6   $^??XВведите номер магазина, чтобы продолжить работу??6    $??2,5,10,8q?6Z   $??3??6l   
???????$??18(?6?   $??2??6?   ?? 5$   
   -   5         ??Name$ shop_id_textbox??5$      $??3??6+   $??3??6;    ?? TextWrapping$
 Wrap=?6H   
???   ????	#FFFFDD00$??18(?6?   $??	6,10,6,10q?6?    ?? SelectionBrush ?	#FFFFDD00 ?? SelectionTextBrush ?	#FF1E2946$?? ??6?   ?? 5%   
   -   5         ??Name$ input_shop_id??5%      $??5??6(   $??Ввести??68   $??3,7,5,10q?6I   $??3??6[   ???	#FF1E2946???	#FFFFDD00???	#FFFFDD00$??18(?6?   6?   ?? 5&   
   -   5        $ 	reference??5&      $??1??6$   $??Справка??64   $??4,3,9,9q?6F   $??5??6W   ???	#FF1E2946???	#FFFFDD00???	#FFFFDD00$??18(?6?   6?   5'      5(      