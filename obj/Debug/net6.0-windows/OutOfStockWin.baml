   M S B A M L   `   `   `  ????J  FAWP_jewerlyshop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AWP_jewerlyshopAWP_jewerlyshop  5   	   #    AWP_jewerlyshop.OutOfStockWin   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AWP_jewerlyshop     5   	     ? Title$N  HАРМ оператора продаж ювелирных изделий??5   	   $	??450??68   $	??800??6E    ? WindowStartupLocation$ CenterScreen=?6Q    ? Icon$ 	/Logo.png??6v   ???	#FF1E2946.??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??9* ?6   ?? 5      $	??92* ?6   ?? 5      $
??346* ?6   ?? 5      $	??82* ?6   ?? 5      $	??92* ?6   ?? 5      $
??172* ?6   ?? 5      $??7* ?6    ? RowDefinitions 5   
   ?? 5      $
??320* ?6   ?? 5      $	??53* ?6   ?? 5      $	??52* ?6   ?? 5      $??9* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ product??5   6      
IsReadOnly$
 True??6   $??3,8,2,6q?6%   $??SemiBold"?6G   $??0,0,1,2q?6]   
??????    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6?      FrozenColumnCount$ 12??6?   	   MinColumnWidth$	 5Q?6?   
???   ?$??7??6  ??6w   ?? ??6?   Z? 
 ? 	Resources
 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType ?? Property ?? Value??%Z   '        ?? 5      "  6   .?5      ??  ? ?? ?	#FFFFDD0063   5      5      5      ?? 5    
   -   5         ??Name$	 del??5       $??Удалить??6   $??1,3,5,7q?60   ???	#FF1E2946$??18(?6X   ???	#FFFFDD00???	#FFFFDD00$??2??6?   $??5??6?   6?   ?? 5!   
   -   5        $
 back??5!      $??
Назад??6   $??1,3,4,7q?6/   ???	#FF1E2946$??18(?6W   ???	#FFFFDD00???	#FFFFDD00$??2??6?   $??1??6?   ?? 5"   
   $??2??6   $F??@Введите номер товара для изменения??6    $??6,4,0,8q?6M   
???????$??18(?6q   $??1??6   ?? 5#   
   -   5         ??Name$ product_id_textbox??5#      $??3??6.    ?? TextWrapping$
 Wrap=?6>   
???   ????	#FFFFDD00$??18(?6|   $??6,8,7,11q?6?    ?? SelectionBrush ?	#FFFFDD00 ?? SelectionTextBrush ?	#FF1E2946$?? ??6?   $??1??6?   ?? 5$   
   -   5        $	 add??5$      $??Пополнить??6   $??4,3,4,7q?62   ???	#FF1E2946$??18(?6Z   ???	#FFFFDD00???	#FFFFDD00$??2??6?   $??3??6?   $??2??6?   5&      5'      